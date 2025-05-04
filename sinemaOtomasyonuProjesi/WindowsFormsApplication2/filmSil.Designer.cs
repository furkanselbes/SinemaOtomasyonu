namespace WindowsFormsApplication2
{
    partial class filmSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmSil));
            this.btnFilmSilCikis = new System.Windows.Forms.Button();
            this.btnFilmSilGeriDon = new System.Windows.Forms.Button();
            this.dataGridViewFilmSil = new System.Windows.Forms.DataGridView();
            this.btnFilmSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmSil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilmSilCikis
            // 
            this.btnFilmSilCikis.BackColor = System.Drawing.Color.White;
            this.btnFilmSilCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmSilCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmSilCikis.Location = new System.Drawing.Point(12, 249);
            this.btnFilmSilCikis.Name = "btnFilmSilCikis";
            this.btnFilmSilCikis.Size = new System.Drawing.Size(120, 40);
            this.btnFilmSilCikis.TabIndex = 3;
            this.btnFilmSilCikis.Text = "Çıkış Yap";
            this.btnFilmSilCikis.UseVisualStyleBackColor = false;
            this.btnFilmSilCikis.Click += new System.EventHandler(this.btnFilmSilCikis_Click);
            // 
            // btnFilmSilGeriDon
            // 
            this.btnFilmSilGeriDon.BackColor = System.Drawing.Color.White;
            this.btnFilmSilGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmSilGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmSilGeriDon.Location = new System.Drawing.Point(566, 249);
            this.btnFilmSilGeriDon.Name = "btnFilmSilGeriDon";
            this.btnFilmSilGeriDon.Size = new System.Drawing.Size(120, 40);
            this.btnFilmSilGeriDon.TabIndex = 2;
            this.btnFilmSilGeriDon.Text = "Geri Dön";
            this.btnFilmSilGeriDon.UseVisualStyleBackColor = false;
            this.btnFilmSilGeriDon.Click += new System.EventHandler(this.btnFilmSilGeriDon_Click);
            // 
            // dataGridViewFilmSil
            // 
            this.dataGridViewFilmSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmSil.Location = new System.Drawing.Point(28, 12);
            this.dataGridViewFilmSil.Name = "dataGridViewFilmSil";
            this.dataGridViewFilmSil.RowHeadersWidth = 51;
            this.dataGridViewFilmSil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilmSil.Size = new System.Drawing.Size(644, 167);
            this.dataGridViewFilmSil.TabIndex = 0;
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.BackColor = System.Drawing.Color.White;
            this.btnFilmSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmSil.Location = new System.Drawing.Point(287, 249);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(120, 40);
            this.btnFilmSil.TabIndex = 1;
            this.btnFilmSil.Text = "Film Sil";
            this.btnFilmSil.UseVisualStyleBackColor = false;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_click);
            // 
            // filmSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(698, 301);
            this.ControlBox = false;
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.dataGridViewFilmSil);
            this.Controls.Add(this.btnFilmSilCikis);
            this.Controls.Add(this.btnFilmSilGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "filmSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Sil";
            this.Load += new System.EventHandler(this.filmSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmSil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmSilCikis;
        private System.Windows.Forms.Button btnFilmSilGeriDon;
        private System.Windows.Forms.DataGridView dataGridViewFilmSil;
        private System.Windows.Forms.Button btnFilmSil;
    }
}