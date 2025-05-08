using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_2311104058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click; 
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka;
            if (int.TryParse(textBox1.Text, out angka))
            {
                string hasil = CariTandaBilangan(angka);
                label1.Text = hasil;
            }
            else
            {
                label1.Text = "Input tidak valid";
            }
        }
    }
}
