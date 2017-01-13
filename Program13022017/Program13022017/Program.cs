using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13022017
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            //osoba.AddRecords();
            Console.WriteLine(osoba.DisplayList());
            Console.WriteLine(osoba.DisplayQueue());
            Console.WriteLine(osoba.DisplayStack());
            Console.ReadKey();
        }
    }
}
