namespace WindowsFormsApplication2
{
    partial class personelHesabiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelHesabiEkle));
            this.tbPrsnlSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrsnlSifre = new System.Windows.Forms.TextBox();
            this.tbPrsnlKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnPersonelHesapEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelHesapEkleGeriDon = new System.Windows.Forms.Button();
            this.btnPersonelHesapEkleCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrsnlSifreTekrar
            // 
            this.tbPrsnlSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPrsnlSifreTekrar.Location = new System.Drawing.Point(136, 99);
            this.tbPrsnlSifreTekrar.Name = "tbPrsnlSifreTekrar";
            this.tbPrsnlSifreTekrar.PasswordChar = '*';
            this.tbPrsnlSifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.tbPrsnlSifreTekrar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Şifre Doğrula :";
            // 
            // tbPrsnlSifre
            // 
            this.tbPrsnlSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPrsnlSifre.Location = new System.Drawing.Point(136, 69);
            this.tbPrsnlSifre.Name = "tbPrsnlSifre";
            this.tbPrsnlSifre.PasswordChar = '*';
            this.tbPrsnlSifre.Size = new System.Drawing.Size(100, 20);
            this.tbPrsnlSifre.TabIndex = 1;
            // 
            // tbPrsnlKullaniciAdi
            // 
            this.tbPrsnlKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPrsnlKullaniciAdi.Location = new System.Drawing.Point(136, 40);
            this.tbPrsnlKullaniciAdi.Name = "tbPrsnlKullaniciAdi";
            this.tbPrsnlKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.tbPrsnlKullaniciAdi.TabIndex = 0;
            this.tbPrsnlKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrsnlKullaniciAdi_KeyPress);
            // 
            // btnPersonelHesapEkle
            // 
            this.btnPersonelHesapEkle.BackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelHesapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelHesapEkle.Location = new System.Drawing.Point(20, 129);
            this.btnPersonelHesapEkle.Name = "btnPersonelHesapEkle";
            this.btnPersonelHesapEkle.Size = new System.Drawing.Size(216, 34);
            this.btnPersonelHesapEkle.TabIndex = 3;
            this.btnPersonelHesapEkle.Text = "Personel Hesabı Oluştur";
            this.btnPersonelHesapEkle.UseVisualStyleBackColor = false;
            this.btnPersonelHesapEkle.Click += new System.EventHandler(this.btnPersonelHesapEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btnPersonelHesapEkleGeriDon
            // 
            this.btnPersonelHesapEkleGeriDon.BackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkleGeriDon.FlatAppearance.BorderSize = 2;
            this.btnPersonelHesapEkleGeriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkleGeriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkleGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelHesapEkleGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelHesapEkleGeriDon.Location = new System.Drawing.Point(179, 218);
            this.btnPersonelHesapEkleGeriDon.Name = "btnPersonelHesapEkleGeriDon";
            this.btnPersonelHesapEkleGeriDon.Size = new System.Drawing.Size(106, 31);
            this.btnPersonelHesapEkleGeriDon.TabIndex = 4;
            this.btnPersonelHesapEkleGeriDon.Text = "Geri Dön";
            this.btnPersonelHesapEkleGeriDon.UseVisualStyleBackColor = false;
            this.btnPersonelHesapEkleGeriDon.Click += new System.EventHandler(this.btnPersonelHesapEkleGeriDon_Click);
            // 
            // btnPersonelHesapEkleCikis
            // 
            this.btnPersonelHesapEkleCikis.BackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkleCikis.FlatAppearance.BorderSize = 2;
            this.btnPersonelHesapEkleCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkleCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkleCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelHesapEkleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelHesapEkleCikis.Location = new System.Drawing.Point(12, 218);
            this.btnPersonelHesapEkleCikis.Name = "btnPersonelHesapEkleCikis";
            this.btnPersonelHesapEkleCikis.Size = new System.Drawing.Size(106, 31);
            this.btnPersonelHesapEkleCikis.TabIndex = 5;
            this.btnPersonelHesapEkleCikis.Text = "Çıkış Yap";
            this.btnPersonelHesapEkleCikis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonelHesapEkleCikis.UseVisualStyleBackColor = false;
            this.btnPersonelHesapEkleCikis.Click += new System.EventHandler(this.btnPersonelHesapEkleCikis_Click);
            // 
            // personelHesabiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(297, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnPersonelHesapEkleCikis);
            this.Controls.Add(this.btnPersonelHesapEkleGeriDon);
            this.Controls.Add(this.tbPrsnlSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrsnlSifre);
            this.Controls.Add(this.tbPrsnlKullaniciAdi);
            this.Controls.Add(this.btnPersonelHesapEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "personelHesabiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Hesabı Ekle";
            this.Load += new System.EventHandler(this.personelHesabiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrsnlSifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrsnlSifre;
        private System.Windows.Forms.TextBox tbPrsnlKullaniciAdi;
        private System.Windows.Forms.Button btnPersonelHesapEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelHesapEkleGeriDon;
        private System.Windows.Forms.Button btnPersonelHesapEkleCikis;
    }
}