using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CelsiusEmFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            TempC t1 = new TempC();
            while (true)
            {
                Console.WriteLine("1- Nova Temperatura");
                Console.WriteLine("2- Para Fahrenheit");
                Console.WriteLine("3- Para Kelvin");
                Console.WriteLine("0- Sair");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                    t1.valor = double.Parse(Console.ReadLine());
                else if (x == 2)
                    Console.WriteLine(t1.EmFarenheit());
                else if (x == 3)
                    Console.WriteLine(t1.EmKelvin());
                else if (x == 0)
                    break;
                else
                    Console.WriteLine("erro"); 
            }
        }
    }
}
