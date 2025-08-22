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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=eda;Initial Catalog=KütüphaneOtomasyon;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,ad,soyad,dogtar,cinsiyet,telefon,adres,email,okukitapsayisi,kullaniciadi,sifre) values(@tc,@ad,@soyad,@dogtar,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi,@kullaniciadi,@sifre)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@dogtar", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", txtOkunanSayi.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtOkunanSayi)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
