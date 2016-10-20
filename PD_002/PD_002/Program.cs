using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PD_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //string carName = "Mój samochód\n";

            //Console.WriteLine(carName);

            //Car car1 = new Car();
            //car1.marka = "Ford";
            //car1.rok = 2001;
            //Car car2 = new Car();
            //car2.marka = "Opel";
            //car2.rok = 1999;
            //Console.WriteLine("Marka: {0} Rok: {1}\n", car1.marka, car1.rok);
            //Console.WriteLine("Marka: {0} Rok: {1}\n", car2.marka, car2.rok);

            //car1 = car2;
            //Console.WriteLine("Marka: {0} Rok: {1}\n", car1.marka, car1.rok);
            //Console.WriteLine("Marka: {0} Rok: {1}\n", car2.marka, car2.rok);

            Car car = new Car();
            car.marka = "Ford";
            car.rok = 2016;
            car.srednieSpalanie = 4.8;
            Console.Write("Podaj dystans: ");
            double dystans = Double.Parse(Console.ReadLine());
            Console.Write("Podaj cene za litr paliwa: ");
            double cena = Double.Parse(Console.ReadLine());
            Console.WriteLine("Koszt przejazdu dla samochodu marki {0} z roku {1} \nze średnim spalaniem wynoszącym {2}, wynosi {3}", car.marka, car.rok, car.srednieSpalanie,car.ObliczKosztPrzejazdu(dystans,cena));


            Console.ReadKey();
        }
    }
}
