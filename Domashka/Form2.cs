using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domashka
{
    public partial class Form2 : Form
    {
        public Product Prod()
        {
            string Name ="";
            string ManufacturerCountry="";
            double TheCost=0;

            try
            {
                Name = textBox1.Text;
                ManufacturerCountry = textBox2.Text;
                TheCost = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new Product(Name, ManufacturerCountry, TheCost);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Не все поля заполненые");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && num != 44)
            {
                e.Handled = true;
            }
        }

        public void Edit(Product pr)
        {
            textBox1.Text = pr.Name;
            textBox2.Text = pr.ManufacturerCountry;
            textBox3.Text = Convert.ToString(pr.TheCost);   
        }
    }
}
