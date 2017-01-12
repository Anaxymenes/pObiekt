using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    abstract class Add

    {
        protected Podroz podroz;
        protected string iloscMiejsc;
        public virtual void AddNew()
        {
            Console.Clear();
            Console.Write("Podaj ilość miejsc (liczba całkowita!): ");
            iloscMiejsc = Console.ReadLine();
        }
        //konstruktor
        public Add(Podroz podroz)
        {
            this.podroz = podroz;
        }
    }
}
