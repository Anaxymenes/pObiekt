using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    interface IZarzadzaj
    {
        void DodajAutobus(int iloscMiejsc);
        void DodajSamolot(int iloscMiejsc, int odleglosc);
        void UsunOstatni();
        void Wyczysc();     
    }
}
