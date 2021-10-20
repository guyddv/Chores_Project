using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;

namespace Chores_Project
{
    public class DataAccess
    {
        //private string connectionString;

        public DataAccess(string connectionString)
        {
            Console.WriteLine("Connect to SQL Server and Create, Read, Update and Delete operations.");

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-5E220RG\\SQLSERVER2019";   
            builder.UserID = "sa";              
            builder.Password = "Skoal55gddv";      
            builder.InitialCatalog = "Chores_Project";
        }

        //public void CreateDatabase()
        //{
        //    Console.Write("Connecting to SQL Server ... ");
        //    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        //    {
        //        connection.Open();
        //        Console.WriteLine("Done.");

        //        // Create a sample database
        //        Console.Write("Dropping and creating database 'ChoresDB' ... ");
        //        String sql = "DROP DATABASE IF EXISTS [ChoresDB]; CREATE DATABASE [ChoresDB]";
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            command.ExecuteNonQuery();
        //            Console.WriteLine("Done.");
        //        }
        //    }
        //}

        //public void CreateChoreTable()
        //{
        //    Console.Write("Creating sample table with data, press any key to continue...");
        //    Console.ReadKey(true);
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("USE ChoresDB; ");
        //    sb.Append("CREATE TABLE Chores ( ");
        //    sb.Append(" ChoresId INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
        //    sb.Append(" ChoreName NVARCHAR(50), ");
        //    sb.Append(" ChoreAssignment NVARCHAR(50) ");
        //    sb.Append("); ");
        //    sb.Append("INSERT INTO Chores (ChoreName, ChoreAssignment) VALUES ");
        //    sb.Append("(N'Clean Kitchen', N'Guy'), ");
        //    sb.Append("(N'Trash', N'Stephen'), ");
        //    sb.Append("(N'Walk  Cats', N'Guy'); ");
        //    sql = sb.ToString();
        //    using (SqlCommand command = new SqlCommand(sql, connection))
        //    {
        //        command.ExecuteNonQuery();
        //        Console.WriteLine("Done.");
        //    }
        //}

        //public void AddChore()
        //{
        //    Console.Write("Inserting a new row into table, press any key to continue...");
        //    Console.ReadKey(true);
        //    sb.Clear();
        //    sb.Append("INSERT Chores (ChoreName, ChoreAssignment) ");
        //    sb.Append("VALUES (@name, @assignment);");
        //    sql = sb.ToString();
        //    using (SqlCommand command = new SqlCommand(sql, connection))
        //    {
        //        command.Parameters.AddWithValue("@name", "Clean Bathroom");
        //        command.Parameters.AddWithValue("@assignment", "Stephen");
        //        int rowsAffected = command.ExecuteNonQuery();
        //        Console.WriteLine(rowsAffected + " row(s) inserted");
        //    }
        //}

        //public void UpdateChore()
        //{
        //    String userToUpdate = "Stephen";
        //    Console.Write("Updating 'ChoreAssignment' for user '" + userToUpdate + "', press any key to continue...");
        //    Console.ReadKey(true);
        //    sb.Clear();
        //    sb.Append("UPDATE Chores SET ChoreAssignment = N'Guy' WHERE Name = @name");
        //    sql = sb.ToString();
        //    using (SqlCommand command = new SqlCommand(sql, connection))
        //    {
        //        command.Parameters.AddWithValue("@name", userToUpdate);
        //        int rowsAffected = command.ExecuteNonQuery();
        //        Console.WriteLine(rowsAffected + " row(s) updated");
        //    }
        //}

        //public void DeleteChore()
        //{
        //    String userToDelete = "Clean Kitchen";
        //    Console.Write("Deleting user '" + userToDelete + "', press any key to continue...");
        //    Console.ReadKey(true);
        //    sb.Clear();
        //    sb.Append("DELETE FROM Chores WHERE ChoreName = @name;");
        //    sql = sb.ToString();
        //    using (SqlCommand command = new SqlCommand(sql, connection))
        //    {
        //        command.Parameters.AddWithValue("@name", userToDelete);
        //        int rowsAffected = command.ExecuteNonQuery();
        //        Console.WriteLine(rowsAffected + " row(s) deleted");
        //    }
        //}

        //public void GetChores()
        //{
        //    Console.WriteLine("Reading data from table, press any key to continue...");
        //    Console.ReadKey(true);
        //    sql = "SELECT ChoreId, ChoreName, ChoreAssignment FROM Chores;";
        //    using (SqlCommand command = new SqlCommand(sql, connection))
        //    {

        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Console.WriteLine("{0} {1} {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
        //            }
        //        }
        //    }
        //}
    }
}
