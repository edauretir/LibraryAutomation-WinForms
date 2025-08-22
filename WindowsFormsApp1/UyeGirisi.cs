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
    public partial class UyeGirisi : Form
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=eda;Initial Catalog=KütüphaneOtomasyon;Integrated Security=True");
        public static string uyeno, tc, ad, soyad, yetki;

        private void UyeGirisi_Load(object sender, EventArgs e)
        {

        }

        bool drmkontrol = false;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT *FROM uye", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read() == true)
            {
                if (oku["kullaniciadi"].ToString() == txtKuladi.Text && oku["sifre"].ToString() == txtSifre.Text && oku["yetki"].ToString() == "Admin")
                {
                    drmkontrol = true;
                    uyeno = oku.GetValue(0).ToString();
                    tc = oku.GetValue(1).ToString();
                    ad = oku.GetValue(2).ToString();
                    soyad = oku.GetValue(3).ToString();
                    yetki = oku.GetValue(4).ToString();
                    Admin ac = new Admin();
                    ac.Show();
                    this.Hide();
                    break;
                }

                if (oku["kullaniciadi"].ToString() == txtKuladi.Text && oku["sifre"].ToString() == txtSifre.Text && oku["yetki"].ToString() == "")
                {
                    drmkontrol = true;
                    uyeno = oku.GetValue(0).ToString();
                    tc = oku.GetValue(1).ToString();
                    ad = oku.GetValue(2).ToString();
                    soyad = oku.GetValue(3).ToString();
                    yetki = oku.GetValue(4).ToString();
                    Kullanici ac = new Kullanici();
                    ac.Show();
                    this.Hide();
                    break;
                }
            }
            if (txtKuladi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez.");
            }
            else if (drmkontrol == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
            baglanti.Close();
        }


        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kaydol kaydol = new Kaydol();
            kaydol.Show();
        }
    }
}
