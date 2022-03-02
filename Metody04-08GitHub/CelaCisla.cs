using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08GitHub
{
    class CelaCisla
    {
        public static double Mocnina(int zaklad, int exponent)
        {
            double vysledek = zaklad;
            if (exponent == 0)
            {
                vysledek = 1;
            }
            else if (exponent > 0)
            {
                for (int i = 2; i <= exponent; i++)
                {
                    vysledek *= zaklad;
                }
            }
            else
            {
                exponent = -exponent;
                double meziVypocet = zaklad;
                for (int i = 2; i <= exponent; i++)
                {
                    meziVypocet *= zaklad;
                }
                vysledek = 1 / meziVypocet;
            }
            return vysledek;
        }
        public static double Faktorial(int x)
        {
            double vysledek = 1;
            for (int i = 1; i <= x; i++)
            {
                vysledek = vysledek * i;
            }
            return vysledek;
        }
        public static double SoucetLichCifer(int x)
        {
            double vysledek = 0;
            int cifra;
            while (x % 10 != 0)
            {
                cifra = x % 10;
                if (cifra % 2 != 0)
                {
                    vysledek += cifra;
                }
                x = x / 10;
            }
            return vysledek;
        }
        public static bool JePrvocislo(int x)
        {
            int pocetDelitelu = 0;
            bool vysledek = false;
            if (x == 1)
            {
                vysledek = false;
            }
            else
            {
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    pocetDelitelu++;
                }
            }
            if (pocetDelitelu > 2)
            {
                vysledek = false;
            }
            else vysledek = true;
            }
            return vysledek;
        }
        public static int PocetSudychDelitelu(int x)
        {
            int vysledek = 0;
            for (int i = 2; i <= x; i = i+2)
            {
                if (x % i == 0)
                {
                    vysledek++;
                }
            }
            return vysledek;
        }
    }
}
