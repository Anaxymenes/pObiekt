using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class Calculator
    {
        Symbols symbols;
        Numbers numbers;
        CalculatorDisplay display;
        protected virtual void Menu()
        {
            try
            {
                string operation = this.display.Operation();
                this.Separate(operation);
            }
            catch
            {
                this.symbols.ClearAllSymbols();
                this.numbers.ClearNumberList();
            }
            this.display.Again();
            this.Menu();
        }
        protected virtual void ShowMeAllNumbers()
        {
            Console.WriteLine("Oto podane liczby");
            foreach (var c in this.numbers.NumberList)
                Console.Write(c + ";");
            Console.WriteLine("");
        }
        protected virtual void Separate(string operation)
        {
            int start = 0;
            try
            {
                for (int i = 0; i < operation.Length; i++)
                {
                    if (operation[i] == '+' || (operation[i] == '-' && i > 0) ||
                        operation[i] == '/' || operation[i] == '*')
                    {
                        this.numbers.AddNumber(operation.Substring(start, i - start));
                        start = i + 1;
                        if (operation[i] == '-') start = i;
                        this.symbols.AddSymbol(operation[i]);
                    }
                }
                this.numbers.AddNumber(operation.Substring(start));
                //this.ShowMeAllNumbers(); //Do sprawdzania poprawności separacji
                this.Count();
            }
            catch
            {
                throw;
            }
        }

        public void Count()
        {
            try
            {
                Operations operations = new Operations();
                while (this.symbols.FindSymbol(2, 3) > 0)
                {
                    int index = this.symbols.FindIndex(2, 3);
                    double wynik = 0;
                    wynik = operations.Count(this.numbers.GetOneNumber(index), this.numbers.GetOneNumber(index + 1), this.symbols.GetSymbol(index));
                    this.numbers.EditNumber(index,wynik);
                    this.symbols.Remove(index);
                    //Console.WriteLine("Znalazlem znak mnozenia badz dzielenia");
                }
                while (this.symbols.FindSymbol(1) > 0)
                {
                    //Console.WriteLine("Znalazlem znak sumy");
                    int index = this.symbols.FindIndex(1);
                    //Console.WriteLine("Opracja na liczbach: {0} i {1}", this.numbers.GetOneNumber(index), this.numbers.GetOneNumber(index));
                    this.numbers.EditNumber(index, operations.Count(this.numbers.GetOneNumber(index), this.numbers.GetOneNumber(index + 1), this.symbols.GetSymbol(index)));
                    this.symbols.Remove(index);
                }
                Console.WriteLine("\nWynik:" + this.numbers.GetOneNumber(0));
                this.numbers.ClearNumberList();
            }
            catch
            {
                Console.WriteLine("Spróbuj jeszcze raz!");
                throw;
            }
        }

        //Konstruktor
        public Calculator()
        {
            this.symbols = new Symbols();
            this.numbers = new Numbers();
            this.display = new CalculatorDisplay();
            this.Menu();
        }
    }
}
