namespace WindowsFormsApplication2
{
    partial class seansListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seansListeleme));
            this.dtSeansListele = new System.Windows.Forms.DataGridView();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTumSeanslar = new System.Windows.Forms.Button();
            this.btnSeansListeleCikis = new System.Windows.Forms.Button();
            this.btnSeansListeleGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSeansListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSeansListele
            // 
            this.dtSeansListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSeansListele.Location = new System.Drawing.Point(37, 66);
            this.dtSeansListele.Name = "dtSeansListele";
            this.dtSeansListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSeansListele.Size = new System.Drawing.Size(604, 266);
            this.dtSeansListele.TabIndex = 0;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(480, 30);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(161, 20);
            this.dtTarih.TabIndex = 1;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarihe Göre Listele :";
            // 
            // btnTumSeanslar
            // 
            this.btnTumSeanslar.BackColor = System.Drawing.Color.White;
            this.btnTumSeanslar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumSeanslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumSeanslar.Location = new System.Drawing.Point(502, 338);
            this.btnTumSeanslar.Name = "btnTumSeanslar";
            this.btnTumSeanslar.Size = new System.Drawing.Size(139, 40);
            this.btnTumSeanslar.TabIndex = 12;
            this.btnTumSeanslar.Text = "Tüm Seanslar";
            this.btnTumSeanslar.UseVisualStyleBackColor = false;
            this.btnTumSeanslar.Click += new System.EventHandler(this.btnTumSeanslar_Click);
            // 
            // btnSeansListeleCikis
            // 
            this.btnSeansListeleCikis.BackColor = System.Drawing.Color.White;
            this.btnSeansListeleCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansListeleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansListeleCikis.Location = new System.Drawing.Point(12, 414);
            this.btnSeansListeleCikis.Name = "btnSeansListeleCikis";
            this.btnSeansListeleCikis.Size = new System.Drawing.Size(120, 40);
            this.btnSeansListeleCikis.TabIndex = 14;
            this.btnSeansListeleCikis.Text = "Çıkış Yap";
            this.btnSeansListeleCikis.UseVisualStyleBackColor = false;
            this.btnSeansListeleCikis.Click += new System.EventHandler(this.btnSeansListeleCikis_Click);
            // 
            // btnSeansListeleGeriDon
            // 
            this.btnSeansListeleGeriDon.BackColor = System.Drawing.Color.White;
            this.btnSeansListeleGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansListeleGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansListeleGeriDon.Location = new System.Drawing.Point(555, 414);
            this.btnSeansListeleGeriDon.Name = "btnSeansListeleGeriDon";
            this.btnSeansListeleGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnSeansListeleGeriDon.TabIndex = 13;
            this.btnSeansListeleGeriDon.Text = "Geri Dön";
            this.btnSeansListeleGeriDon.UseVisualStyleBackColor = false;
            this.btnSeansListeleGeriDon.Click += new System.EventHandler(this.btnSeansListeleGeriDon_Click);
            // 
            // seansListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(687, 466);
            this.ControlBox = false;
            this.Controls.Add(this.btnSeansListeleCikis);
            this.Controls.Add(this.btnSeansListeleGeriDon);
            this.Controls.Add(this.btnTumSeanslar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.dtSeansListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "seansListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Listeleme";
            this.Load += new System.EventHandler(this.seansListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSeansListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtSeansListele;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTumSeanslar;
        private System.Windows.Forms.Button btnSeansListeleCikis;
        private System.Windows.Forms.Button btnSeansListeleGeriDon;
    }
}