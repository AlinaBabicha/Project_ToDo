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

        }
    }
}