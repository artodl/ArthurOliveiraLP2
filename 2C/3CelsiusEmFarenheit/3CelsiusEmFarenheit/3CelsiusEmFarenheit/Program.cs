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
            TempC t1 = new TempC();
            Console.WriteLine("Informe a temperatura");
            t1.valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 para nova temperatura \n2 para Fahrenheit \n3 para Kelvin \n0 sair");
            int comando = int.Parse(Console.ReadLine());


            Console.WriteLine(t1.EmFarenheit());
            Console.WriteLine(t1.EmKelvin());
        }
    }
}
