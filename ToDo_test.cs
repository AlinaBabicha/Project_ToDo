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
            DateTime Time = DateTime.Now;
            Console.Write("Hello, please enter your name!" + /n);
            string name = Console.ReadLine()
            Console.WriteLine(name + ", do you want to add some plans for today? (Y,N)")
            Console.ReadLine()//дописать логику
            Console.WriteLine("Do you have plans for some other day? If yes, please, enter the date you need, if no, enter 'N'")
        }
    }
}