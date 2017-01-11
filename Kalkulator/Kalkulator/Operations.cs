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
                switch (symbol)
                {
                    case 1:
                        return (double) a + b;
                        break;
                    case 2:
                        return a * b;
                        break;
                    case 3:
                        return a / b;
                        break;
                    default:
                        return 0;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
