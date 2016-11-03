using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG
{
    class Warrior:Hero
    {
        private int strength = 0;
        public int Strenght { get { return this.strength; } set { this.strength = value; } }

        public override void CalculateAtackPower()
        {
            if (Hp > 20)
            {
                base.CalculateAtackPower();
                atackPower *= Strenght;
            }
            else
                atackPower = Strenght * TacticsPoints * 1.5;
            
        }
        public Warrior()
        {
            this.Name = "OrkA";
            this.Hp = 100;
            this.Strenght = 15;
            this.TacticsPoints = 1;
        }
        public Warrior(string name, int strength, int tacticsPoints)
        {
            this.Name = name;
            this.Hp = 100;
            this.Strenght = strength;
            this.TacticsPoints = tacticsPoints;
            CalculateAtackPower();
        }
        public override string toString()
        {
            string txt = base.toString();

            return txt + ".\nSiła: " + this.Strenght+".";
        }
    }
}
