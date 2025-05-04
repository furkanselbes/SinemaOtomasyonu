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
    public partial class satisListeleme : Form
    {
        public satisListeleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = bagkod.GetConnection();
        SqlCommand komut = new SqlCommand();

        

        private void btnSatisListeleCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSatisListeleGeriDon_Click(object sender, EventArgs e)
        {
            Raporlar raporlarForm = new Raporlar();
            raporlarForm.Show();
            this.Hide();
        }

        private void ciroTablosu()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("SELECT SUM(biletParasi) as ogrenciBiletToplamPara FROM Musteriler where bilet='Öğrenci' and tarih like '" + dtTarih.Text + "'", baglanti);
            SqlCommand komut2 = new SqlCommand("SELECT SUM(misirParasi) as misirToplamPara FROM Musteriler where tarih like '" + dtTarih.Text + "'", baglanti);
            SqlCommand komut3 = new SqlCommand("SELECT SUM(biletParasi) as tamBiletToplamPara FROM Musteriler where bilet='Tam' and tarih like '" + dtTarih.Text + "'", baglanti);

            lblOgrenciTplmBltFiyat.Text = "";
            if (komut.ExecuteScalar().ToString() == "")
            {
                lblOgrenciTplmBltFiyat.Text = "0 TL";
            }
            else
            {
                lblOgrenciTplmBltFiyat.Text = komut.ExecuteScalar().ToString() + " TL";
            }

            lblTplmMısır.Text = "";
            if (komut2.ExecuteScalar().ToString() == "")
            {
                lblTplmMısır.Text = "0 TL";
            }
            else
            {
                lblTplmMısır.Text = komut2.ExecuteScalar().ToString() + " TL";
            }


            lblTamTplmBltFiyat.Text = "";
            if (komut3.ExecuteScalar().ToString() == "")
            {
                lblTamTplmBltFiyat.Text = "0 TL";
            }
            else
            {
                lblTamTplmBltFiyat.Text = komut3.ExecuteScalar().ToString() + " TL";
            }

            lblTplmCiro.Text = "";
            string cmd = komut.ExecuteScalar().ToString();
            string cmd2 = komut2.ExecuteScalar().ToString();
            string cmd3 = komut3.ExecuteScalar().ToString();
            if (komut.ExecuteScalar().ToString() == "" || komut2.ExecuteScalar().ToString() == "" || komut3.ExecuteScalar().ToString() == "")
            {
                if (komut.ExecuteScalar().ToString() == "")
                {
                    cmd = "0";
                }
                if (komut2.ExecuteScalar().ToString() == "")
                {
                    cmd2 = "0";
                }
                if (komut3.ExecuteScalar().ToString() == "")
                {
                    cmd3 = "0";
                }
                lblTplmCiro.Text = Convert.ToInt16(cmd) + Convert.ToInt16(cmd2) + Convert.ToInt16(cmd3) + " TL";
            }

            if (komut.ExecuteScalar().ToString() != "" && komut2.ExecuteScalar().ToString() != "" && komut3.ExecuteScalar().ToString() != "")
            {
                lblTplmCiro.Text = Convert.ToInt16(cmd) + Convert.ToInt16(cmd2) + Convert.ToInt16(cmd3) + " TL";
            }
            baglanti.Close();
        }

        private void toplamCiroTablosu()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("SELECT SUM(biletParasi) as ogrenciBiletToplamPara FROM Musteriler where bilet='Öğrenci'", baglanti);
            SqlCommand komut2 = new SqlCommand("SELECT SUM(misirParasi) as misirToplamPara FROM Musteriler", baglanti);
            SqlCommand komut3 = new SqlCommand("SELECT SUM(biletParasi) as tamBiletToplamPara FROM Musteriler where bilet='Tam'", baglanti);

            lblOgrenciTplmBltFiyat.Text = "";
            if (komut.ExecuteScalar().ToString() == "")
            {
                lblOgrenciTplmBltFiyat.Text = "0 TL";
            }
            else
            {
                lblOgrenciTplmBltFiyat.Text = komut.ExecuteScalar().ToString() + " TL";
            }

            lblTplmMısır.Text = "";
            if (komut2.ExecuteScalar().ToString() == "")
            {
                lblTplmMısır.Text = "0 TL";
            }
            else
            {
                lblTplmMısır.Text = komut2.ExecuteScalar().ToString() + " TL";
            }


            lblTamTplmBltFiyat.Text = "";
            if (komut3.ExecuteScalar().ToString() == "")
            {
                lblTamTplmBltFiyat.Text = "0 TL";
            }
            else
            {
                lblTamTplmBltFiyat.Text = komut3.ExecuteScalar().ToString() + " TL";
            }

            lblTplmCiro.Text = "";
            string cmd = komut.ExecuteScalar().ToString();
            string cmd2 = komut2.ExecuteScalar().ToString();
            string cmd3 = komut3.ExecuteScalar().ToString();
            if (komut.ExecuteScalar().ToString() == "" || komut2.ExecuteScalar().ToString() == "" || komut3.ExecuteScalar().ToString() == "")
            {
                if (komut.ExecuteScalar().ToString() == "")
                {
                    cmd = "0";
                }
                if (komut2.ExecuteScalar().ToString() == "")
                {
                    cmd2 = "0";
                }
                if (komut3.ExecuteScalar().ToString() == "")
                {
                    cmd3 = "0";
                }
                lblTplmCiro.Text = Convert.ToInt16(cmd) + Convert.ToInt16(cmd2) + Convert.ToInt16(cmd3) + " TL";
            }

            if (komut.ExecuteScalar().ToString() != "" && komut2.ExecuteScalar().ToString() != "" && komut3.ExecuteScalar().ToString() != "")
            {
                lblTplmCiro.Text = Convert.ToInt16(cmd) + Convert.ToInt16(cmd2) + Convert.ToInt16(cmd3) + " TL";
            }
            baglanti.Close();
        }


        private void satisListeleme_Load(object sender, EventArgs e)
        {
            ciroTablosu();   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            ciroTablosu();
        }

        private void btnTumFiyatlar_Click(object sender, EventArgs e)
        {
            toplamCiroTablosu();
        }
    }
}
