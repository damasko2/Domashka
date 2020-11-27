using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domashka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point point;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left==e.Button)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo();

            startInfo.WorkingDirectory = @"D:\Akademiy\Kubaikin\Domashka\Domashka\Calculator\Calculator\bin\Debug";
            startInfo.FileName = "Calculator.exe";
                                 // set additional properties 

          Process proc = Process.Start(startInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();

            if (catalog.ShowDialog()==DialogResult.OK)
            {
                catalog.Show();
            }
        }
    }
}
