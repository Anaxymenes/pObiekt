using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrzychodniaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Przychodnia przychodnia = new Przychodnia();
            przychodnia.UstawLekarza("Jan Nowak", "Internista");
            przychodnia.ZapiszDoLekarza("Monika Kurcz", 20, "Grypa");
            przychodnia.ZapiszDoLekarza("Kamil Kowalski", 25, "Suchoty");
            przychodnia.ZapiszDoLekarza("Ewa Nieznana", 28, "Kiła");
            //string a = przychodnia.WykonajPorade();
            //Console.WriteLine(a);
            //a = przychodnia.WykonajBadanie();
            //Console.WriteLine(a);
            Console.WriteLine(przychodnia.ToString());
            przychodnia.GenerujRaport();
            Console.ReadKey();
        }
    }
}
