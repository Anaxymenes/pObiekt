using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class Symbols:IRemoveIndex
    {
        protected List<int> symbolsList;
        public List<int> SymbolList { get { return this.symbolsList; } }
        public virtual void AddSymbol(char symbol)
        {
            this.symbolsList.Add(this.SymbolToInt(symbol));
        }
        public virtual int FindSymbol(int symbol)
        {
            return this.symbolsList.Find(r => r == symbol);
        }
        public virtual int FindSymbol(int symbol1, int symbol2)
        {
            return this.symbolsList.Find(r => r == symbol1 || r==symbol2);
        }
        public virtual int FindIndex(int symbol)
        {
            return this.symbolsList.FindIndex(r => r == symbol);
        }
        public virtual int FindIndex(int symbol1, int symbol2)
        {
            return this.symbolsList.FindIndex(r => r == symbol1 || r == symbol2);
        }
        public virtual int GetSymbol(int index)
        {
            int temp = this.symbolsList[index];
            return temp;
        }
        public virtual void ClearAllSymbols()
        {
            this.symbolsList.Clear();
        } 
        public virtual void Remove(int index)
        {
            //Console.WriteLine("Usuwam o indexie " + index);
            this.symbolsList.RemoveAt(index);
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
