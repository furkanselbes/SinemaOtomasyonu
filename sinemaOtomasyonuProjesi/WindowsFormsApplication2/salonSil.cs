using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using baglantiClass;

namespace WindowsFormsApplication2
{
    public partial class salonSil : Form
    {
        public salonSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = bagkod.GetConnection();
        SqlCommand komut;

        public void Salonlistele()
        {
            string getir = "select * from Salonlar";

            komut = new SqlCommand(getir, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridViewSalonSil.DataSource = dt;  
        }



        private void btnSalonSil_click(object sender, EventArgs e)
        {
            

            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dosya Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string sorgu = "DELETE from Salonlar where salonId=@salonId";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@salonId", dataGridViewSalonSil.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Salonlistele();
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi");
                baglanti.Close();
            }


        }

        private void btnSalonSilCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalonSilGeriDon_Click(object sender, EventArgs e)
        {
            silmeIslemleri silmeIslemleriForm = new silmeIslemleri();
            silmeIslemleriForm.Show();
            this.Hide();
        }

        private void salonSil_Load(object sender, EventArgs e)
        {
            Salonlistele();
            MakeReadOnly();

        }

        private void MakeReadOnly()
        {
            dataGridViewSalonSil.AllowUserToAddRows = false;
            dataGridViewSalonSil.AllowUserToDeleteRows = false;
            dataGridViewSalonSil.ReadOnly = true;
        }
    }
}
