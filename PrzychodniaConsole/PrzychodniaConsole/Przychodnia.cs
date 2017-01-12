using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzychodniaConsole
{
    class Przychodnia:IPrzychodnia
    {
        private Lekarz lekarz;
        private Stack<Pacjent> pacjenci;

        public int CzasOczekiwania()
        {
            return (int)this.pacjenci.Count / 5;
        }

        public void GenerujRaport()
        {
            string txt = this.ToString();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Raporty";
            if (!Directory.Exists(path))
                try
                {
                    Directory.CreateDirectory(path);
                }catch
                {
                    return;
                }
            path += @"\Raport" + DateTime.Now.Day + DateTime.Now.Month
                    + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + ".txt";
            //Console.WriteLine(path);
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(txt);
            }
        }

        public void UstawLekarza(string imieNazwisko, string specjalnosc)
        {
            this.lekarz = new Lekarz(imieNazwisko, specjalnosc);
        }

        public string WykonajBadanie()
        {
            Pacjent temp = this.pacjenci.First();
            return "Wykonano badanie! " + temp.ToString();
        }

        public string WykonajPorade()
        {
            Pacjent temp = this.pacjenci.Pop();
            return "Wykonano poradę! "+temp.ToString();
        }

        public void ZapiszDoLekarza(string imieNazwisko, int wiek, string choroba)
        {
            this.pacjenci.Push(new Pacjent(imieNazwisko, wiek, choroba));
        }
        public override string ToString()
        {
            string txt = this.lekarz.ToString() + "\nPacjenci oczekujący: ";
            foreach(var c in this.pacjenci)
                txt +="\n-"+c.ToString();
            txt += "\nCzas oczekiwania: " + this.CzasOczekiwania();
            return txt;
        }
        public Przychodnia()
        {
            this.pacjenci = new Stack<Pacjent>();
        }

    }
}
