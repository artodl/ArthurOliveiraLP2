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
            int A, B, C, D, E, n, bemMarcado = 0, ambiguo = 0;
            string resp;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());
                E = int.Parse(Console.ReadLine());

                if(A <= 100)
                {
                    resp = "A";
                    bemMarcado++;
                    Console.WriteLine(resp);
                }
                else if(A <= 155)
                {
                    ambiguo++;
                }

                if (B <= 100)
                {
                    resp = "B";
                    bemMarcado++;
                    Console.WriteLine(resp);
                }
                else if (B <= 155)
                {
                    ambiguo++;
                }

                if (C <= 100)
                {
                    resp = "C";
                    bemMarcado++;
                    Console.WriteLine(resp);
                }
                else if (C <= 155)
                {
                    ambiguo++;
                }

                if (D <= 100)
                {
                    resp = "D";
                    bemMarcado++;
                    Console.WriteLine(resp);
                }
                else if (D <= 155)
                {
                    ambiguo++;
                }

                if (E <= 100)
                {
                    resp = "E";
                    bemMarcado++;
                    Console.WriteLine(resp);
                }
                else if (E <= 155)
                {
                    ambiguo++;
                }

                else if (bemMarcado != 1 && ambiguo != 0)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
