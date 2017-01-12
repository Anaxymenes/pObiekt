using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class Autobus:SrodekLokomocji
    {
        public override string ToString()
        {
            return "Autobus:ilość miejsc:" + this.iloscMiejsc + ", cena biletu:" + this.cenaBiletu;
        }
        //konstruktor
        public Autobus(int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
            base.ObliczCene();
        }
    }
}
