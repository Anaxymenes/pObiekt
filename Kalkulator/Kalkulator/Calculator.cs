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
                this.display.Again();
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
