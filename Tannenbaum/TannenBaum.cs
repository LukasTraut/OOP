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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tannenbaum
{
    public partial class TannenBaum : Form
    {
        Tanne t = new Tanne();

        public TannenBaum()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            t.Zeichnen();
            textBox4.Text = t.Zeichnung;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t.Sb = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            t.Sh = int.Parse(textBox2.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            t.Kh = int.Parse(textBox3.Text);
        }
    }
}
