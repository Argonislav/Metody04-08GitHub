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
    }
}
