using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Getting Connection ...");

            var datasource = @"DESKTOP-O8HRJM5\SQLEXPRESS"; // your server
            var database = "Dotnet"; // your database name
            //var username = "DESKTOP-LCNNVH9\\kk"; // username of server to connect
            //var password = ""; // password

            // Create your connection string
            string connString = @"Data Source=" + datasource +
                ";Initial Catalog=" + database + "; Trusted_Connection=True;";


            Console.WriteLine(connString);

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Opening Connection ...");
                // Open the connection
                conn.Open();
                Console.WriteLine("Connection successful!");
                InsertStaff(conn);
                displayStaff(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }


        }
        static void InsertStaff(SqlConnection conn)
        {
            Console.Write("Enter the Staff Name...");

            string myname = "esya";
            int id = 1;
            string querry = "insert into food (food_id,name) values("+ id + ",'" + myname + "')";
            SqlCommand cm = new SqlCommand(querry, conn);
            cm.Parameters.AddWithValue("@name", myname);
            cm.Parameters.AddWithValue("@food_id", id);
            int rows = cm.ExecuteNonQuery();
            if (rows > 0)  
            {
                Console.WriteLine("Inseted recordsuccessfully");
            }


        }
        static void displayStaff(SqlConnection conn)
        {
            string query = "select * from food";
            SqlCommand cm = new SqlCommand(query, conn);
            SqlDataReader reader = cm.ExecuteReader();
            Console.WriteLine("Staff :");
            while (reader.Read())
            {
                {
                    Console.WriteLine($"Name :{reader["name"]}\n FoodId :{reader["food_id"]}");

                }
            }
        }
    }
}
