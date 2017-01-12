using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiuroConsole
{
    class Menu
    {
        MenuPlan menuPlan;
        protected void DisplayManu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Witaj w aplikacji Biura Podrozy 'Ostatnia podróż'");
                Console.WriteLine("<!-----------------MENU GŁÓWNE--------------!>");
                Console.WriteLine("P - Zaplanuj plan podróży");
                Console.WriteLine("E - Wyjscie z aplikacji");
                ConsoleKeyInfo eKey = Console.ReadKey();
                if (eKey.Key == ConsoleKey.P) this.menuPlan.Menu();
                if (eKey.Key == ConsoleKey.E) Environment.Exit(0);
            }
        }

        //konstruktor
        public Menu()
        {
            this.menuPlan = new MenuPlan();
            this.DisplayManu();
        }
    }
}
