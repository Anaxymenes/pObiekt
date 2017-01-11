using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class Numbers
    {
        protected List<double> numbersList;
        public List<double> MyProperty { get { return this.numbersList;  } set { } }
        public void AddNumber(string numbers)
        {
            try
            {
                double temp = Double.Parse(numbers);
                this.numbersList.Add(temp);
            }
            catch (FormatException formE)
            {
                Console.WriteLine("\nBłędny format wprowadzonego działania!\nError:" + formE.Message);
                throw;
            }
            catch (ArgumentOutOfRangeException OutE)
            {
                Console.WriteLine("\nPodano za duże liczby!\nError:" + OutE.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
                throw;
            }
        }
        //Konstruktor
        public Numbers()
        {
            this.numbersList = new List<double>();
        }
    }
}
