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
    public partial class hesapSil : Form
    {
        public hesapSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = bagkod.GetConnection();
        SqlCommand komut;


        public void HesapListele()
        {
            string getir = "select * from Kullanicilar";

            komut = new SqlCommand(getir, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dtHesapSil.DataSource = dt;
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
           


            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dosya Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string sorgu = "DELETE from Kullanicilar where hesapId=@hesapId";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@hesapId", dtHesapSil.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                HesapListele();
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi");
                baglanti.Close();
            }
        }


        private void hesapSil_Load(object sender, EventArgs e)
        {
            HesapListele();
            MakeReadOnly();
        }

        private void btnHesapSilGeriDon_Click(object sender, EventArgs e)
        {
            silmeIslemleri silmeIslemleriForm = new silmeIslemleri();
            silmeIslemleriForm.Show();
            this.Hide();
        }

        private void btnHesapSilCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MakeReadOnly()
        {
            dtHesapSil.AllowUserToAddRows = false;
            dtHesapSil.AllowUserToDeleteRows = false;
            dtHesapSil.ReadOnly = true;
        }
    }
}
