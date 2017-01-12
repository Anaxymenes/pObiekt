using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class Date
    {
        public virtual DateTime Menu()
        {
            Console.Clear();
            Console.WriteLine("Podaj datę podróży\nWymagany format daty to dd.mm.rr gg:mm:ss lub yyyy/mm/dd gg:mm:ss");
            string txt = Console.ReadLine();
            try
            {
                DateTime date = DateTime.Parse(txt);
                //Console.WriteLine("Data podróży: "+date.ToString());
                return date;
            }
            catch(Exception e)
            {
                Console.Write("Błędny format daty!\nError:"+e.Message);
                throw;
            }
        }
        public Date()
        {
        }
    }
}
