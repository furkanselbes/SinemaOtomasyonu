namespace WindowsFormsApplication2
{
    partial class salonSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salonSil));
            this.btnSalonSil = new System.Windows.Forms.Button();
            this.btnSalonSilCikis = new System.Windows.Forms.Button();
            this.btnSalonSilGeriDon = new System.Windows.Forms.Button();
            this.dataGridViewSalonSil = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalonSil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalonSil
            // 
            this.btnSalonSil.BackColor = System.Drawing.Color.White;
            this.btnSalonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonSil.Location = new System.Drawing.Point(270, 242);
            this.btnSalonSil.Name = "btnSalonSil";
            this.btnSalonSil.Size = new System.Drawing.Size(120, 40);
            this.btnSalonSil.TabIndex = 1;
            this.btnSalonSil.Text = "Salon Sil";
            this.btnSalonSil.UseVisualStyleBackColor = false;
            this.btnSalonSil.Click += new System.EventHandler(this.btnSalonSil_click);
            // 
            // btnSalonSilCikis
            // 
            this.btnSalonSilCikis.BackColor = System.Drawing.Color.White;
            this.btnSalonSilCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonSilCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonSilCikis.Location = new System.Drawing.Point(12, 242);
            this.btnSalonSilCikis.Name = "btnSalonSilCikis";
            this.btnSalonSilCikis.Size = new System.Drawing.Size(120, 40);
            this.btnSalonSilCikis.TabIndex = 3;
            this.btnSalonSilCikis.Text = "Çıkış Yap";
            this.btnSalonSilCikis.UseVisualStyleBackColor = false;
            this.btnSalonSilCikis.Click += new System.EventHandler(this.btnSalonSilCikis_Click);
            // 
            // btnSalonSilGeriDon
            // 
            this.btnSalonSilGeriDon.BackColor = System.Drawing.Color.White;
            this.btnSalonSilGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonSilGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonSilGeriDon.Location = new System.Drawing.Point(527, 242);
            this.btnSalonSilGeriDon.Name = "btnSalonSilGeriDon";
            this.btnSalonSilGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnSalonSilGeriDon.TabIndex = 2;
            this.btnSalonSilGeriDon.Text = "Geri Dön";
            this.btnSalonSilGeriDon.UseVisualStyleBackColor = false;
            this.btnSalonSilGeriDon.Click += new System.EventHandler(this.btnSalonSilGeriDon_Click);
            // 
            // dataGridViewSalonSil
            // 
            this.dataGridViewSalonSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalonSil.Location = new System.Drawing.Point(147, 30);
            this.dataGridViewSalonSil.Name = "dataGridViewSalonSil";
            this.dataGridViewSalonSil.RowHeadersWidth = 51;
            this.dataGridViewSalonSil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalonSil.Size = new System.Drawing.Size(346, 167);
            this.dataGridViewSalonSil.TabIndex = 0;
            // 
            // salonSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(659, 294);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewSalonSil);
            this.Controls.Add(this.btnSalonSil);
            this.Controls.Add(this.btnSalonSilCikis);
            this.Controls.Add(this.btnSalonSilGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "salonSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Sil";
            this.Load += new System.EventHandler(this.salonSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalonSil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalonSil;
        private System.Windows.Forms.Button btnSalonSilCikis;
        private System.Windows.Forms.Button btnSalonSilGeriDon;
        private System.Windows.Forms.DataGridView dataGridViewSalonSil;
    }
}