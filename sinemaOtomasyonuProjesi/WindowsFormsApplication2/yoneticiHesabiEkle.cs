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
    public partial class yoneticiHesabiEkle : Form
    {
        public yoneticiHesabiEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = bagkod.GetConnection();

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            hesapEkle hesapEkleForm = new hesapEkle();
            hesapEkleForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click_1(object sender, EventArgs e)
        {
            hesapEkle hesapEkleForm = new hesapEkle();
            hesapEkleForm.Show();
            this.Hide();
        }

       

        

      

        private void btnYoneticiHesapEkleGeriDon_Click(object sender, EventArgs e)
        {
            hesapEkle hesapEkleForm = new hesapEkle();
            hesapEkleForm.Show();
            this.Hide();
        }

        private void btnYoneticiHesapEkleCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYoneticiHesapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbYntcKullaniciAdi.Text != "" || tbYntcSifre.Text != "" || tbYntcSifreTekrar.Text != "")
                {
                    if (tbYntcSifre.Text == tbYntcSifreTekrar.Text)
                    {
                            if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }
                    // Bağlantımızı açıyoruz.
                    string kayit = "insert into Kullanicilar (kullaniciAdi,sifre,yetkiId) values (@kullaniciAdi,@sifre,@yetkiId)";
                    // Tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@kullaniciAdi", tbYntcKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@sifre", tbYntcSifre.Text);
                    komut.Parameters.AddWithValue("@yetkiId", 1);
                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarılı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bilgilerinizi Giriniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                baglanti.Close();
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

       

        private void tbYntcKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
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

        private void yoneticiHesabiEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
