using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class Operations:ICount
    {
        public double Count(double a, double b, int symbol)
        {
            try
            {
                double wynik = 0;
                switch (symbol)
                {
                    case 1:
                        wynik =  a + b;
                        break;
                    case 2:
                        wynik = a * b;
                        break;
                    case 3:
                        wynik = a / b;
                        break;
                    default:
                        wynik = 0;
                        break;
                }
                return wynik;
            }
            catch
            {
                throw;
            }
        }
    }
}
