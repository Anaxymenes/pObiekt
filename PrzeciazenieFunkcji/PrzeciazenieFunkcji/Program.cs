using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrzeciazenieFunkcji
{
    class Program
    {
        static void opiszTyp(int a)
        {
            Console.WriteLine("Typ int {0}", a);
        }

        static void opiszTyp(string a)
        {
            Console.WriteLine("Typ string {0}", a);
        }
        static void opiszTyp(double a)
        {
            Console.WriteLine("Typ double {0}", a);
        }
        static void opiszTyp(bool a)
        {
            Console.WriteLine("Typ bool {0}", a);
        }
        static void Main(string[] args)
        {
            opiszTyp(5);
            opiszTyp("Ala ma kota");
            opiszTyp(3.212);
            opiszTyp(true);
            Console.ReadKey();
        }
    
    }

}
