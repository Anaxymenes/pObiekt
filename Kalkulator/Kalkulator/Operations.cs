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
                        wynik = a + b;
                        break;
                    case 2:
                        wynik = a * b;
                        break;
                    case 3:
                        if (b != (double)0)
                            wynik = a / b;
                        else
                            wynik = (int)a / (int)b;
                        break;
                    default:
                        wynik = 0;
                        break;
                }
                return wynik;
            }
            catch (DivideByZeroException eByZero)
            {
                Console.WriteLine("Nie dziel przez zero!\nError:" + eByZero.Message);
                throw;
            }
            catch (ArgumentOutOfRangeException eOutOfRange)
            {
                Console.WriteLine("Przekroczono zakres!\nError:" + eOutOfRange.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
                throw;
            }
        }
    }
}
