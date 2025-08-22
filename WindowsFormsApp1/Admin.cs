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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            FormGetir(uyeekle);
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListele uyelistele = new UyeListele();
            FormGetir(uyelistele);
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapekle = new KitapEkle();
            FormGetir(kitapekle);
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListele kitaplistele = new KitapListele();
            FormGetir(kitaplistele);
        }

        private void btnEkitapVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVer ekitapver = new EmanetKitapVer();
            FormGetir(ekitapver);
        }

        private void btnEKitapListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListele ekitaplistele = new EmanetKitapListele();
            FormGetir(ekitaplistele);
        }

        private void btnEKitapİade_Click(object sender, EventArgs e)
        {
            EmanetKitapİade ekitapiade = new EmanetKitapİade();
            FormGetir(ekitapiade);
        }

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {
            KitapRezervasyon kitaprez = new KitapRezervasyon();
            FormGetir(kitaprez);
        }

        private void btnRezKitapVer_Click(object sender, EventArgs e)
        {
            RezerveEdilenKitaplar rezedilenkitaplar = new RezerveEdilenKitaplar();
            FormGetir(rezedilenkitaplar);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
