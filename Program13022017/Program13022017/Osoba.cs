using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13022017
{
    class Osoba
    {
        private string imie;
        public string Imie { get { return this.imie; } set { this.imie = value; } }
        private int wiek;
        public int Wiek { get { return this.wiek; } set { this.wiek = value; } }
        protected Stack<int> stos;
        protected Queue<string> kolejka;
        List<Osoba> lista;


        public string DisplayList()
        {
            string txt;
            try
            {
                txt = "Zawartość listy: ";
                foreach (var c in this.lista)
                    txt += "\nImię:" + c.imie + "; wiek: " + c.wiek;
            }
            catch
            {
                txt = "Nie mam co wyświetlić !";
            }
            txt += "\n";
            return txt;
        }
        public string DisplayQueue()
        {
            string txt;
            try
            {
                txt = "Zawartość kolejki: ";
                foreach (var c in this.kolejka)
                    txt += "\nCiąg znaków:" + c;
            }
            catch
            {
                txt = "Nie mam co wyświetlić !";
            }
            txt += "\n";
            return txt;
        }

        public string DisplayStack()
        {
            string txt;
            try
            {
                txt = "Zawartość stosu: ";
                foreach (var c in this.stos)
                    txt += "\nLiczba:" + c;
            }
            catch
            {
                txt = "Nie mam co wyświetlić !";
            }
            txt += "\n";
            return txt;
        }
        public void AddRecords()
        {
            this.kolejka = new Queue<string>();
            this.kolejka.Enqueue("Ala");
            this.kolejka.Enqueue("Ola");
            this.kolejka.Enqueue("Marek");
            this.kolejka.Enqueue("Monika");
            this.kolejka.Enqueue("Stefan");

            this.stos = new Stack<int>();
            this.stos.Push(20);
            this.stos.Push(8);
            this.stos.Push(7);
            this.stos.Push(18);
            this.stos.Push(26);

            this.lista = new List<Osoba>();
            this.lista.Add(new Osoba("Monika", 18));
            this.lista.Add(new Osoba("Arthur", 28));
            this.lista.Add(new Osoba("Ala", 18));
            this.lista.Add(new Osoba("Szymon", 21));
            this.lista.Add(new Osoba("Ewa", 18));

        }
        //konstruktor
        public Osoba()
        {
            AddRecords();
        }
        public Osoba(string imie, int wiek)
        {
            Imie = imie;
            Wiek = wiek;
        }

    }
}
