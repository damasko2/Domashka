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
    public partial class Catalog : Form
    {
        List<Product> list = new List<Product>();

        public Catalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Product pr;
            
            if (f2.ShowDialog()==DialogResult.OK)
            {
                pr = f2.Prod();

                listBox1.Items.Add(pr.ToString());
                list.Add(pr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Product pr;

            int num = listBox1.SelectedIndex;
            try
            {
                listBox1.Items.RemoveAt(num);
                pr = list[num];

                list.RemoveAt(num);
                f2.Edit(pr);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбран аргумент!!!");
                return;
            }

            if (f2.ShowDialog()==DialogResult.OK)
            {
                pr = f2.Prod();

                listBox1.Items.Add(pr.ToString());
                list.Add(pr);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int num = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(num);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран элемент!!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
