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
    public partial class seansListeleme : Form
    {
        public seansListeleme()
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
            dtSeansListele.DataSource = tablo;
            baglanti.Close();
        }

        private void seansListeleme_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select filmAdi, salonAdi, tarih, seans from Seanslar inner join Salonlar on(Seanslar.salonId=Salonlar.salonId) inner join Filmler on(Seanslar.filmId = Filmler.filmId) where tarih like '" + dtTarih.Text + "'");
            MakeReadOnly();
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select filmAdi, salonAdi, tarih, seans from Seanslar inner join Salonlar on(Seanslar.salonId=Salonlar.salonId) inner join Filmler on(Seanslar.filmId = Filmler.filmId) where tarih like '" + dtTarih.Text + "'");
        }

        private void btnTumSeanslar_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select filmAdi, salonAdi, tarih, seans from Seanslar inner join Salonlar on(Seanslar.salonId=Salonlar.salonId) inner join Filmler on(Seanslar.filmId = Filmler.filmId)");
        }

        private void btnSeansListeleGeriDon_Click(object sender, EventArgs e)
        {
            Raporlar raporlarForm = new Raporlar();
            raporlarForm.Show();
            this.Hide();
        }

        private void btnSeansListeleCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MakeReadOnly()
        {
            dtSeansListele.AllowUserToAddRows = false;
            dtSeansListele.AllowUserToDeleteRows = false;
            dtSeansListele.ReadOnly = true;
        }
    }
}
