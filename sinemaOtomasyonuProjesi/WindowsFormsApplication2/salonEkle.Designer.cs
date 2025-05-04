namespace WindowsFormsApplication2
{
    partial class salonEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salonEkle));
            this.btnSalonEkleGeriDon = new System.Windows.Forms.Button();
            this.tbSalon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDikeyKoltuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalonEkleCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.tbYatayKoltuk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalonEkleGeriDon
            // 
            this.btnSalonEkleGeriDon.BackColor = System.Drawing.Color.White;
            this.btnSalonEkleGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonEkleGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkleGeriDon.Location = new System.Drawing.Point(232, 242);
            this.btnSalonEkleGeriDon.Name = "btnSalonEkleGeriDon";
            this.btnSalonEkleGeriDon.Size = new System.Drawing.Size(120, 35);
            this.btnSalonEkleGeriDon.TabIndex = 4;
            this.btnSalonEkleGeriDon.Text = "Geri Dön";
            this.btnSalonEkleGeriDon.UseVisualStyleBackColor = false;
            this.btnSalonEkleGeriDon.Click += new System.EventHandler(this.btnSalonEkleGeriDon_Click);
            // 
            // tbSalon
            // 
            this.tbSalon.Location = new System.Drawing.Point(193, 26);
            this.tbSalon.Margin = new System.Windows.Forms.Padding(2);
            this.tbSalon.Name = "tbSalon";
            this.tbSalon.Size = new System.Drawing.Size(105, 20);
            this.tbSalon.TabIndex = 0;
            this.tbSalon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Salon Adı :";
            // 
            // tbDikeyKoltuk
            // 
            this.tbDikeyKoltuk.Location = new System.Drawing.Point(193, 50);
            this.tbDikeyKoltuk.Margin = new System.Windows.Forms.Padding(2);
            this.tbDikeyKoltuk.Name = "tbDikeyKoltuk";
            this.tbDikeyKoltuk.Size = new System.Drawing.Size(105, 20);
            this.tbDikeyKoltuk.TabIndex = 1;
            this.tbDikeyKoltuk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDikeyKoltuk_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dikey Koltuk Sayısı :";
            // 
            // btnSalonEkleCikis
            // 
            this.btnSalonEkleCikis.BackColor = System.Drawing.Color.White;
            this.btnSalonEkleCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonEkleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkleCikis.Location = new System.Drawing.Point(12, 242);
            this.btnSalonEkleCikis.Name = "btnSalonEkleCikis";
            this.btnSalonEkleCikis.Size = new System.Drawing.Size(120, 35);
            this.btnSalonEkleCikis.TabIndex = 5;
            this.btnSalonEkleCikis.Text = "Çıkış Yap";
            this.btnSalonEkleCikis.UseVisualStyleBackColor = false;
            this.btnSalonEkleCikis.Click += new System.EventHandler(this.btnSalonEkleCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngfind.com-audience-png-1423340.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.pngfind_com_audience_png_1423340;
            this.pictureBox1.Location = new System.Drawing.Point(64, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.White;
            this.btnSalonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.Location = new System.Drawing.Point(193, 156);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(105, 28);
            this.btnSalonEkle.TabIndex = 3;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // tbYatayKoltuk
            // 
            this.tbYatayKoltuk.Location = new System.Drawing.Point(193, 74);
            this.tbYatayKoltuk.Margin = new System.Windows.Forms.Padding(2);
            this.tbYatayKoltuk.Name = "tbYatayKoltuk";
            this.tbYatayKoltuk.Size = new System.Drawing.Size(105, 20);
            this.tbYatayKoltuk.TabIndex = 2;
            this.tbYatayKoltuk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYatayKoltuk_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Yatay Koltuk Sayısı :";
            // 
            // salonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(364, 289);
            this.ControlBox = false;
            this.Controls.Add(this.tbYatayKoltuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalonEkleCikis);
            this.Controls.Add(this.tbDikeyKoltuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSalon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalonEkleGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "salonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Ekle";
            this.Load += new System.EventHandler(this.salonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalonEkleGeriDon;
        private System.Windows.Forms.TextBox tbSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDikeyKoltuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalonEkleCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.TextBox tbYatayKoltuk;
        private System.Windows.Forms.Label label3;
    }
}