using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Warenkorb
{
    public partial class Form1 : Form
    {
        // Liste deklarieren und intialisieren
        List<OrderItem> warenKorb = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();
            
            // Verbindung zur Datenbank herstellen
            string connectionString = "Server=mssql1.webland.ch;Database=d041e_blj;User Id=d041e_blj;Password=BljDbPw_01;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Abfrage vorbereiten
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from products";

            // Abfrage ausführen 
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product p = new Product();
                p.Name = reader["product_name"].ToString();
                p.Price = Convert.ToDouble(reader["price"]);
                p.Id = Convert.ToInt32(reader["id"]);

                // etc ...
                comboBox1.Items.Add(p);
                Product selectedProduct = (Product)comboBox1.SelectedItem;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2(warenKorb);
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zahl = 1;
            if (comboBox1.SelectedItem != null)
            {
                // neues OrderItem instanziieren und zur Liste (zum Warkenkorb) hinzufügen
                OrderItem item = new OrderItem();
                Product p = (Product)comboBox1.SelectedItem;

                item.Product = p;
                item.Quantity = Convert.ToInt32(numericUpDown1.Value);
                warenKorb.Add(item);
                
                    textBox1.Text= Convert.ToString(zahl);
                Convert.ToInt32(zahl);
                    zahl++;

            }
        }
        
    }
}
