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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            seansListeleme seansListelemeForm = new seansListeleme();
            seansListelemeForm.Show();
            this.Hide();
        }

        private void btnSeansListeleGeriDon_Click(object sender, EventArgs e)
        {
            yoneticiMenu yoneticiMenuForm = new yoneticiMenu();
            yoneticiMenuForm.Show();
            this.Hide();
        }

        private void btnSeansListeleCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satisListeleme satisListelemeForm = new satisListeleme();
            satisListelemeForm.Show();
            this.Hide();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }
    }
}
