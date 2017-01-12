using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class Samolot:SrodekLokomocji
    {
        private int odleglosc;

        protected override void ObliczCene()
        {
            if (this.odleglosc > 200)
                this.cenaBiletu = this.odleglosc * 2.56;
            else
                this.cenaBiletu = 24;
        }
        public override string ToString()
        {
            return "Samolot: ilość miejsc:" + this.iloscMiejsc + ", odległość: " + this.odleglosc + ", cena biletu:" + this.cenaBiletu;
        }
        //konstruktor
        public Samolot(int iloscMiejsc, int odleglosc)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.odleglosc = odleglosc;
            this.ObliczCene();
        }
    }
}
