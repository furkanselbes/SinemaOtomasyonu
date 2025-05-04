namespace WindowsFormsApplication2
{
    partial class hesapEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesapEkle));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHesapEkleGeriDon = new System.Windows.Forms.Button();
            this.btnHesapEkleCikis = new System.Windows.Forms.Button();
            this.btnPersonelHesapEkle = new System.Windows.Forms.Button();
            this.btnYoneticiHesapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yoneticiıcon1.png");
            this.ımageList1.Images.SetKeyName(1, "personelIcon1.png");
            this.ımageList1.Images.SetKeyName(2, "yoneticiIcon4.jpg");
            // 
            // btnHesapEkleGeriDon
            // 
            this.btnHesapEkleGeriDon.BackColor = System.Drawing.Color.White;
            this.btnHesapEkleGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapEkleGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapEkleGeriDon.Location = new System.Drawing.Point(352, 264);
            this.btnHesapEkleGeriDon.Name = "btnHesapEkleGeriDon";
            this.btnHesapEkleGeriDon.Size = new System.Drawing.Size(107, 28);
            this.btnHesapEkleGeriDon.TabIndex = 2;
            this.btnHesapEkleGeriDon.Text = "Geri Dön";
            this.btnHesapEkleGeriDon.UseVisualStyleBackColor = false;
            this.btnHesapEkleGeriDon.Click += new System.EventHandler(this.btnHesapEkleGeriDon_Click);
            // 
            // btnHesapEkleCikis
            // 
            this.btnHesapEkleCikis.BackColor = System.Drawing.Color.White;
            this.btnHesapEkleCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapEkleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapEkleCikis.Location = new System.Drawing.Point(10, 264);
            this.btnHesapEkleCikis.Name = "btnHesapEkleCikis";
            this.btnHesapEkleCikis.Size = new System.Drawing.Size(102, 28);
            this.btnHesapEkleCikis.TabIndex = 3;
            this.btnHesapEkleCikis.Text = "Çıkış Yap";
            this.btnHesapEkleCikis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHesapEkleCikis.UseVisualStyleBackColor = false;
            this.btnHesapEkleCikis.Click += new System.EventHandler(this.btnHesapEkleCikis_Click);
            // 
            // btnPersonelHesapEkle
            // 
            this.btnPersonelHesapEkle.BackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPersonelHesapEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPersonelHesapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelHesapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelHesapEkle.ImageIndex = 1;
            this.btnPersonelHesapEkle.ImageList = this.ımageList1;
            this.btnPersonelHesapEkle.Location = new System.Drawing.Point(270, 12);
            this.btnPersonelHesapEkle.Name = "btnPersonelHesapEkle";
            this.btnPersonelHesapEkle.Size = new System.Drawing.Size(189, 217);
            this.btnPersonelHesapEkle.TabIndex = 1;
            this.btnPersonelHesapEkle.Text = "Personel Hesabı Ekle";
            this.btnPersonelHesapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelHesapEkle.UseVisualStyleBackColor = false;
            this.btnPersonelHesapEkle.Click += new System.EventHandler(this.btnPersonelHesapEkle_Click);
            // 
            // btnYoneticiHesapEkle
            // 
            this.btnYoneticiHesapEkle.BackColor = System.Drawing.Color.White;
            this.btnYoneticiHesapEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnYoneticiHesapEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnYoneticiHesapEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnYoneticiHesapEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnYoneticiHesapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiHesapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiHesapEkle.ImageIndex = 2;
            this.btnYoneticiHesapEkle.ImageList = this.ımageList1;
            this.btnYoneticiHesapEkle.Location = new System.Drawing.Point(12, 12);
            this.btnYoneticiHesapEkle.Name = "btnYoneticiHesapEkle";
            this.btnYoneticiHesapEkle.Size = new System.Drawing.Size(187, 217);
            this.btnYoneticiHesapEkle.TabIndex = 0;
            this.btnYoneticiHesapEkle.Text = "Yönetici Hesabı Ekle";
            this.btnYoneticiHesapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYoneticiHesapEkle.UseVisualStyleBackColor = false;
            this.btnYoneticiHesapEkle.Click += new System.EventHandler(this.btnYoneticiHesapEkle_Click);
            // 
            // hesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(471, 304);
            this.ControlBox = false;
            this.Controls.Add(this.btnHesapEkleCikis);
            this.Controls.Add(this.btnHesapEkleGeriDon);
            this.Controls.Add(this.btnPersonelHesapEkle);
            this.Controls.Add(this.btnYoneticiHesapEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hesapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Ekle";
            this.Load += new System.EventHandler(this.hesapEkle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiHesapEkle;
        private System.Windows.Forms.Button btnPersonelHesapEkle;
        private System.Windows.Forms.Button btnHesapEkleGeriDon;
        private System.Windows.Forms.Button btnHesapEkleCikis;
        private System.Windows.Forms.ImageList ımageList1;
    }
}