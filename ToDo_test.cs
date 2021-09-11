using System;
using MySqlConnector;

namespace Project_ToDo
{
    class Database
    {
        static void Main(string[] args)
        {
            MySqlConnection connection = new MySqlConnection("Data Source=localhost;Database=project_test;User ID=root;");
            connection.Open();
            Console.WriteLine("Coonection with the server is established");

            var command = new MySqlCommand("SELECT * FROM TODO_TEST", connection);
            var myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine(myReader.GetInt32(0) + ") " + myReader.GetDateTime(1) + " " + myReader.GetString(2) + "- " + myReader.GetString(3) + " ");
            }
        }
    }
}