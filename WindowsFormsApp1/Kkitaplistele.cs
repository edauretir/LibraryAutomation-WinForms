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
    public partial class Kkitaplistele : Form
    {
        public Kkitaplistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=eda;Initial Catalog=KütüphaneOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void Kkitaplistele_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where kitapadi like'%" + txtKitapAra.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }
        private void txtYazarAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where yazari like'%" + txtYazarAra.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where turu like'%" + textBox1.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where kitapadi like'" + txtKitapAdi.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtBarkodNo.Text = read["barkodno"].ToString();
                txtYazari.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                comboTuru.Text = read["turu"].ToString();
                txtStokSayisi.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtAciklama.Text = read["aciklama"].ToString();
            }
            baglanti.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
