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
    public partial class RezerveEdilenKitaplar : Form
    {
        public RezerveEdilenKitaplar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=eda;Initial Catalog=KütüphaneOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();

        private void RezerveEdilenKitaplar_Load(object sender, EventArgs e)
        {
            emanetlistele();
            comboBox1.SelectedIndex = 0;
        }
        private void emanetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from rezerveedilenkitaplar", baglanti);
            adtr.Fill(daset, "rezerveedilenkitaplar");
            dataGridView1.DataSource = daset.Tables["rezerveedilenkitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["rezerveedilenkitaplar"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                emanetlistele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from rezerveedilenkitaplar where '" + DateTime.Now.ToShortDateString() + "'>iadetarihi", baglanti);
                adtr.Fill(daset, "rezerveedilenkitaplar");
                dataGridView1.DataSource = daset.Tables["rezerveedilenkitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from rezerveedilenkitaplar where '" + DateTime.Now.ToShortDateString() + "'<= iadetarihi", baglanti);
                adtr.Fill(daset, "rezerveedilenkitaplar");
                dataGridView1.DataSource = daset.Tables["rezerveedilenkitaplar"];
                baglanti.Close();
            }
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from rezerveedilenkitaplar where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi yapıldı", "Silme İşlemi");
                daset.Tables["rezerveedilenkitaplar"].Clear();
            }
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["rezerveedilenkitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from rezerveedilenkitaplar where tc like'%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(daset, "rezerveedilenkitaplar");
            dataGridView1.DataSource = daset.Tables["rezerveedilenkitaplar"];
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["rezerveedilenkitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from rezerveedilenkitaplar where barkodno like'%" + txtBarkodNo.Text + "%'", baglanti);
            adtr.Fill(daset, "rezerveedilenkitaplar");
            dataGridView1.DataSource = daset.Tables["rezerveedilenkitaplar"];
            baglanti.Close();
        }
    }
}
