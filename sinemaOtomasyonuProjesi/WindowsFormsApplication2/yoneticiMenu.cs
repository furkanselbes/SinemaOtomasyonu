﻿using System;
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
    public partial class yoneticiMenu : Form
    {
        public yoneticiMenu()
        {
            InitializeComponent();
        }

       

        



        private void button1_Click(object sender, EventArgs e)
        {
            eklemeIslemleri eklemeIslemleriForm = new eklemeIslemleri();
            eklemeIslemleriForm.Show();
            this.Hide();
        }

        private void btnYoneticiAnaMenuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYoneticiAnaMenuGeriDon_Click(object sender, EventArgs e)
        {
            giris girisEkraniForm = new giris();
            girisEkraniForm.Show();
            this.Hide();
        }

       

        

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            silmeIslemleri silmeIslemleriForm = new silmeIslemleri();
            silmeIslemleriForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporlar raporlarForm = new Raporlar();
            raporlarForm.Show();
            this.Hide();
        }

        private void yoneticiMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
