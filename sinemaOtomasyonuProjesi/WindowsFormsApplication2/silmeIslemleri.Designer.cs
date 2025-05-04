namespace WindowsFormsApplication2
{
    partial class silmeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(silmeIslemleri));
            this.btnSalonSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSilmeİslemleriCikis = new System.Windows.Forms.Button();
            this.btnSilmeİslemleriGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalonSil
            // 
            this.btnSalonSil.BackColor = System.Drawing.Color.White;
            this.btnSalonSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalonSil.FlatAppearance.BorderSize = 2;
            this.btnSalonSil.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalonSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalonSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonSil.ImageIndex = 0;
            this.btnSalonSil.ImageList = this.ımageList1;
            this.btnSalonSil.Location = new System.Drawing.Point(147, 11);
            this.btnSalonSil.Name = "btnSalonSil";
            this.btnSalonSil.Size = new System.Drawing.Size(131, 120);
            this.btnSalonSil.TabIndex = 1;
            this.btnSalonSil.Text = "Salon Sil";
            this.btnSalonSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonSil.UseVisualStyleBackColor = false;
            this.btnSalonSil.Click += new System.EventHandler(this.btnSalonSil_Click);
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
            // btnFilmSil
            // 
            this.btnFilmSil.BackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilmSil.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmSil.ImageIndex = 1;
            this.btnFilmSil.ImageList = this.ımageList1;
            this.btnFilmSil.Location = new System.Drawing.Point(10, 11);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(131, 120);
            this.btnFilmSil.TabIndex = 0;
            this.btnFilmSil.Text = "Film Sil";
            this.btnFilmSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmSil.UseVisualStyleBackColor = false;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(284, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 120);
            this.button2.TabIndex = 2;
            this.button2.Text = "Seans Sil";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageIndex = 3;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(422, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 120);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hesap Sil";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSilmeİslemleriCikis
            // 
            this.btnSilmeİslemleriCikis.BackColor = System.Drawing.Color.White;
            this.btnSilmeİslemleriCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilmeİslemleriCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilmeİslemleriCikis.Location = new System.Drawing.Point(12, 168);
            this.btnSilmeİslemleriCikis.Name = "btnSilmeİslemleriCikis";
            this.btnSilmeİslemleriCikis.Size = new System.Drawing.Size(120, 40);
            this.btnSilmeİslemleriCikis.TabIndex = 5;
            this.btnSilmeİslemleriCikis.Text = "Çıkış Yap";
            this.btnSilmeİslemleriCikis.UseVisualStyleBackColor = false;
            this.btnSilmeİslemleriCikis.Click += new System.EventHandler(this.btnSilmeİslemleriCikis_Click);
            // 
            // btnSilmeİslemleriGeriDon
            // 
            this.btnSilmeİslemleriGeriDon.BackColor = System.Drawing.Color.White;
            this.btnSilmeİslemleriGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilmeİslemleriGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilmeİslemleriGeriDon.Location = new System.Drawing.Point(439, 168);
            this.btnSilmeİslemleriGeriDon.Name = "btnSilmeİslemleriGeriDon";
            this.btnSilmeİslemleriGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnSilmeİslemleriGeriDon.TabIndex = 4;
            this.btnSilmeİslemleriGeriDon.Text = "Geri Dön";
            this.btnSilmeİslemleriGeriDon.UseVisualStyleBackColor = false;
            this.btnSilmeİslemleriGeriDon.Click += new System.EventHandler(this.btnSilmeİslemleriGeriDon_Click);
            // 
            // silmeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(571, 220);
            this.ControlBox = false;
            this.Controls.Add(this.btnSilmeİslemleriCikis);
            this.Controls.Add(this.btnSilmeİslemleriGeriDon);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.btnSalonSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "silmeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silme İşlemleri";
            this.Load += new System.EventHandler(this.silmeIslemleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalonSil;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSilmeİslemleriCikis;
        private System.Windows.Forms.Button btnSilmeİslemleriGeriDon;
        private System.Windows.Forms.ImageList ımageList1;
    }
}