using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    class Archer:Hero
    {
        private int agility;
        public int Agility { get { return this.agility; } set { this.agility = value; } }

        public override void CalculateAtackPower()
        {
            base.CalculateAtackPower();
            atackPower *= this.agility;
        }
        public override string toString()
        {
            string txt = base.toString();

            return txt + ".\nZręczność: " + this.Agility + ".";
        }
        public Archer()
        {
            this.name = "GoblinA";
            this.Hp = 100;
            this.agility = 15;
            this.tacticsPoints = 3;
            CalculateAtackPower();
        }
        public Archer(string name, int agility, int tacticsPoints)
        {
            this.name = name;
            this.Hp = 100;
            this.agility = agility;
            this.tacticsPoints = tacticsPoints;
            CalculateAtackPower();
        }
    }
}
