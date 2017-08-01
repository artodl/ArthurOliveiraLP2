using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CelsiusEmFarenheit
{
    class TempC
    {
        public double valor;
        public double EmFarenheit()
        {
            double f = 1.8 * valor + 32;
            return f;
        }
        public double EmKelvin()
        {
            return valor + 273;
        }
    }
}
