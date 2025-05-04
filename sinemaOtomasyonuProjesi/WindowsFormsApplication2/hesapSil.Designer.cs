namespace WindowsFormsApplication2
{
    partial class hesapSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesapSil));
            this.btnHesapSil = new System.Windows.Forms.Button();
            this.btnHesapSilCikis = new System.Windows.Forms.Button();
            this.btnHesapSilGeriDon = new System.Windows.Forms.Button();
            this.dtHesapSil = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtHesapSil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.BackColor = System.Drawing.Color.White;
            this.btnHesapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapSil.Location = new System.Drawing.Point(280, 202);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(120, 40);
            this.btnHesapSil.TabIndex = 1;
            this.btnHesapSil.Text = "Hesap Sil";
            this.btnHesapSil.UseVisualStyleBackColor = false;
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // btnHesapSilCikis
            // 
            this.btnHesapSilCikis.BackColor = System.Drawing.Color.White;
            this.btnHesapSilCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapSilCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapSilCikis.Location = new System.Drawing.Point(12, 202);
            this.btnHesapSilCikis.Name = "btnHesapSilCikis";
            this.btnHesapSilCikis.Size = new System.Drawing.Size(120, 40);
            this.btnHesapSilCikis.TabIndex = 3;
            this.btnHesapSilCikis.Text = "Çıkış Yap";
            this.btnHesapSilCikis.UseVisualStyleBackColor = false;
            this.btnHesapSilCikis.Click += new System.EventHandler(this.btnHesapSilCikis_Click);
            // 
            // btnHesapSilGeriDon
            // 
            this.btnHesapSilGeriDon.BackColor = System.Drawing.Color.White;
            this.btnHesapSilGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapSilGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapSilGeriDon.Location = new System.Drawing.Point(542, 202);
            this.btnHesapSilGeriDon.Name = "btnHesapSilGeriDon";
            this.btnHesapSilGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnHesapSilGeriDon.TabIndex = 2;
            this.btnHesapSilGeriDon.Text = "Geri Dön";
            this.btnHesapSilGeriDon.UseVisualStyleBackColor = false;
            this.btnHesapSilGeriDon.Click += new System.EventHandler(this.btnHesapSilGeriDon_Click);
            // 
            // dtHesapSil
            // 
            this.dtHesapSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHesapSil.Location = new System.Drawing.Point(120, 29);
            this.dtHesapSil.Name = "dtHesapSil";
            this.dtHesapSil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHesapSil.Size = new System.Drawing.Size(433, 150);
            this.dtHesapSil.TabIndex = 0;
            // 
            // hesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(674, 254);
            this.ControlBox = false;
            this.Controls.Add(this.btnHesapSil);
            this.Controls.Add(this.btnHesapSilCikis);
            this.Controls.Add(this.btnHesapSilGeriDon);
            this.Controls.Add(this.dtHesapSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hesapSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Sil";
            this.Load += new System.EventHandler(this.hesapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHesapSil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesapSil;
        private System.Windows.Forms.Button btnHesapSilCikis;
        private System.Windows.Forms.Button btnHesapSilGeriDon;
        private System.Windows.Forms.DataGridView dtHesapSil;
    }
}