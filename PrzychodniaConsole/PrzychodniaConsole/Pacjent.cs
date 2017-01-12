using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzychodniaConsole
{
    class Pacjent : Osoba
    {
        private int wiek;
        private string choroba;

        public Pacjent(string imieNazwisko, int wiek, string choroba) : base(imieNazwisko)
        {
            this.wiek = wiek;
            this.choroba = choroba;
        }
        public override string ToString()
        {
            return "Pacjent "+this.imieNazwisko + ",wiek " + this.wiek + ", choroba:" + this.choroba;
        }
    }
}
