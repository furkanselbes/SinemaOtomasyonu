namespace WindowsFormsApplication2
{
    partial class eklemeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eklemeIslemleri));
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnHesapEkle = new System.Windows.Forms.Button();
            this.btnEklemeIslemleriCikis = new System.Windows.Forms.Button();
            this.btnEklemeIslemleriGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackColor = System.Drawing.Color.White;
            this.btnSeansEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSeansEkle.FlatAppearance.BorderSize = 2;
            this.btnSeansEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSeansEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSeansEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSeansEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansEkle.ImageIndex = 2;
            this.btnSeansEkle.ImageList = this.ımageList1;
            this.btnSeansEkle.Location = new System.Drawing.Point(278, 20);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(141, 117);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.Text = "Seans Ekle";
            this.btnSeansEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansEkle.UseVisualStyleBackColor = false;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.White;
            this.ımageList1.Images.SetKeyName(0, "salonIcon1.jpg");
            this.ımageList1.Images.SetKeyName(1, "filmIcon2.jpg");
            this.ımageList1.Images.SetKeyName(2, "seansIcon1.jpg");
            this.ımageList1.Images.SetKeyName(3, "hesapIcon1.png");
            this.ımageList1.Images.SetKeyName(4, "raporlarIcon1.png");
            this.ımageList1.Images.SetKeyName(5, "11.png");
            this.ımageList1.Images.SetKeyName(6, "ekleIcon.jpg");
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.White;
            this.btnSalonEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalonEkle.FlatAppearance.BorderSize = 2;
            this.btnSalonEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalonEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalonEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.ImageIndex = 0;
            this.btnSalonEkle.ImageList = this.ımageList1;
            this.btnSalonEkle.Location = new System.Drawing.Point(141, 20);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(131, 117);
            this.btnSalonEkle.TabIndex = 1;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.BackColor = System.Drawing.Color.White;
            this.btnFilmEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilmEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFilmEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFilmEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFilmEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.ImageIndex = 1;
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(12, 20);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(123, 117);
            this.btnFilmEkle.TabIndex = 0;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.BackColor = System.Drawing.Color.White;
            this.btnHesapEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHesapEkle.FlatAppearance.BorderSize = 2;
            this.btnHesapEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHesapEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHesapEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHesapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapEkle.ImageIndex = 3;
            this.btnHesapEkle.ImageList = this.ımageList1;
            this.btnHesapEkle.Location = new System.Drawing.Point(425, 20);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(141, 117);
            this.btnHesapEkle.TabIndex = 3;
            this.btnHesapEkle.Text = "Hesap Ekle";
            this.btnHesapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHesapEkle.UseVisualStyleBackColor = false;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // btnEklemeIslemleriCikis
            // 
            this.btnEklemeIslemleriCikis.BackColor = System.Drawing.Color.White;
            this.btnEklemeIslemleriCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEklemeIslemleriCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEklemeIslemleriCikis.Location = new System.Drawing.Point(12, 162);
            this.btnEklemeIslemleriCikis.Name = "btnEklemeIslemleriCikis";
            this.btnEklemeIslemleriCikis.Size = new System.Drawing.Size(120, 40);
            this.btnEklemeIslemleriCikis.TabIndex = 5;
            this.btnEklemeIslemleriCikis.Text = "Çıkış Yap";
            this.btnEklemeIslemleriCikis.UseVisualStyleBackColor = false;
            this.btnEklemeIslemleriCikis.Click += new System.EventHandler(this.btnEklemeIslemleriCikis_Click);
            // 
            // btnEklemeIslemleriGeriDon
            // 
            this.btnEklemeIslemleriGeriDon.BackColor = System.Drawing.Color.White;
            this.btnEklemeIslemleriGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEklemeIslemleriGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEklemeIslemleriGeriDon.Location = new System.Drawing.Point(452, 162);
            this.btnEklemeIslemleriGeriDon.Name = "btnEklemeIslemleriGeriDon";
            this.btnEklemeIslemleriGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnEklemeIslemleriGeriDon.TabIndex = 4;
            this.btnEklemeIslemleriGeriDon.Text = "Geri Dön";
            this.btnEklemeIslemleriGeriDon.UseVisualStyleBackColor = false;
            this.btnEklemeIslemleriGeriDon.Click += new System.EventHandler(this.btnEklemeIslemleriGeriDon_Click);
            // 
            // eklemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(584, 216);
            this.ControlBox = false;
            this.Controls.Add(this.btnEklemeIslemleriGeriDon);
            this.Controls.Add(this.btnEklemeIslemleriCikis);
            this.Controls.Add(this.btnHesapEkle);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "eklemeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekleme İşlemleri";
            this.Load += new System.EventHandler(this.eklemeIslemleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnHesapEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnEklemeIslemleriCikis;
        private System.Windows.Forms.Button btnEklemeIslemleriGeriDon;
    }
}