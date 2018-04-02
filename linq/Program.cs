using System;
using System.Linq;

using MySql.Data.MySqlClient;
namespace ExpertiseSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] numbers = new int[7,2] { {0,3}, {1,3}, {2,3}, {3,3}, {4,2}, {5,3}, {6,5} };
            List<> 
            var connString = "Server=localhost;Database=desktop;Uid=root;Pwd=lichiking"; 
            var connection = new MySqlConnection(connString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from produto",connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while(dataReader.Read()){
                Console.WriteLine("{0,1}",dataReader["nome"]);
            }
            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var x = numbers.Select(g => Where().Sum());
            Console.Write(x);* */
            Expertise expertise = new Expertise();

            expertise.ListExpertise();
        }
    }
}
