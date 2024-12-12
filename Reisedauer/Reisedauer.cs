using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisedauer
{
    public partial class Reisedauer : Form
    {
        public Reisedauer()
        {
            InitializeComponent();
        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            Mondreise mondreise = new Mondreise(Convert.ToDouble(textBox1.Text));

            if (radioButtonDays.Checked == true)
            {
                double resualt = mondreise.GetTravelDurationDays(mondreise.SpeedKmh, mondreise.Weg, mondreise.Zeit);
                textBox2.Text = resualt.ToString();

            }


            if (radioButtonHours.Checked == true)
            {
                    double resualt = mondreise.GetTravelDurationHours(mondreise.SpeedKmh, mondreise.Weg, mondreise.Zeit);
                    textBox2.Text = resualt.ToString();
                
            }
        }

        
    }
}
