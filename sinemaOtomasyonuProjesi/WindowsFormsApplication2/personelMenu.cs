
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
using System.Collections;
using baglantiClass;

namespace WindowsFormsApplication2
{
    public partial class personelMenu : Form
    {
        public personelMenu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = bagkod.GetConnection();
        SqlCommand komut = new SqlCommand();
        SqlDataReader oku;
        int sayac; 
        int kontrol = 0;


        public void filmYukle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string sorgu = "select * from Filmler";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbPersonelFilm.DataSource = dt;
                cbPersonelFilm.ValueMember = "filmId";
                cbPersonelFilm.DisplayMember = "filmAdi";
                baglanti.Close();
                kontrol = 1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }


        public void filmBilgileriYukle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select * from Filmler where filmAdi='"+cbPersonelFilm.Text+"'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    pbPersonelAfis.ImageLocation = oku["afis"].ToString();
                    tbPersonelFilmTuru.Text = oku["filmTuru"].ToString();
                    tbPersonelFilmYonetmeni.Text = oku["yonetmen"].ToString();
                    tbPersonelSes.Text = oku["filmSesi"].ToString();
                }
                baglanti.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }


        private void filmTarihiGetir()
        {
            cbPersonelFilmTarih.Text = "";
            cbPersonelSeans.Text = "";
            cbPersonelFilmTarih.Items.Clear();
            //cbPersonelSeans.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Filmler where filmAdi='"+cbPersonelFilm.Text+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (DateTime.Parse(oku["vizyonTarihi"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!cbPersonelFilmTarih.Items.Contains(oku["vizyonTarihi"].ToString()))
                    {
                        cbPersonelFilmTarih.Items.Add(oku["vizyonTarihi"].ToString());
                    }
                }
            }
            baglanti.Close();
        }

        

        private void filmSeansiGetir()
        {
            cbPersonelSeans.Text = "";
            cbPersonelSeans.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Seanslar where filmId='"+ cbPersonelFilm.SelectedValue+"' and tarih='"+cbPersonelFilmTarih.Text+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (DateTime.Parse(oku["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(oku["seans"].ToString())>DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        if (!cbPersonelSeans.Items.Contains(oku["seans"].ToString()))
                        {
                            cbPersonelSeans.Items.Add(oku["seans"].ToString());
                        } 
                    }
                }

                else if (DateTime.Parse(oku["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!cbPersonelSeans.Items.Contains(oku["seans"].ToString()))
                    {
                        cbPersonelSeans.Items.Add(oku["seans"].ToString());
                    }
                }
            }
        }


        private void filmSalonuGetir()
        {
            cbPersonelSalon.Text = "";
            cbPersonelSalon.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Seanslar,Salonlar where Seanslar.salonId=Salonlar.salonId and Seanslar.filmId='" + cbPersonelFilm.SelectedValue + "' and Seanslar.tarih='" + cbPersonelFilmTarih.Text + "' and Seanslar.seans='" + cbPersonelSeans.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (DateTime.Parse(oku["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(oku["seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        cbPersonelSalon.Items.Add(oku["salonAdi"].ToString());
                    }
                }

                else if (DateTime.Parse(oku["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    cbPersonelSalon.Items.Add(oku["salonAdi"].ToString());
                }
            }
            baglanti.Close();

        }

        //private void CbDoluKoltuklar() //Bilet sil için dolu koltukları comboboxta gösteriyor koltuk numarasından iptal ediyor
        //{
        //    foreach (Control item in panel1.Controls)
        //    {
        //        if (item is Button)
        //        {
        //            if (item.BackColor == Color.Red)
        //            {
                        
        //            }
        //        }
        //    }
        //}

        private void yenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void veritabaniDoluKoltuklar()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Musteriler where filmAdi='" + cbPersonelFilm.Text + "' and salonAdi='"+cbPersonelSalon.Text+"' and tarih='"+cbPersonelFilmTarih.Text+ "' and seans='"+cbPersonelSeans.Text+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (oku["koltuk"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }


        private void koltuklar()
        {
            panel1.Controls.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            string[] koltuk = { "a", "b", "c", "d", "e","f","g","h","i","j","k","l","m","n"};
            sayac = 1;
            
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut = new SqlCommand("select * from Salonlar where salonAdi='"+cbPersonelSalon.Text+"'", baglanti);
            oku = komut.ExecuteReader();
            string butonText;
            int satir, sutun;
            if (oku.Read() == true)
            {
                satir = Convert.ToInt16(oku["yatayKoltukSayisi"]);
                sutun = Convert.ToInt16(oku["dikeyKoltukSayisi"]);
                for (int i = 1; i <=satir ; i++)
                {
                    sayac = 1;
                    for (int j = 1; j <=sutun;  j++)
                    {

                        Button btn = new Button();
                        btn.Size = new Size(32, 32);
                        btn.Location = new Point(j * 32, i * 32);
                        butonText = sayac.ToString() + koltuk[i - 1];
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.White;
                        Font eski = btn.Font;
                        btn.Font = new Font(eski.FontFamily, eski.Size - 2, eski.Style);
                        btn.Name = sayac.ToString();
                        btn.Text = butonText;
                        btn.Click += new EventHandler(Btn_Click);
                        sayac++;
                        this.panel1.Controls.Add(btn);
                        
                    }
                }
            }
        }

        private void personelMenu_Load(object sender, EventArgs e)
        {
            filmYukle();
            koltuklar();
            veritabaniDoluKoltuklar();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            tbKoltuk.Text = text;
            
        }

        //public void listele()
        //{
        //    if (baglanti.State == ConnectionState.Closed)
        //    {
        //        baglanti.Open();
        //    }

        //    string getir = "select filmAdi,filmTuru,yonetmen,afis,vizyonTarihi,filmSesi,filmId from Filmler";
        //    komut = new SqlCommand(getir, baglanti);

        //    SqlDataAdapter da = new SqlDataAdapter(komut);

        //    DataTable dt = new DataTable();

        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;

        //    baglanti.Close();
        //}




        private void btnPersonelMenuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonelMenuGeriDon_Click(object sender, EventArgs e)
        {
            giris girisEkraniForm = new giris();
            girisEkraniForm.Show();
            this.Hide();
        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                komut = new SqlCommand("select * from Musteriler where koltuk='"+tbKoltuk.Text+"' and filmAdi='" + cbPersonelFilm.Text + "' and salonAdi='" + cbPersonelSalon.Text + "' and tarih='" + cbPersonelFilmTarih.Text + "' and seans='" + cbPersonelSeans.Text + "'", baglanti);
                oku = komut.ExecuteReader();
                    if (oku.Read() == true)
                    {
                        foreach (Control item in panel1.Controls)
                        {
                            if (item is Button)
                            {
                                if (oku["koltuk"].ToString() == item.Text)
                                {
                                    MessageBox.Show("Bu koltuk daha önce seçildi !!");
                                    break;
                                }
                            }
                        } 
                    }
                    else if (tbMusteriAd.Text != "" && tbMusteriSoyad.Text != "" && cbBilet.Text != "" && cbPersonelFilm.Text != "" && cbPersonelFilmTarih.Text != "" && cbPersonelSeans.Text != "" && cbPersonelSalon.Text != "")
                    {

                        komut = new SqlCommand();
                        komut.Connection = baglanti;
                        komut = new SqlCommand("insert into Musteriler (ad,soyad,filmAdi,bilet,salonAdi,tarih,seans,koltuk,biletParasi,misirParasi) values (@ad,@soyad,@filmAdi,@bilet,@salonAdi,@tarih,@seans,@koltuk,@biletParasi,@misirParasi)", baglanti);
                        //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                        komut.Parameters.AddWithValue("@ad", tbMusteriAd.Text);
                        komut.Parameters.AddWithValue("@soyad", tbMusteriSoyad.Text);
                        komut.Parameters.AddWithValue("@filmAdi", cbPersonelFilm.Text);
                        komut.Parameters.AddWithValue("@bilet", cbBilet.Text);
                        komut.Parameters.AddWithValue("@salonAdi", cbPersonelSalon.Text);
                        komut.Parameters.AddWithValue("@tarih", cbPersonelFilmTarih.Text);
                        komut.Parameters.AddWithValue("@seans", cbPersonelSeans.Text);
                        komut.Parameters.AddWithValue("@koltuk", tbKoltuk.Text);
                        komut.Parameters.AddWithValue("@biletParasi", lblBiletFiyat.Text.Split(' ')[0]);
                        komut.Parameters.AddWithValue("@misirParasi", lblMisirFiyat.Text.Split(' ')[0]);

                        //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                        komut.ExecuteNonQuery();
                        yenidenRenklendir();
                        veritabaniDoluKoltuklar();

                        //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                        baglanti.Close();
                        MessageBox.Show("Bilet Kesildi.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bilet Bilgilerini Giriniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();
                    }
                    

            //}
            //catch (Exception ex)
            //{
              //MessageBox.Show(ex.Message);
              baglanti.Close();
            //}
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void cbPersonelSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(kontrol>0)
            {
                koltuklar();
                yenidenRenklendir();
                veritabaniDoluKoltuklar();
            }
                

            
        }

        private void cbPersonelSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kontrol > 0)
            {
                filmSalonuGetir();
                
            }
        }


        private void cbPersonelFilmTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmSeansiGetir();
        }

        private void cbPersonelFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmBilgileriYukle();
            filmTarihiGetir(); 
            cbPersonelSeans.Text = "";
            cbPersonelSeans.Items.Clear();
            cbPersonelSalon.Text = "";
            cbPersonelSalon.Items.Clear();
        }

        private void cbBilet_SelectedIndexChanged(object sender, EventArgs e)
        {
            biletFiyat();
            misirFiyat();
            toplamFiyat();
        }

        private void tbMusteriAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)  && !char.IsSeparator(e.KeyChar);
        }

        private void tbMusteriSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)  && !char.IsSeparator(e.KeyChar);
        }

        private void toplamFiyat()
        {
            if (lblBiletFiyat.Text == "0 TL" && lblMisirFiyat.Text == "0 TL")
            {
                lblToplamFiyat.Text = "0 TL";
            }

            if (checkBox1.Checked)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new SqlCommand("select * from Misir ", baglanti);
                oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    lblToplamFiyat.Text = (Convert.ToInt32(lblBiletFiyat.Text.Split(' ')[0]) + Convert.ToInt32(oku["misirParasi"])).ToString() + " TL";
                }
            }
            else if (checkBox1.Checked == false)
            {
                komut = new SqlCommand("select * from Biletler where bilet='" + cbBilet.Text + "'", baglanti);
                oku = komut.ExecuteReader();
                if (oku.Read() == true)
                {
                    lblToplamFiyat.Text = oku["biletParasi"].ToString() + " TL";
                }
            }
        }

        private void biletFiyat()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            komut = new SqlCommand("select * from Biletler where bilet='" + cbBilet.Text + "'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                lblBiletFiyat.Text = oku["biletParasi"].ToString() + " TL";
            }
        }

        private void misirFiyat()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut = new SqlCommand("select * from Misir ", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                if (checkBox1.Checked)
                {
                    lblMisirFiyat.Text = oku["misirParasi"].ToString() + " TL";
                }
                else
                {
                    lblMisirFiyat.Text = "0 TL";
                }
                
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            biletFiyat();
            misirFiyat();
            toplamFiyat();
        }
    }
}

