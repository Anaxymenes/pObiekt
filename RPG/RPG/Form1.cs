using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        Warrior aragorn;
        Archer legolas;
        public Form1()
        {
            InitializeComponent();
            aragorn = new Warrior("Aragorn",30,5);
            legolas = new Archer("Legolas", 40, 8);
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            aragornName.Text = aragorn.Name;
            aragornHpLabel.Text = "Zywotność:" + aragorn.Hp + "%";
            aragornAtackPowerLabel.Text = "Moc ataku:" + aragorn.AtackPower;

            legolasName.Text = legolas.Name;
            legolasHpLabel.Text = "Żywotność:" + legolas.Hp + "%";
            legolasAtackPowerLabel.Text = "Moc ataku:" + legolas.AtackPower;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aragorn.toString(), aragorn.Name+" mówi...");
        }

        private void aragornTrackBar_Scroll(object sender, EventArgs e)
        {
            aragorn.Hp = 100 - aragornTrackBar.Value;
            UpdateLabel();
        }

        private void legolasTrackBar_Scroll(object sender, EventArgs e)
        {
            legolas.Hp = 100 - legolasTrackBar.Value;
            UpdateLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(legolas.toString(), legolas.Name + " mówi...");
        }
    }
}
