using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Autos : Form
    {
        public Auto auto;
        public Autos()
        {

            InitializeComponent();
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));

        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = comboBoxAutos.SelectedItem as Auto;
            label2.Text = (auto.PS) + " PS";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            auto.GibGas();
            textBox1.Text = (auto.AktuelleGeschwindigkeit) + "";
            textBox2.Text = (auto.AktuellerGang) + "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            auto.Bremse();
            textBox1.Text = (auto.AktuelleGeschwindigkeit) + "";
            textBox2.Text = (auto.AktuellerGang) + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auto.StarteMotor();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            auto.SchalteMotorAus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto.Auftanken();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Hupe();
        }
    }
}