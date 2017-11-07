using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace idk
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=bd;Uid=root;Pwd=");
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conexao;
            cmd.CommandText = "Insert into (id,stuff)(3,damn)";

            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();

            Console.WriteLine("DEU BOM");




        }
    }
}
