using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class CalculatorDisplay
    {
        public virtual string Operation()
        {
            Console.Clear();
            Console.Write("Podaj działanie do obliczenia: ");
            return Console.ReadLine();
        }
        public virtual void Again()
        {
            while(true)
            {
                Console.WriteLine("Jeszcze raz ? (t - tak, n-nie)");
                ConsoleKeyInfo eKey = Console.ReadKey();
                if (eKey.Key == ConsoleKey.T) return;
                if (eKey.Key == ConsoleKey.N) Environment.Exit(0);
                Console.WriteLine("Można wybrać tylko między 't' lub 'n'");
            }
        }
        public CalculatorDisplay()
        {

        }
    }
}
