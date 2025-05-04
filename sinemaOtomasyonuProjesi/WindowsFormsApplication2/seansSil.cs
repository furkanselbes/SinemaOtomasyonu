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
    public partial class seansSil : Form
    {
        public seansSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = bagkod.GetConnection();


        SqlCommand komut = new SqlCommand();
        DataTable tablo = new DataTable();


        private void SeansListesi(string sql) // sql sorgusuna göre tablo oluşturur
        {

            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
            adapter.Fill(tablo);
            dtSeansSil.DataSource = tablo;
            baglanti.Close();
        }

        private void btnSeansSil_Click(object sender, EventArgs e)
        {
           

            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dosya Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string sorgu = "DELETE from Seanslar where seansId=@seansId";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@seansId", dtSeansSil.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                SeansListesi("select * from Seanslar");
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi");
                baglanti.Close();
            }

        }

        private void btnSeansSilCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeansSilGeriDon_Click(object sender, EventArgs e)
        {
            silmeIslemleri silmeIslemleriForm = new silmeIslemleri();
            silmeIslemleriForm.Show();
            this.Hide();
        }

        private void seansSil_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select * from Seanslar");
            MakeReadOnly();
        }

        private void MakeReadOnly()
        {
            dtSeansSil.AllowUserToAddRows = false;
            dtSeansSil.AllowUserToDeleteRows = false;
            dtSeansSil.ReadOnly = true;
        }
    }
}
