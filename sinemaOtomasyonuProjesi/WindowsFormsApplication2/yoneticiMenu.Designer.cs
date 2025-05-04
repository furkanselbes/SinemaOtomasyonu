namespace WindowsFormsApplication2
{
    partial class yoneticiMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticiMenu));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnYoneticiAnaMenuGeriDon = new System.Windows.Forms.Button();
            this.btnYoneticiAnaMenuCikis = new System.Windows.Forms.Button();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "salonIcon1.jpg");
            this.ımageList1.Images.SetKeyName(1, "filmIcon2.jpg");
            this.ımageList1.Images.SetKeyName(2, "seansIcon1.jpg");
            this.ımageList1.Images.SetKeyName(3, "hesapIcon1.png");
            this.ımageList1.Images.SetKeyName(4, "raporlarIcon1.png");
            this.ımageList1.Images.SetKeyName(5, "11.png");
            this.ımageList1.Images.SetKeyName(6, "ekleIcon.jpg");
            // 
            // btnYoneticiAnaMenuGeriDon
            // 
            this.btnYoneticiAnaMenuGeriDon.BackColor = System.Drawing.Color.White;
            this.btnYoneticiAnaMenuGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiAnaMenuGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiAnaMenuGeriDon.Location = new System.Drawing.Point(484, 174);
            this.btnYoneticiAnaMenuGeriDon.Name = "btnYoneticiAnaMenuGeriDon";
            this.btnYoneticiAnaMenuGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnYoneticiAnaMenuGeriDon.TabIndex = 3;
            this.btnYoneticiAnaMenuGeriDon.Text = "Geri Dön";
            this.btnYoneticiAnaMenuGeriDon.UseVisualStyleBackColor = false;
            this.btnYoneticiAnaMenuGeriDon.Click += new System.EventHandler(this.btnYoneticiAnaMenuGeriDon_Click);
            // 
            // btnYoneticiAnaMenuCikis
            // 
            this.btnYoneticiAnaMenuCikis.BackColor = System.Drawing.Color.White;
            this.btnYoneticiAnaMenuCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiAnaMenuCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiAnaMenuCikis.Location = new System.Drawing.Point(12, 174);
            this.btnYoneticiAnaMenuCikis.Name = "btnYoneticiAnaMenuCikis";
            this.btnYoneticiAnaMenuCikis.Size = new System.Drawing.Size(120, 40);
            this.btnYoneticiAnaMenuCikis.TabIndex = 4;
            this.btnYoneticiAnaMenuCikis.Text = "Çıkış Yap";
            this.btnYoneticiAnaMenuCikis.UseVisualStyleBackColor = false;
            this.btnYoneticiAnaMenuCikis.Click += new System.EventHandler(this.btnYoneticiAnaMenuCikis_Click);
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.BackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilmSil.FlatAppearance.BorderSize = 2;
            this.btnFilmSil.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmSil.ImageKey = "11.png";
            this.btnFilmSil.ImageList = this.ımageList1;
            this.btnFilmSil.Location = new System.Drawing.Point(214, 25);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(180, 106);
            this.btnFilmSil.TabIndex = 1;
            this.btnFilmSil.Text = "Silme İşlemleri";
            this.btnFilmSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmSil.UseVisualStyleBackColor = false;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.White;
            this.btnRapor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRapor.FlatAppearance.BorderSize = 2;
            this.btnRapor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRapor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRapor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ImageIndex = 4;
            this.btnRapor.ImageList = this.ımageList1;
            this.btnRapor.Location = new System.Drawing.Point(400, 25);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(180, 106);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
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
            this.btnFilmEkle.ImageIndex = 6;
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(31, 25);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(177, 106);
            this.btnFilmEkle.TabIndex = 0;
            this.btnFilmEkle.Text = "Ekleme İşlemleri";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // yoneticiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(616, 226);
            this.ControlBox = false;
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.btnYoneticiAnaMenuCikis);
            this.Controls.Add(this.btnYoneticiAnaMenuGeriDon);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnFilmEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yoneticiMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Ana Menü";
            this.Load += new System.EventHandler(this.yoneticiMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnYoneticiAnaMenuGeriDon;
        private System.Windows.Forms.Button btnYoneticiAnaMenuCikis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnFilmSil;
    }
}