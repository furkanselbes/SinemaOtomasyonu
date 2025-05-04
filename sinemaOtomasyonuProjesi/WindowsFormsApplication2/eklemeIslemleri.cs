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
    public partial class eklemeIslemleri : Form
    {
        public eklemeIslemleri()
        {
            InitializeComponent();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            filmEkle filmEkleForm = new filmEkle();
            filmEkleForm.Show();
            this.Hide();
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            salonEkle salonEkleForm = new salonEkle();
            salonEkleForm.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            seansEkle seansEkleForm = new seansEkle();
            seansEkleForm.Show();
            this.Hide();
        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            hesapEkle hesapEkleForm = new hesapEkle();
            hesapEkleForm.Show();
            this.Hide();
        }

        private void btnEklemeIslemleriGeriDon_Click(object sender, EventArgs e)
        {
            yoneticiMenu yoneticiMenuForm = new yoneticiMenu();
            yoneticiMenuForm.Show();
            this.Hide();
        }

        private void btnEklemeIslemleriCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eklemeIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
