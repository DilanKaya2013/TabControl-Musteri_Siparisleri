namespace TabControl_Musteri_Siparisleri
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMusteri = new System.Windows.Forms.TabPage();
            this.tbSiparis = new System.Windows.Forms.TabPage();
            this.tbHesap = new System.Windows.Forms.TabPage();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblCorba = new System.Windows.Forms.Label();
            this.lblSalata = new System.Windows.Forms.Label();
            this.lblAnaYemek = new System.Windows.Forms.Label();
            this.lblTatli = new System.Windows.Forms.Label();
            this.numCorba = new System.Windows.Forms.NumericUpDown();
            this.numSalata = new System.Windows.Forms.NumericUpDown();
            this.numAnaYemek = new System.Windows.Forms.NumericUpDown();
            this.numTatli = new System.Windows.Forms.NumericUpDown();
            this.lblHesap = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbMusteri.SuspendLayout();
            this.tbSiparis.SuspendLayout();
            this.tbHesap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnaYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTatli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMusteri);
            this.tabControl1.Controls.Add(this.tbSiparis);
            this.tabControl1.Controls.Add(this.tbHesap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbMusteri
            // 
            this.tbMusteri.BackColor = System.Drawing.Color.AliceBlue;
            this.tbMusteri.Controls.Add(this.txtAdres);
            this.tbMusteri.Controls.Add(this.txtTelefon);
            this.tbMusteri.Controls.Add(this.txtAdSoyad);
            this.tbMusteri.Controls.Add(this.lblAdres);
            this.tbMusteri.Controls.Add(this.lblTelefon);
            this.tbMusteri.Controls.Add(this.lblAdSoyad);
            this.tbMusteri.Location = new System.Drawing.Point(4, 22);
            this.tbMusteri.Name = "tbMusteri";
            this.tbMusteri.Padding = new System.Windows.Forms.Padding(3);
            this.tbMusteri.Size = new System.Drawing.Size(792, 424);
            this.tbMusteri.TabIndex = 0;
            this.tbMusteri.Text = "Müşteri";
            // 
            // tbSiparis
            // 
            this.tbSiparis.BackColor = System.Drawing.Color.Lavender;
            this.tbSiparis.Controls.Add(this.numTatli);
            this.tbSiparis.Controls.Add(this.numAnaYemek);
            this.tbSiparis.Controls.Add(this.numSalata);
            this.tbSiparis.Controls.Add(this.numCorba);
            this.tbSiparis.Controls.Add(this.lblTatli);
            this.tbSiparis.Controls.Add(this.lblAnaYemek);
            this.tbSiparis.Controls.Add(this.lblSalata);
            this.tbSiparis.Controls.Add(this.lblCorba);
            this.tbSiparis.Location = new System.Drawing.Point(4, 22);
            this.tbSiparis.Name = "tbSiparis";
            this.tbSiparis.Padding = new System.Windows.Forms.Padding(3);
            this.tbSiparis.Size = new System.Drawing.Size(792, 424);
            this.tbSiparis.TabIndex = 1;
            this.tbSiparis.Text = "Sipariş";
            // 
            // tbHesap
            // 
            this.tbHesap.BackColor = System.Drawing.Color.Azure;
            this.tbHesap.Controls.Add(this.lblHesap);
            this.tbHesap.Location = new System.Drawing.Point(4, 22);
            this.tbHesap.Name = "tbHesap";
            this.tbHesap.Size = new System.Drawing.Size(792, 424);
            this.tbHesap.TabIndex = 2;
            this.tbHesap.Text = "Hesap";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(17, 36);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(27, 71);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(36, 110);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(94, 33);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(131, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 71);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(131, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 110);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(131, 61);
            this.txtAdres.TabIndex = 5;
            // 
            // lblCorba
            // 
            this.lblCorba.AutoSize = true;
            this.lblCorba.Location = new System.Drawing.Point(35, 42);
            this.lblCorba.Name = "lblCorba";
            this.lblCorba.Size = new System.Drawing.Size(35, 13);
            this.lblCorba.TabIndex = 0;
            this.lblCorba.Text = "Çorba";
            // 
            // lblSalata
            // 
            this.lblSalata.AutoSize = true;
            this.lblSalata.Location = new System.Drawing.Point(33, 89);
            this.lblSalata.Name = "lblSalata";
            this.lblSalata.Size = new System.Drawing.Size(37, 13);
            this.lblSalata.TabIndex = 1;
            this.lblSalata.Text = "Salata";
            // 
            // lblAnaYemek
            // 
            this.lblAnaYemek.AutoSize = true;
            this.lblAnaYemek.Location = new System.Drawing.Point(8, 131);
            this.lblAnaYemek.Name = "lblAnaYemek";
            this.lblAnaYemek.Size = new System.Drawing.Size(62, 13);
            this.lblAnaYemek.TabIndex = 2;
            this.lblAnaYemek.Text = "Ana Yemek";
            // 
            // lblTatli
            // 
            this.lblTatli.AutoSize = true;
            this.lblTatli.Location = new System.Drawing.Point(43, 178);
            this.lblTatli.Name = "lblTatli";
            this.lblTatli.Size = new System.Drawing.Size(27, 13);
            this.lblTatli.TabIndex = 3;
            this.lblTatli.Text = "Tatlı";
            // 
            // numCorba
            // 
            this.numCorba.Location = new System.Drawing.Point(76, 35);
            this.numCorba.Name = "numCorba";
            this.numCorba.Size = new System.Drawing.Size(41, 20);
            this.numCorba.TabIndex = 4;
            // 
            // numSalata
            // 
            this.numSalata.Location = new System.Drawing.Point(76, 82);
            this.numSalata.Name = "numSalata";
            this.numSalata.Size = new System.Drawing.Size(41, 20);
            this.numSalata.TabIndex = 5;
            // 
            // numAnaYemek
            // 
            this.numAnaYemek.Location = new System.Drawing.Point(76, 129);
            this.numAnaYemek.Name = "numAnaYemek";
            this.numAnaYemek.Size = new System.Drawing.Size(41, 20);
            this.numAnaYemek.TabIndex = 6;
            // 
            // numTatli
            // 
            this.numTatli.Location = new System.Drawing.Point(76, 176);
            this.numTatli.Name = "numTatli";
            this.numTatli.Size = new System.Drawing.Size(41, 20);
            this.numTatli.TabIndex = 7;
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesap.Location = new System.Drawing.Point(22, 40);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(25, 24);
            this.lblHesap.TabIndex = 0;
            this.lblHesap.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbMusteri.ResumeLayout(false);
            this.tbMusteri.PerformLayout();
            this.tbSiparis.ResumeLayout(false);
            this.tbSiparis.PerformLayout();
            this.tbHesap.ResumeLayout(false);
            this.tbHesap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnaYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTatli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMusteri;
        private System.Windows.Forms.TabPage tbSiparis;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.NumericUpDown numTatli;
        private System.Windows.Forms.NumericUpDown numAnaYemek;
        private System.Windows.Forms.NumericUpDown numSalata;
        private System.Windows.Forms.NumericUpDown numCorba;
        private System.Windows.Forms.Label lblTatli;
        private System.Windows.Forms.Label lblAnaYemek;
        private System.Windows.Forms.Label lblSalata;
        private System.Windows.Forms.Label lblCorba;
        private System.Windows.Forms.TabPage tbHesap;
        private System.Windows.Forms.Label lblHesap;
    }
}

