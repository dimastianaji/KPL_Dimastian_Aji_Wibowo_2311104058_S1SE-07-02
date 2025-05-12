namespace modul12_2311104058
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblHasil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(30, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(30, 60);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(30, 90);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 23);
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(30, 130);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(39, 13);
            this.lblHasil.Text = "Hasil: -";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lblHasil);
            this.Name = "Form1";
            this.Text = "Modul 12 - Pangkat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
