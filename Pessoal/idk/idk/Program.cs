using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace idk
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection("Data Source=EN2LIA_15; Initial Catalog=idk; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conexao;
            cmd.CommandText = "INSERT INTO tabelaidk(id,stuff,shit) VALUES(1,'damn','son');";

            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();

            Console.WriteLine("fon");




        }
    }
}
