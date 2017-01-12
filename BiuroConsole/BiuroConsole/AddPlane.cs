using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class AddPlane : Add
    {
        public override void AddNew()
        {
            base.AddNew();
            Console.Write("\nPodaje odległość: ");
            string odleglosc = Console.ReadLine();
            try
            {
                this.podroz.DodajSamolot(Int32.Parse(iloscMiejsc), Int32.Parse(odleglosc));
            }
            catch
            {
                Console.WriteLine("\nPodaj jako parametry dlugosci i ilosci miejsc liczby całkowite!!!\nNaciśnij dowolny klawisz aby kontynuować...");
                Console.ReadKey();
            }
        }
        //konstruktor
        public AddPlane(Podroz podroz):base(podroz)
        {
            this.AddNew();
        }
    }
}
