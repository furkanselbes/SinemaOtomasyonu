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
    public partial class filmSil : Form
    {
        public filmSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = bagkod.GetConnection();
        SqlCommand komut = new SqlCommand();
        private void btnFilmSilCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFilmSilGeriDon_Click(object sender, EventArgs e)
        {
            silmeIslemleri silmeIslemleriForm = new silmeIslemleri();
            silmeIslemleriForm.Show();
            this.Hide();
        }

        public void listele()
        {
            baglanti.Open();

            string getir = "select filmId,filmAdi,filmTuru,yonetmen,afis,vizyonTarihi,filmSesi from Filmler";
            komut = new SqlCommand(getir, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridViewFilmSil.DataSource = dt;

            baglanti.Close();
        }

        private void filmSil_Load(object sender, EventArgs e)
        {
            listele();
            MakeReadOnly();
        }

        private void btnFilmSil_click(object sender, EventArgs e)
        {
           
            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dosya Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string sorgu = "DELETE FROM Filmler WHERE filmId=@filmId";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@filmId", dataGridViewFilmSil.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi");
                baglanti.Close();
            }
        }

        private void MakeReadOnly()
        {
            dataGridViewFilmSil.AllowUserToAddRows = false;
            dataGridViewFilmSil.AllowUserToDeleteRows = false;
            dataGridViewFilmSil.ReadOnly = true;
        }
    }
}
