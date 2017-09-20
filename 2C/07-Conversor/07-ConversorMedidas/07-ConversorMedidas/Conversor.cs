using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Conversor
    {
        public static double KgParaGrama(double x)
        {
            return x * 1000;
        }
        public static double GramaParaKg(double x)
        {
            return x / 1000;
        }
        public static double KgParaT(double x)
        {
            return x / 1000;
        }
        public static double KgParaLib(double x)
        {
            return x * 2.2046;
        }
        public static double LibParaKg(double x)
        {
            return x / 2.2046;
        }

        public static double CParaK(double x)
        {
            return x + 273;
        }

        public static double CParaF(double x)
        {
            return (x * 9 / 5) + 32;
        }

        public static double FParaC(double x)
        {
            return (x - 32) / 1.8;
        }
        public static double FParaK(double x)
        {
            return (x - 32) / 1.8 + 273;
        }
        public static double KParaC(double x)
        {
            return x - 273;
        }
        public static double KParaF(double x)
        {
            return (x - 273.15) * 1.8000 + 32.00;
        }
        public static double MetroParaKm(double x)
        {
            return x / 1000;
        }
        public static double KmParaMetro(double x)
        {
            return x * 1000;
        }
        public static double MetroParaPes(double x)
        {
            return x * 3.2808;
        }
        public static double PesParaMetro(double x)
        {
            return x / 3.2808;
        }
        public static double KmParaMilha(double x)
        {
            return x / 0.62137;
        }
        public static double MilhaParaKm(double x)
        {
            return x * 0.62137;
        }
        public static double PesParaPolegada(double x)
        {
            return x * 12;
        }
        public static double PolegadaParaPes(double x)
        {
            return x / 12;
        }
        public static double MetroParaPolegada(double x)
        {
            return x * 39.370;
        }
        public static double PolegadaParaMetro(double x)
        {
            return x / 39.370;
        }
    }
