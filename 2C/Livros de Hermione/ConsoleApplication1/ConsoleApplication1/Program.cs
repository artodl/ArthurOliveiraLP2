using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int NroLivros = int.Parse(Console.ReadLine());
            int pph = int.Parse(Console.ReadLine());
            int hpd = int.Parse(Console.ReadLine());
            Livro[] livros = new Livro [n];
            for(i = 0; i <= NroLivros; i++)
            {
                Livro L = new Livro();
                L.título = Console.ReadLine();
                L.qtdPag = int.Parse(Console.ReadLine());
                L.DiasDevol = int.Parse(Console.ReadLine());
            }

        }
    }
}
