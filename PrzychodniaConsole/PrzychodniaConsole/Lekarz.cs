using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzychodniaConsole
{
    class Lekarz : Osoba
    {
        private string specjalnosc;
        public override string ToString()
        {
            return "Lekarz " + this.imieNazwisko + ", specjalność:" + this.specjalnosc;
        }
        public Lekarz(string imieNazwisko, string specjalnosc) : base(imieNazwisko)
        {
            this.specjalnosc = specjalnosc;
        }
    }
}
