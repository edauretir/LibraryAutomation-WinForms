using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bilgi : Form
    {
        public Bilgi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bilgi_Load(object sender, EventArgs e)
        {
            label5.Text = Kullanici.tc;
            label6.Text = Kullanici.ad;
            label7.Text = Kullanici.soyad;
            label13.Text = Kullanici.dogtar;
            label21.Text = Kullanici.telefon;
            label14.Text = Kullanici.barkodno;
            label10.Text = Kullanici.kitapadi;
            label12.Text = Kullanici.yazari;
            label15.Text = Kullanici.yayinevi;
            label16.Text = Kullanici.sayfasayisi;
            label22.Text = Kullanici.kitapsayisi;
            label23.Text = Kullanici.teslimtarihi;
            label24.Text = Kullanici.iadetarihi;
        }
    }
}
