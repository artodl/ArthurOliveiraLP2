using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numero, pot;
            string nome;
            double km;

            Console.WriteLine("Informe o número de carros");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < numero; i++)
            {
                Console.WriteLine("Informe o nome do carro");
                nome = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem do carro");
                km = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potencia do carro");
                pot = int.Parse(Console.ReadLine());

                Console.WriteLine(Classificar(nome, km, pot));

            }
        }

        public static string Classificar(string modelo, double km, int pot)
        {
            string T, P;

            if (km <= 5000)
                T = "novo";

            else if (km <= 30000)
                T = "seminovo";

            else
                T = "velho";

            if (pot < 120)
                P = "popular";

            else if (pot <= 200)
                P = "forte";

            else
                P = "potente";

            return String.Format("{0} - {1} - {2}", modelo, T, P);
        }
    }
}
