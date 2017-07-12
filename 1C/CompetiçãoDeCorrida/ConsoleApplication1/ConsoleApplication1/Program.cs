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
            double t1, t2, t3;
            string nome;
            int n, i;

            Console.WriteLine("informe o numero de competidores");
            n = int.Parse(Console.ReadLine());

            Competidor[] competidores = new Competidor[n];

            for(i=0; i < n; i++)
            {
                Competidor corredor = new Competidor();
                Console.WriteLine("informe o nome");
                nome = Console.ReadLine();
                corredor.nome = nome;
                competidores[i] = corredor;
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o primeiro tempo do competidor {0}", i + 1);
                t1 = Convert.ToDouble(Console.ReadLine());
                competidores[i].t1 = t1;
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o segundo tempo do competidor {0}", i + 1);
                t2 = Convert.ToDouble(Console.ReadLine());
                competidores[i].t2 = t2;
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o terceiro tempo do competidor {0}", i + 1);
                t3 = Convert.ToDouble(Console.ReadLine());
                competidores[i].t3 = t3;
            }
            string vencedor = competidores[0].nome;
            double TempoVencedor = competidores[0].TempoOficial();

            for (i = 0; i < n; i++)
            {
                if (competidores[i].TempoOficial() < TempoVencedor)
                {
                    TempoVencedor = competidores[i].TempoOficial();
                    vencedor = competidores[i].nome;
                }

            }
            Console.WriteLine("O vencedor é {0}", vencedor);

        }
    }
}
