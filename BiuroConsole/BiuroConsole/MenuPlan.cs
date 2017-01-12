using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class MenuPlan
    {
        protected Podroz podroz;
        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("<!---------------MENU PLANOWANIA------------!>");
                Console.WriteLine("");
                Console.WriteLine("Wybierz co chcesz zrobić:");
                Console.WriteLine("C - Sprawdź aktualnie ustawioną podróż");
                Console.WriteLine("D - Ustal datę podróży");
                Console.WriteLine("S - Dodaj samolot");
                Console.WriteLine("A - Dodaj autobus");
                Console.WriteLine("U - Usuń ostatnią pozycję z planu podróży");
                Console.WriteLine("B - Powrót");
                ConsoleKeyInfo eKey = Console.ReadKey();
                if (eKey.Key == ConsoleKey.C) CheckCurrentTravel();
                if (eKey.Key == ConsoleKey.B) break;
                if (eKey.Key == ConsoleKey.D) this.podroz.UstawDate(AddTravelDate());
                if (eKey.Key == ConsoleKey.A) this.AddBus();
                if (eKey.Key == ConsoleKey.S) this.AddPlane();
                if (eKey.Key == ConsoleKey.U) this.podroz.UsunOstatni();

            }
        }
        protected virtual void AddBus()
        {
            AddBus newBud = new AddBus(this.podroz);
        }
        protected virtual void AddPlane()
        {
            AddPlane newPlane = new AddPlane(this.podroz);
        }
        protected virtual void CheckCurrentTravel()
        {
            Console.Clear();
            try
            {
                Console.WriteLine(podroz.ToString());
            }
            catch
            {
                Console.WriteLine("Brak aktualnie planowanej podróży!");
            } 
            Console.WriteLine("Naciśnij klawisz by kontynuować...");
            Console.ReadKey();
        }
        
        protected virtual DateTime AddTravelDate()
        {
            Date date = new Date();
            return date.Menu();
        }

        //konstruktor
        public MenuPlan(Podroz podroz)
        {
            this.podroz = podroz;
        }
    }
}
