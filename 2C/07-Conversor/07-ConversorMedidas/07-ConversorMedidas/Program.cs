using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Quilograma para Grama");
                Console.WriteLine("2 - Quilograma para Tonelada");
                Console.WriteLine("3 - Fahrenheit para Celsius");
                Console.WriteLine("4 - Celsius para Farenheit");
                Console.WriteLine("5 - Celsius para Kelvin");
                Console.WriteLine("6 - Metro para Quilometro");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("Escolha a sua opção");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite Seu Valor");
                double a = double.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine(Conversor.KgParaGrama(a));
                }
                if (x == 2)
                {
                    Console.WriteLine(Conversor.KgParaT(a));
                }
                if (x == 3)
                {
                    Console.WriteLine(Conversor.FParaC(a));
                }
                if (x == 4)
                {
                    Console.WriteLine(Conversor.CParaF(a));
                }
                if (x == 5)
                {
                    Console.WriteLine(Conversor.CParaK(a));
                }
                if (x == 6)
                {
                    Console.WriteLine(Conversor.MetroParaKm(a));
                }
                if (x == 7)
                {
                    break;
                }
            }
        }
    }
}
