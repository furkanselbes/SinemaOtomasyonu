namespace WindowsFormsApplication2
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeansListeleCikis = new System.Windows.Forms.Button();
            this.btnSeansListeleGeriDon = new System.Windows.Forms.Button();
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
            this.btnSeansEkle.Location = new System.Drawing.Point(147, 38);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(141, 117);
            this.btnSeansEkle.TabIndex = 7;
            this.btnSeansEkle.Text = "Seanslar";
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
            this.ımageList1.Images.SetKeyName(7, "money.jpg");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageIndex = 7;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(347, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 117);
            this.button1.TabIndex = 8;
            this.button1.Text = "Satışlar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeansListeleCikis
            // 
            this.btnSeansListeleCikis.BackColor = System.Drawing.Color.White;
            this.btnSeansListeleCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansListeleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansListeleCikis.Location = new System.Drawing.Point(12, 193);
            this.btnSeansListeleCikis.Name = "btnSeansListeleCikis";
            this.btnSeansListeleCikis.Size = new System.Drawing.Size(120, 40);
            this.btnSeansListeleCikis.TabIndex = 16;
            this.btnSeansListeleCikis.Text = "Çıkış Yap";
            this.btnSeansListeleCikis.UseVisualStyleBackColor = false;
            this.btnSeansListeleCikis.Click += new System.EventHandler(this.btnSeansListeleCikis_Click);
            // 
            // btnSeansListeleGeriDon
            // 
            this.btnSeansListeleGeriDon.BackColor = System.Drawing.Color.White;
            this.btnSeansListeleGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansListeleGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansListeleGeriDon.Location = new System.Drawing.Point(500, 193);
            this.btnSeansListeleGeriDon.Name = "btnSeansListeleGeriDon";
            this.btnSeansListeleGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnSeansListeleGeriDon.TabIndex = 15;
            this.btnSeansListeleGeriDon.Text = "Geri Dön";
            this.btnSeansListeleGeriDon.UseVisualStyleBackColor = false;
            this.btnSeansListeleGeriDon.Click += new System.EventHandler(this.btnSeansListeleGeriDon_Click);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(632, 245);
            this.ControlBox = false;
            this.Controls.Add(this.btnSeansListeleCikis);
            this.Controls.Add(this.btnSeansListeleGeriDon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSeansEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSeansListeleCikis;
        private System.Windows.Forms.Button btnSeansListeleGeriDon;
        private System.Windows.Forms.ImageList ımageList1;
    }
}