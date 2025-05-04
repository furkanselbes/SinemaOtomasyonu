namespace WindowsFormsApplication2
{
    partial class filmEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbFilm = new System.Windows.Forms.TextBox();
            this.tbFilmYonetmeni = new System.Windows.Forms.TextBox();
            this.cbFilmTuru = new System.Windows.Forms.ComboBox();
            this.btnAfisSec = new System.Windows.Forms.Button();
            this.cbSes = new System.Windows.Forms.ComboBox();
            this.btnFilmEkleGeriDon = new System.Windows.Forms.Button();
            this.btnFilmEkleCikis = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.pbAfis = new System.Windows.Forms.PictureBox();
            this.tbFilmtarih = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Yönetmeni :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(368, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Film Afişi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vizyon Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(109, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ses :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "okeyIcon.jpg");
            // 
            // tbFilm
            // 
            this.tbFilm.Location = new System.Drawing.Point(160, 36);
            this.tbFilm.Margin = new System.Windows.Forms.Padding(2);
            this.tbFilm.Name = "tbFilm";
            this.tbFilm.Size = new System.Drawing.Size(153, 20);
            this.tbFilm.TabIndex = 0;
            this.tbFilm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilm_KeyPress);
            // 
            // tbFilmYonetmeni
            // 
            this.tbFilmYonetmeni.Location = new System.Drawing.Point(160, 93);
            this.tbFilmYonetmeni.Margin = new System.Windows.Forms.Padding(2);
            this.tbFilmYonetmeni.Name = "tbFilmYonetmeni";
            this.tbFilmYonetmeni.Size = new System.Drawing.Size(153, 20);
            this.tbFilmYonetmeni.TabIndex = 2;
            this.tbFilmYonetmeni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilmYonetmeni_KeyPress);
            // 
            // cbFilmTuru
            // 
            this.cbFilmTuru.FormattingEnabled = true;
            this.cbFilmTuru.Location = new System.Drawing.Point(160, 63);
            this.cbFilmTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilmTuru.Name = "cbFilmTuru";
            this.cbFilmTuru.Size = new System.Drawing.Size(153, 21);
            this.cbFilmTuru.TabIndex = 1;
            // 
            // btnAfisSec
            // 
            this.btnAfisSec.BackColor = System.Drawing.Color.White;
            this.btnAfisSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfisSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAfisSec.Location = new System.Drawing.Point(401, 254);
            this.btnAfisSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfisSec.Name = "btnAfisSec";
            this.btnAfisSec.Size = new System.Drawing.Size(93, 26);
            this.btnAfisSec.TabIndex = 5;
            this.btnAfisSec.Text = "Afiş Seç";
            this.btnAfisSec.UseVisualStyleBackColor = false;
            this.btnAfisSec.Click += new System.EventHandler(this.btnAfisSec_Click);
            // 
            // cbSes
            // 
            this.cbSes.FormattingEnabled = true;
            this.cbSes.Items.AddRange(new object[] {
            "Türkçe Dublaj",
            "Orijinal Dil"});
            this.cbSes.Location = new System.Drawing.Point(160, 158);
            this.cbSes.Margin = new System.Windows.Forms.Padding(2);
            this.cbSes.Name = "cbSes";
            this.cbSes.Size = new System.Drawing.Size(153, 21);
            this.cbSes.TabIndex = 4;
            // 
            // btnFilmEkleGeriDon
            // 
            this.btnFilmEkleGeriDon.BackColor = System.Drawing.Color.White;
            this.btnFilmEkleGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmEkleGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkleGeriDon.Location = new System.Drawing.Point(468, 334);
            this.btnFilmEkleGeriDon.Name = "btnFilmEkleGeriDon";
            this.btnFilmEkleGeriDon.Size = new System.Drawing.Size(120, 34);
            this.btnFilmEkleGeriDon.TabIndex = 7;
            this.btnFilmEkleGeriDon.Text = "Geri Dön";
            this.btnFilmEkleGeriDon.UseVisualStyleBackColor = false;
            this.btnFilmEkleGeriDon.Click += new System.EventHandler(this.btnYoneticiAnaMenuGeriDon_Click);
            // 
            // btnFilmEkleCikis
            // 
            this.btnFilmEkleCikis.BackColor = System.Drawing.Color.White;
            this.btnFilmEkleCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmEkleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkleCikis.Location = new System.Drawing.Point(8, 334);
            this.btnFilmEkleCikis.Name = "btnFilmEkleCikis";
            this.btnFilmEkleCikis.Size = new System.Drawing.Size(120, 34);
            this.btnFilmEkleCikis.TabIndex = 8;
            this.btnFilmEkleCikis.Text = "Çıkış Yap";
            this.btnFilmEkleCikis.UseVisualStyleBackColor = false;
            this.btnFilmEkleCikis.Click += new System.EventHandler(this.btnYoneticiAnaMenuCikis_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.BackColor = System.Drawing.Color.White;
            this.btnFilmEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(248, 334);
            this.btnFilmEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(114, 34);
            this.btnFilmEkle.TabIndex = 6;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // pbAfis
            // 
            this.pbAfis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAfis.Location = new System.Drawing.Point(371, 36);
            this.pbAfis.Margin = new System.Windows.Forms.Padding(2);
            this.pbAfis.Name = "pbAfis";
            this.pbAfis.Size = new System.Drawing.Size(165, 204);
            this.pbAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfis.TabIndex = 10;
            this.pbAfis.TabStop = false;
            // 
            // tbFilmtarih
            // 
            this.tbFilmtarih.Location = new System.Drawing.Point(160, 127);
            this.tbFilmtarih.Name = "tbFilmtarih";
            this.tbFilmtarih.Size = new System.Drawing.Size(153, 20);
            this.tbFilmtarih.TabIndex = 3;
            this.tbFilmtarih.ValueChanged += new System.EventHandler(this.tbFilmtarih_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(600, 387);
            this.ControlBox = false;
            this.Controls.Add(this.tbFilmtarih);
            this.Controls.Add(this.btnFilmEkleCikis);
            this.Controls.Add(this.btnFilmEkleGeriDon);
            this.Controls.Add(this.cbSes);
            this.Controls.Add(this.btnAfisSec);
            this.Controls.Add(this.cbFilmTuru);
            this.Controls.Add(this.tbFilmYonetmeni);
            this.Controls.Add(this.tbFilm);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.pbAfis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "filmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.filmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbAfis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.TextBox tbFilm;
        private System.Windows.Forms.TextBox tbFilmYonetmeni;
        private System.Windows.Forms.ComboBox cbFilmTuru;
        private System.Windows.Forms.Button btnAfisSec;
        private System.Windows.Forms.ComboBox cbSes;
        private System.Windows.Forms.Button btnFilmEkleGeriDon;
        private System.Windows.Forms.Button btnFilmEkleCikis;
        private System.Windows.Forms.DateTimePicker tbFilmtarih;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}