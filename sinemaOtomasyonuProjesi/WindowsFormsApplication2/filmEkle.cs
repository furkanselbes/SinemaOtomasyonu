using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baglantiClass;

namespace WindowsFormsApplication2
{
    public partial class filmEkle : Form
    {
        public filmEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = bagkod.GetConnection();

        private void FilmTuruGoster(ComboBox combo, string sql, string sql2)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read() == true)
            {
                combo.Items.Add(oku[sql2].ToString());
            }
            baglanti.Close();
        }


        private void TarihKontrolu() 
        {
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString()); // datetimepickerı bu güne ayarlar
            DateTime yeni = DateTime.Parse(tbFilmtarih.Text); // seçilen gün
            
            if (yeni < bugun)
            {
                MessageBox.Show("Geriye Dönük İşlem Yapılamaz!!!", "Uyarı");
                tbFilmtarih.Text = DateTime.Now.ToShortDateString();
            }
        }


        private void btnYoneticiAnaMenuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYoneticiAnaMenuGeriDon_Click(object sender, EventArgs e)
        {

            eklemeIslemleri eklemeIslemleriForm = new eklemeIslemleri();
            eklemeIslemleriForm.Show();
            this.Hide();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFilm.Text != "" && cbFilmTuru.Text != "" && tbFilmYonetmeni.Text != "" && tbFilmtarih.Text != "" && cbSes.Text != "" && pbAfis.Image != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    // Bağlantımızı açıyoruz.
                    SqlCommand komut = new SqlCommand("insert into Filmler (filmAdi,filmTuru,yonetmen,afis,vizyonTarihi,filmSesi) values (@filmAdi,@filmTuru,@yonetmen,@afis,@vizyonTarihi,@filmSesi)", baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@filmAdi", tbFilm.Text);
                    komut.Parameters.AddWithValue("@filmTuru", cbFilmTuru.Text);
                    komut.Parameters.AddWithValue("@yonetmen", tbFilmYonetmeni.Text);
                    komut.Parameters.AddWithValue("@vizyonTarihi", tbFilmtarih.Text);
                    komut.Parameters.AddWithValue("@filmSesi", cbSes.Text);
                    komut.Parameters.AddWithValue("@afis", pbAfis.ImageLocation);
                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Film Ekleme Başarılı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Film Bilgilerini Giriniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Bu Film Daha önce eklendi!!!" , "Uyarı");
                baglanti.Close();
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pbAfis.Image = null;
        }

        private void btnAfisSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbAfis.ImageLocation = openFileDialog1.FileName;
        }

        private void filmEkle_Load(object sender, EventArgs e)
        {
            FilmTuruGoster(cbFilmTuru, "select *from Turler", "turAdi");
        }

        private void tbFilm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void tbFilmYonetmeni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbFilmtarih_ValueChanged(object sender, EventArgs e)
        {
            TarihKontrolu();
        }
    }
}
