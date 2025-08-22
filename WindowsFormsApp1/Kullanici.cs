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


namespace WindowsFormsApp1
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=eda;Initial Catalog=KütüphaneOtomasyon;Integrated Security=True");
        public static string tc, ad, soyad, dogtar, telefon, barkodno, kitapadi, yazari, yayinevi, sayfasayisi, kitapsayisi, teslimtarihi, iadetarihi;

        private void Kullanici_Load(object sender, EventArgs e)
        {
            label5.Text = UyeGirisi.tc;
            label6.Text = UyeGirisi.ad;
            label7.Text = UyeGirisi.soyad;   
        }

        bool drmkontrol = false;
        private void btnBilgi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT *FROM emanetkitaplar", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read() == true)
            {
                if (oku["tc"].ToString() == txtTc.Text && oku["ad"].ToString() == txtAd.Text) 
                {
                    drmkontrol = true;
                    tc = oku.GetValue(0).ToString();
                    ad = oku.GetValue(1).ToString();
                    soyad = oku.GetValue(2).ToString();
                    dogtar = oku.GetValue(3).ToString();
                    telefon = oku.GetValue(4).ToString();
                    barkodno = oku.GetValue(5).ToString();
                    kitapadi = oku.GetValue(6).ToString();
                    yazari = oku.GetValue(7).ToString();
                    yayinevi = oku.GetValue(8).ToString();
                    sayfasayisi = oku.GetValue(9).ToString();
                    kitapsayisi = oku.GetValue(10).ToString();
                    teslimtarihi = oku.GetValue(11).ToString();
                    iadetarihi = oku.GetValue(12).ToString();
                    Bilgi ac = new Bilgi();
                    ac.Show();
                    this.Hide();
                    break;
                }

            }
            if (txtTc.Text == "" || txtAd.Text == "")
            {
                MessageBox.Show("Tc ve Ad boş geçilemez.");
            }
            else if (drmkontrol == false)
            {
                MessageBox.Show("Tc veya Ad yanlış.");
            }
            baglanti.Close();
        }

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {
            KitapRezervasyon kitaprezervasyon = new KitapRezervasyon();
            kitaprezervasyon.Show();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            Kkitaplistele kkitaplistele = new Kkitaplistele();
            kkitaplistele.Show();
        }
    }
}
