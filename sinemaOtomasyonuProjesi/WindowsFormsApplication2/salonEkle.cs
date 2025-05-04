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
    public partial class salonEkle : Form
    {
        public salonEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = bagkod.GetConnection();

        private void btnSalonEkleCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalonEkleGeriDon_Click(object sender, EventArgs e)
        {
            eklemeIslemleri eklemeIslemleriForm = new eklemeIslemleri();
            eklemeIslemleriForm.Show();
            this.Hide();
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            int dKoltuk, yKoltuk;
            dKoltuk=Convert.ToInt16(tbDikeyKoltuk.Text);
            yKoltuk = Convert.ToInt16(tbYatayKoltuk.Text);

            if ( dKoltuk>10 || yKoltuk>10)
            {
                MessageBox.Show("Yatay koltuk veya dikey koltuk sayısı 10'dan büyük olamaz !!! ");
            }
            else
            try
            {
                if (tbSalon.Text != "" && tbDikeyKoltuk.Text != "" )
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    // Bağlantımızı açıyoruz.
                    string kayit = "insert into Salonlar (salonAdi,dikeyKoltukSayisi,yatayKoltukSayisi) values (@salonAdi,@dikeyKoltukSayisi,@yatayKoltukSayisi)";
                    // Tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@salonAdi", tbSalon.Text);
                    komut.Parameters.AddWithValue("@dikeyKoltukSayisi", tbDikeyKoltuk.Text);
                    komut.Parameters.AddWithValue("@yatayKoltukSayisi", tbYatayKoltuk.Text);
                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Salon Ekleme Başarılı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Salon Bilgilerini Giriniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Salon Daha Önce Eklendi!!!", "Uyarı");
                baglanti.Close();
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void salonEkle_Load(object sender, EventArgs e)
        {

        }

        private void tbSalon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbDikeyKoltuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbYatayKoltuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
