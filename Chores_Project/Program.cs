using System;
using System.Text;
using System.Data.SqlClient;

namespace Chores_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connect to SQL Server and Create, Read, Update and Delete operations.");

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-5E220RG\\SQLSERVER2019";
            builder.UserID = "sa";
            builder.Password = "Skoal40gddv";
            builder.InitialCatalog = "Chores_Project";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                Console.WriteLine("Done.");

                Console.Write("Dropping and creating database 'SampleDB' ... ");
                String sql = "DROP DATABASE IF EXISTS [ChoresDB]; CREATE DATABASE [ChoresDB]";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Done.");
                }

                Console.Write("Creating sample table with data, press any key to continue...");
                Console.ReadKey(true);
                StringBuilder sb = new StringBuilder();
                sb.Append("USE ChoresDB; ");
                sb.Append("CREATE TABLE Chores ( ");
                sb.Append(" ChoresId INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
                sb.Append(" ChoreName NVARCHAR(50), ");
                sb.Append(" ChoreAssignment NVARCHAR(50) ");
                sb.Append("); ");
                sb.Append("INSERT INTO Chores (ChoreName, ChoreAssignment) VALUES ");
                sb.Append("(N'Clean Kitchen', N'Guy'), ");
                sb.Append("(N'Trash', N'Stephen'), ");
                sb.Append("(N'Walk  Cats', N'Guy'); ");
                sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Done.");
                }

                Console.Write("Inserting a new row into table, press any key to continue...");
                Console.ReadKey(true);
                sb.Clear();
                sb.Append("INSERT Chores (ChoreName, ChoreAssignment) ");
                sb.Append("VALUES (@name, @assignment);");
                sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", "Clean Bathroom");
                    command.Parameters.AddWithValue("@assignment", "Stephen");
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected + " row(s) inserted");
                }

                String userToUpdate = "Stephen";
                Console.Write("Updating 'ChoreAssignment' for user '" + userToUpdate + "', press any key to continue...");
                Console.ReadKey(true);
                sb.Clear();
                sb.Append("UPDATE Chores SET ChoreAssignment = N'Guy' WHERE Name = @name");
                sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", userToUpdate);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected + " row(s) updated");
                }

                String userToDelete = "Clean Kitchen";
                Console.Write("Deleting user '" + userToDelete + "', press any key to continue...");
                Console.ReadKey(true);
                sb.Clear();
                sb.Append("DELETE FROM Chores WHERE ChoreName = @name;");
                sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", userToDelete);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected + " row(s) deleted");
                }

                Console.WriteLine("Reading data from table, press any key to continue...");
                Console.ReadKey(true);
                sql = "SELECT ChoreId, ChoreName, ChoreAssignment FROM Chores;";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1} {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        }
                    }
                }
            }
        }
    }
}
