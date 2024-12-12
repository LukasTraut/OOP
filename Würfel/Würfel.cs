using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Würfel : Form
    {
        public Würfel()
        {
            InitializeComponent();
        }
        Wuerfel r = new Wuerfel();

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = Convert.ToString(r.Werfen());
            label3.Text = Convert.ToString(r.LetzterWurf);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(r.Alle());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(r.Alle());

        }
    }


    }

