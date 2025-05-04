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
using System.Threading;
using baglantiClass;

namespace WindowsFormsApplication2
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = bagkod.GetConnection();
        SqlCommand komut;
        SqlDataReader oku;


        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            giris girisEkraniForm = new giris();
            girisEkraniForm.Show();
            this.Hide();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }


        public void girisYap()
        {
            if (tbKullaniciAdi.Text == "" || tbSifre.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Giriniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "select * from Kullanicilar where kullaniciAdi = '" + tbKullaniciAdi.Text + "'";
                    oku = komut.ExecuteReader();

                    if (oku.Read() == true)
                    {
                        if (tbSifre.Text == oku["sifre"].ToString() && oku["yetkiId"].ToString() == "1")
                        {
                           
                            baglanti.Close();
                            yoneticiMenu yoneticiAnaMenu = new yoneticiMenu();
                            yoneticiAnaMenu.Show();
                            this.Hide();
                            
                        }
                        else if (tbSifre.Text == oku["sifre"].ToString() && oku["yetkiId"].ToString() == "2")
                        {
                            baglanti.Close();
                            personelMenu personelAnaMenu = new personelMenu();
                            
                            
                                personelAnaMenu.Show();
                                this.Hide();
                            
                        }
                        else
                            MessageBox.Show("Kullanıcı Adınız ya da Şifreniz Yanlış. Lütfen Kontrol Ediniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();
                    }

                    else
                        MessageBox.Show("Kullanıcı Adınız ya da Şifreniz Yanlış. Lütfen Kontrol Ediniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    baglanti.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);

                    baglanti.Close();
                }
            }
        }
       
        private void btnGiris_Click(object sender, EventArgs e)
        {
            girisYap();
        }

        private void btnGirisCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
