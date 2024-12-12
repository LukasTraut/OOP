using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warenkorb
{
    public partial class Form2 : Form
    {

        public Form2(List<OrderItem> warenKorb)
        {
            InitializeComponent();

            double price = 0;
            foreach (OrderItem item in warenKorb)
            {
                textBox1.Text +=item.Quantity + " Ex. " + item.Product.Name + "\tà Fr. " +  item.Product.Price  + "\r\n";
                price += item.Product.Price * item.Quantity;
            }

            textBox2.Text = Convert.ToString(price);
        }
    }
}
