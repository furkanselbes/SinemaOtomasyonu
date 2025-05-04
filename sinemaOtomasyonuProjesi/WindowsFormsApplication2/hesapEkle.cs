using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class hesapEkle : Form
    {
        public hesapEkle()
        {
            InitializeComponent();
        }

       

        

       

        

        private void btnYoneticiHesapEkle_Click(object sender, EventArgs e)
        {
            yoneticiHesabiEkle yoneticiHesabiEkleForm = new yoneticiHesabiEkle();
            yoneticiHesabiEkleForm.Show();
            this.Hide();
        }

        private void btnPersonelHesapEkle_Click(object sender, EventArgs e)
        {
            personelHesabiEkle personelHesabiEkleForm = new personelHesabiEkle();
            personelHesabiEkleForm.Show();
            this.Hide();
        }

        private void btnHesapEkleCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHesapEkleGeriDon_Click(object sender, EventArgs e)
        {
            eklemeIslemleri eklemeIslemleriForm = new eklemeIslemleri();
            eklemeIslemleriForm.Show();
            this.Hide();
        }

        private void hesapEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
