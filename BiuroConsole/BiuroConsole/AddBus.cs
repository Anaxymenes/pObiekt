using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class AddBus : Add
    {
        public override void AddNew()
        {
            base.AddNew();
            try
            {
                this.podroz.DodajAutobus(Int32.Parse(iloscMiejsc));
            }
            catch
            {
                Console.WriteLine("\nPodaj jako parametr ilosci miejsc jako liczbę całkowitą!!!\nNaciśnij dowolny klawisz aby kontynuować...");
                Console.ReadKey();
            }
        }
        //konstruktor
        public AddBus(Podroz podroz) : base(podroz)
        {
            this.AddNew();
        }
    }
}
