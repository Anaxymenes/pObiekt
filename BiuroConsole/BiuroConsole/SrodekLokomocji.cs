using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;
        public double CenaBiletu { get { return this.cenaBiletu; }  }
        protected virtual void ObliczCene()
        {
            this.cenaBiletu = this.iloscMiejsc * 3;
        }
        //konstruktor
        public SrodekLokomocji()
        {

        }
    }
}
