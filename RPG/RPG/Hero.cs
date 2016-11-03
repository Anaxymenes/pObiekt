using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG
{
    class Hero
    {
        protected string name;
        protected int hp;
        protected int tacticsPoints;
        protected double atackPower;

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Hp { get { return this.hp; } set { this.hp = value; CalculateAtackPower(); } }
        public int TacticsPoints { get { return this.tacticsPoints; } set { this.tacticsPoints = value; } }
        public double AtackPower { get { return this.atackPower; } set{} }


        public virtual void CalculateAtackPower() {
            this.atackPower = this.TacticsPoints * (Hp/100.0);
        }

        public virtual string toString(){
            CalculateAtackPower();
            string txt = "Jestem " + Name 
                + ".\nŻywotność : "+Hp 
                + "%.\nPunkty taktyki: "+this.TacticsPoints
                + ".\nMoc ataku: "+AtackPower;
            return txt;
        }
    }
}
