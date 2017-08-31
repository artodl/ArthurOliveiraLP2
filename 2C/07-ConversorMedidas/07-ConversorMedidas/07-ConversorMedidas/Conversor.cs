using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Conversor
    {
        public static double KparaF(double KF)
        {
            double FK = 1.8 * (KF - 273) + 32;
            return FK;
        }

        public static double FparaK(double FK)
        {
            double KF = (FK + 459.67) * (5.0/9);
            return KF;
        }

        public static double KparaC(double KC)
        {
            double CK = KC - 273;
            return CK;
        }

        public static double CparaK(double CK)
        {
            double KC = CK + 273;
            return KC;
        }

        public static double FparaC(double FC)
        {
            double CF = 1.8 * FC + 32;
            return CF;
        }

        public static double CparaF(double CF)
        {
            double FC = 1.8 * CF + 32;
            return FC;
        }
    }
}
