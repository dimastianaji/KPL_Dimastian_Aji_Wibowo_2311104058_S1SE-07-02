using System;
using System.Windows.Forms;

namespace modul12_2311104058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int hasil = PangkatHelper.CariNilaiPangkat(a, b);
                lblHasil.Text = $"Hasil: {hasil}";
            }
            catch (FormatException)
            {
                lblHasil.Text = "Input tidak valid!";
            }
        }
    }
}
