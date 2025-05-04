namespace WindowsFormsApplication2
{
    partial class satisListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisListeleme));
            this.btnSatisListeleCikis = new System.Windows.Forms.Button();
            this.btnSatisListeleGeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOgrenciTplmBltFiyat = new System.Windows.Forms.Label();
            this.lblTamTplmBltFiyat = new System.Windows.Forms.Label();
            this.lblTplmCiro = new System.Windows.Forms.Label();
            this.lblTplmMısır = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnTumFiyatlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSatisListeleCikis
            // 
            this.btnSatisListeleCikis.BackColor = System.Drawing.Color.White;
            this.btnSatisListeleCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisListeleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisListeleCikis.Location = new System.Drawing.Point(12, 222);
            this.btnSatisListeleCikis.Name = "btnSatisListeleCikis";
            this.btnSatisListeleCikis.Size = new System.Drawing.Size(120, 40);
            this.btnSatisListeleCikis.TabIndex = 20;
            this.btnSatisListeleCikis.Text = "Çıkış Yap";
            this.btnSatisListeleCikis.UseVisualStyleBackColor = false;
            this.btnSatisListeleCikis.Click += new System.EventHandler(this.btnSatisListeleCikis_Click);
            // 
            // btnSatisListeleGeriDon
            // 
            this.btnSatisListeleGeriDon.BackColor = System.Drawing.Color.White;
            this.btnSatisListeleGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisListeleGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisListeleGeriDon.Location = new System.Drawing.Point(521, 222);
            this.btnSatisListeleGeriDon.Name = "btnSatisListeleGeriDon";
            this.btnSatisListeleGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnSatisListeleGeriDon.TabIndex = 19;
            this.btnSatisListeleGeriDon.Text = "Geri Dön";
            this.btnSatisListeleGeriDon.UseVisualStyleBackColor = false;
            this.btnSatisListeleGeriDon.Click += new System.EventHandler(this.btnSatisListeleGeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Öğrenci Toplam Bilet Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tam Toplam Bilet Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(164, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "ToplamCiro :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Patlamış Mısır Toplam Fiyatı :";
            // 
            // lblOgrenciTplmBltFiyat
            // 
            this.lblOgrenciTplmBltFiyat.AutoSize = true;
            this.lblOgrenciTplmBltFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciTplmBltFiyat.Location = new System.Drawing.Point(271, 67);
            this.lblOgrenciTplmBltFiyat.Name = "lblOgrenciTplmBltFiyat";
            this.lblOgrenciTplmBltFiyat.Size = new System.Drawing.Size(38, 16);
            this.lblOgrenciTplmBltFiyat.TabIndex = 22;
            this.lblOgrenciTplmBltFiyat.Text = "0 TL";
            // 
            // lblTamTplmBltFiyat
            // 
            this.lblTamTplmBltFiyat.AutoSize = true;
            this.lblTamTplmBltFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTamTplmBltFiyat.Location = new System.Drawing.Point(271, 95);
            this.lblTamTplmBltFiyat.Name = "lblTamTplmBltFiyat";
            this.lblTamTplmBltFiyat.Size = new System.Drawing.Size(38, 16);
            this.lblTamTplmBltFiyat.TabIndex = 22;
            this.lblTamTplmBltFiyat.Text = "0 TL";
            // 
            // lblTplmCiro
            // 
            this.lblTplmCiro.AutoSize = true;
            this.lblTplmCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTplmCiro.Location = new System.Drawing.Point(271, 145);
            this.lblTplmCiro.Name = "lblTplmCiro";
            this.lblTplmCiro.Size = new System.Drawing.Size(38, 16);
            this.lblTplmCiro.TabIndex = 22;
            this.lblTplmCiro.Text = "0 TL";
            this.lblTplmCiro.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTplmMısır
            // 
            this.lblTplmMısır.AutoSize = true;
            this.lblTplmMısır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTplmMısır.Location = new System.Drawing.Point(271, 120);
            this.lblTplmMısır.Name = "lblTplmMısır";
            this.lblTplmMısır.Size = new System.Drawing.Size(38, 16);
            this.lblTplmMısır.TabIndex = 24;
            this.lblTplmMısır.Text = "0 TL";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(327, 12);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 20);
            this.dtTarih.TabIndex = 25;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // btnTumFiyatlar
            // 
            this.btnTumFiyatlar.BackColor = System.Drawing.Color.White;
            this.btnTumFiyatlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumFiyatlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumFiyatlar.Location = new System.Drawing.Point(274, 222);
            this.btnTumFiyatlar.Name = "btnTumFiyatlar";
            this.btnTumFiyatlar.Size = new System.Drawing.Size(142, 40);
            this.btnTumFiyatlar.TabIndex = 26;
            this.btnTumFiyatlar.Text = "Tüm Satışlar";
            this.btnTumFiyatlar.UseVisualStyleBackColor = false;
            this.btnTumFiyatlar.Click += new System.EventHandler(this.btnTumFiyatlar_Click);
            // 
            // satisListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(653, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnTumFiyatlar);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.lblTplmMısır);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTplmCiro);
            this.Controls.Add(this.lblTamTplmBltFiyat);
            this.Controls.Add(this.lblOgrenciTplmBltFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSatisListeleCikis);
            this.Controls.Add(this.btnSatisListeleGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "satisListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listeleme";
            this.Load += new System.EventHandler(this.satisListeleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSatisListeleCikis;
        private System.Windows.Forms.Button btnSatisListeleGeriDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOgrenciTplmBltFiyat;
        private System.Windows.Forms.Label lblTamTplmBltFiyat;
        private System.Windows.Forms.Label lblTplmCiro;
        private System.Windows.Forms.Label lblTplmMısır;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button btnTumFiyatlar;
    }
}