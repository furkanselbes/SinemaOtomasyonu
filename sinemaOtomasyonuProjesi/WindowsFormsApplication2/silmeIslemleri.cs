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

namespace WindowsFormsApplication2
{
    public partial class silmeIslemleri : Form
    {
        public silmeIslemleri()
        {
            InitializeComponent();
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            filmSil filmSilForm = new filmSil();
            filmSilForm.Show();
            this.Hide();
        }

        private void btnSalonSil_Click(object sender, EventArgs e)
        {
            salonSil salonSilForm = new salonSil();
            salonSilForm.Show();
            this.Hide();
        }

        private void btnSilmeİslemleriGeriDon_Click(object sender, EventArgs e)
        {
            yoneticiMenu yoneticiMenuForm = new yoneticiMenu();
            yoneticiMenuForm.Show();
            this.Hide();
        }

        private void btnSilmeİslemleriCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seansSil seansSilForm = new seansSil();
            seansSilForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hesapSil hesapSilForm = new hesapSil();
            hesapSilForm.Show();
            this.Hide();
        }

        private void silmeIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
