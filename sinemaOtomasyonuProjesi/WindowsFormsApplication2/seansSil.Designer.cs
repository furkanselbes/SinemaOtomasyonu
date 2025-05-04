namespace WindowsFormsApplication2
{
    partial class seansSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seansSil));
            this.dtSeansSil = new System.Windows.Forms.DataGridView();
            this.btnSeansSilCikis = new System.Windows.Forms.Button();
            this.btnSeansSilGeriDon = new System.Windows.Forms.Button();
            this.btnSeansSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSeansSil)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSeansSil
            // 
            this.dtSeansSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSeansSil.Location = new System.Drawing.Point(68, 22);
            this.dtSeansSil.Name = "dtSeansSil";
            this.dtSeansSil.RowHeadersWidth = 51;
            this.dtSeansSil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSeansSil.Size = new System.Drawing.Size(543, 218);
            this.dtSeansSil.TabIndex = 0;
            // 
            // btnSeansSilCikis
            // 
            this.btnSeansSilCikis.BackColor = System.Drawing.Color.White;
            this.btnSeansSilCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansSilCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansSilCikis.Location = new System.Drawing.Point(12, 293);
            this.btnSeansSilCikis.Name = "btnSeansSilCikis";
            this.btnSeansSilCikis.Size = new System.Drawing.Size(120, 40);
            this.btnSeansSilCikis.TabIndex = 3;
            this.btnSeansSilCikis.Text = "Çıkış Yap";
            this.btnSeansSilCikis.UseVisualStyleBackColor = false;
            this.btnSeansSilCikis.Click += new System.EventHandler(this.btnSeansSilCikis_Click);
            // 
            // btnSeansSilGeriDon
            // 
            this.btnSeansSilGeriDon.BackColor = System.Drawing.Color.White;
            this.btnSeansSilGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansSilGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansSilGeriDon.Location = new System.Drawing.Point(543, 293);
            this.btnSeansSilGeriDon.Name = "btnSeansSilGeriDon";
            this.btnSeansSilGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnSeansSilGeriDon.TabIndex = 2;
            this.btnSeansSilGeriDon.Text = "Geri Dön";
            this.btnSeansSilGeriDon.UseVisualStyleBackColor = false;
            this.btnSeansSilGeriDon.Click += new System.EventHandler(this.btnSeansSilGeriDon_Click);
            // 
            // btnSeansSil
            // 
            this.btnSeansSil.BackColor = System.Drawing.Color.White;
            this.btnSeansSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansSil.Location = new System.Drawing.Point(282, 293);
            this.btnSeansSil.Name = "btnSeansSil";
            this.btnSeansSil.Size = new System.Drawing.Size(120, 40);
            this.btnSeansSil.TabIndex = 1;
            this.btnSeansSil.Text = "Seans Sil";
            this.btnSeansSil.UseVisualStyleBackColor = false;
            this.btnSeansSil.Click += new System.EventHandler(this.btnSeansSil_Click);
            // 
            // seansSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(675, 345);
            this.ControlBox = false;
            this.Controls.Add(this.btnSeansSil);
            this.Controls.Add(this.btnSeansSilCikis);
            this.Controls.Add(this.btnSeansSilGeriDon);
            this.Controls.Add(this.dtSeansSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "seansSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Sil";
            this.Load += new System.EventHandler(this.seansSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSeansSil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtSeansSil;
        private System.Windows.Forms.Button btnSeansSilCikis;
        private System.Windows.Forms.Button btnSeansSilGeriDon;
        private System.Windows.Forms.Button btnSeansSil;
    }
}