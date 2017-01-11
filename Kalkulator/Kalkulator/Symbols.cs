using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class Symbols
    {
        protected List<int> symbolsList;
        public List<int> SymbolList { get { return this.symbolsList; } }
        public virtual void AddSymbol(char symbol)
        {
            this.symbolsList.Add(this.SymbolToInt(symbol));
        }
        protected virtual int SymbolToInt(char symbol)
        {
            switch (symbol)
            {
                case '+':
                    return 1;
                    break;
                case '-':
                    return 1;
                    break;
                case '*':
                    return 2;
                    break;
                case '/':
                    return 3;
                    break;
                default:
                    return -1;
                    break;
            }
        }
        public Symbols()
        {
            this.symbolsList = new List<int>();
        }
    }
}
