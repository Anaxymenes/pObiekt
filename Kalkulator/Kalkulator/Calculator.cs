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
            while (true)
            {
                string operation = this.display.Operation();
                this.Separate(operation);
                this.display.Again();
            }
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
            }
            catch
            {

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
