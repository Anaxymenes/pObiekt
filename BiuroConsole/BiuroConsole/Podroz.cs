using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class Podroz:IZarzadzaj,IData
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy;
        private double koszt = 200;

        public void DodajAutobus(int iloscMiejsc)
        {
            Autobus temp = new Autobus(iloscMiejsc);
            this.planPodrozy.Add(temp);
            this.koszt += temp.CenaBiletu;
        }

        public void DodajSamolot(int iloscMiejsc, int odleglosc)
        {
            Samolot temp = new Samolot(iloscMiejsc, odleglosc);
            this.planPodrozy.Add(temp);
            this.koszt += temp.CenaBiletu;
        }

        public void UsunOstatni()
        {
            int index = this.planPodrozy.Count();
            this.planPodrozy.RemoveAt(index-1);
        }

        public void Wyczysc()
        {
            this.planPodrozy.Clear();
        }

        public void UstawDate(DateTime data)
        {
            Console.WriteLine("Tu jestem");
            this.dataPodrozy = new DateTime();
            this.dataPodrozy = data;
        }

        public bool SprawdzDate()
        {
            try
            {
                if (this.dataPodrozy > DateTime.Now)
                    return true;
                else
                    return false;
            }
            catch (NullReferenceException eNull)
            {
                Console.WriteLine("Brak ustalonej daty podróży!");
                return false;
            }
        }

        public override string ToString()
        {
            string txt = "";
            if (SprawdzDate() == true) txt += "Data podróży: " + this.dataPodrozy;
            txt += "Plan podróży:";
            foreach (var c in this.planPodrozy)
                txt += "\n" + c.ToString();
            //for (int i = 0; i < this.planPodrozy.Count; i++)
            //    txt += "\n"+this.planPodrozy[i];
            txt +="\nKoszt całkowity:"+this.koszt;
            return txt;
        }

        //konstruktor
        public Podroz()
        {
            this.planPodrozy = new List<SrodekLokomocji>();
        }
    }
}
