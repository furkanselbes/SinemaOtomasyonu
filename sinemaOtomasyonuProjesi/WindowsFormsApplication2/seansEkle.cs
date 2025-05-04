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
    public partial class seansEkle : Form
    {
        public seansEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = bagkod.GetConnection();
        SqlCommand komut = new SqlCommand();
        SqlDataReader oku;
        int kontrol = 0;


        private void btnSeansEkleGeriDon_Click(object sender, EventArgs e)
        {
            eklemeIslemleri eklemeIslemleriForm = new eklemeIslemleri();
            eklemeIslemleriForm.Show();
            this.Hide();
        }

        private void btnSeansEkleCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFilm.Text != "" && cbSalon.Text != "") //comboboxların dolu boş kontrolü
                {
                    RadioButtonSeciliyse(); // radioButton kontrolü
                    if (seans != "") // seans seçildiyse
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }
                        // Bağlantımızı açıyoruz.
                        string kayit = "insert into Seanslar (filmId,tarih,seans,salonId) values (@filmId,@tarih,@seans,@salonId)";
                        // Tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                        komut.Parameters.AddWithValue("@filmId", Convert.ToInt16(cbFilm.SelectedValue));
                        komut.Parameters.AddWithValue("@tarih", dtTarih.Text);
                        komut.Parameters.AddWithValue("@seans", seans);
                        komut.Parameters.AddWithValue("@salonId",Convert.ToInt16(cbSalon.SelectedValue));
                        //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                        komut.ExecuteNonQuery();
                        //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                        baglanti.Close();
                        MessageBox.Show("Seans Ekleme Başarılı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (seans !="") // seans seçilmediyse
                    {
                        MessageBox.Show("Lütfen Seans Bilgilerini Giriniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();
                    }
                    
                }
                else
                    MessageBox.Show("Lütfen Seans Bilgilerini Giriniz.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bu Seans Daha Önce Eklendi!!!", "Uyarı");
                baglanti.Close();
            }
            foreach (Control item in Controls) if (item is ComboBox) item.Text = ""; // işlem bittikten sonra tüm comboboxları temizler
            foreach (Control item3 in groupBox1.Controls) // tüm radioButtonları kapatır
            {
                item3.Enabled = false;
            }
            dtTarih.Text = DateTime.Now.ToShortDateString();
 
        }

        private void SeansKontrolu() // salon adı ve tarihe göre eğer seans önceden seçildiyse radioButtonu kapatır
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select * from Seanslar where salonId='" + cbSalon.SelectedValue + "' and tarih='" + dtTarih.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    foreach (Control item2 in groupBox1.Controls)
                    {
                        if (read["seans"].ToString() == item2.Text)
                        {
                            item2.Enabled = false;
                        }
                    }
                }
                baglanti.Close();
                read.Close();
            }
            catch (Exception)
            {
    
            }
        }
         public void salonYukle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string sorgu = "select * from Salonlar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu,baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbSalon.DataSource = dt;
                cbSalon.ValueMember = "salonId";
                cbSalon.DisplayMember = "salonAdi";
                baglanti.Close();
                kontrol = 1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }


        string seans = "";

        private void seansEkle_Load(object sender, EventArgs e)
        {
            salonYukle();
            foreach (Control item in Controls) if (item is ComboBox) item.Text = ""; // tüm comboboxları temizler

            foreach (Control item3 in groupBox1.Controls) // form açılırken radioButtonları kapatır
            {
                item3.Enabled = false;
            }
        }

        private void TarihKontrolu() // radioButtonları zamana göre aktif ya da pasif eder
        {
            foreach (Control item3 in groupBox1.Controls) // tüm radioButtonları aktif eder
            {
                item3.Enabled = true;
            }
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString()); // datetimepickerı bu güne ayarlar
            DateTime yeni = DateTime.Parse(dtTarih.Text); // seçilen gün
            if (yeni == bugun) // saate göre karşılaştırma
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString())>DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                SeansKontrolu(); // salon adı ve tarihe göre eğer seans önceden seçildiyse radioButtonu kapatır
            }
            else if (yeni > bugun) // gelecekteki günlere göre karşılaştırma
            {
                SeansKontrolu(); // salon adı ve tarihe göre eğer seans önceden seçildiyse radioButtonu kapatır
            }
            else if (yeni < bugun)
            {
                MessageBox.Show("Geriye Dönük İşlem Yapılamaz!!!", "Uyarı");
                dtTarih.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void FilmTarihKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut = new SqlCommand("select * from Filmler where vizyonTarihi like '" + dtTarih.Text + "'", baglanti);
            oku = komut.ExecuteReader();
            
            if (oku.Read() == true)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from Filmler where vizyonTarihi like '" + dtTarih.Text + "'", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbFilm.DataSource = dt;
                    cbFilm.DisplayMember = "filmAdi";
                    cbFilm.ValueMember = "filmId";
                    
                    baglanti.Close();
                    kontrol = 1;
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    baglanti.Close();
                    oku.Close();
                }
                oku.Close();
                baglanti.Close();
            }
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            
            if (kontrol > 0)
            {
                cbFilm.Text = "";
                cbFilm.DataSource = null;
                FilmTarihKontrol();
                TarihKontrolu(); // datetimepicker değişirse kontrol eder

            }
            

        }

        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kontrol > 0)
            {
                TarihKontrolu(); // salon seçildiğinde datetimepickera göre radioButtonları kontrol eder
            }
        }
        private void RadioButtonSeciliyse() // radioButton kontrolü
        {
            if (radioButton1.Checked) seans = radioButton1.Text;
            else if (radioButton4.Checked) seans = radioButton4.Text;
            else if (radioButton7.Checked) seans = radioButton7.Text;
            else if (radioButton10.Checked) seans = radioButton10.Text;
            else if (radioButton11.Checked) seans = radioButton11.Text;
        }


    }
}
