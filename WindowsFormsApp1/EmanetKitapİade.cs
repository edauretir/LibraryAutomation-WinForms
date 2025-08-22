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
    public partial class EmanetKitapİade : Form
    {
        public EmanetKitapİade()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=eda;Initial Catalog=KütüphaneOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        private void emanetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetkitaplar", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
            baglanti.Close();
        }

        private void EmanetKitapİade_Load(object sender, EventArgs e)
        {
            emanetlistele();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetkitaplar where tc like'%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            baglanti.Close();
            if (txtTcAra.Text == "")
            {
                daset.Tables["emanetkitaplar"].Clear();
                emanetlistele();
            }
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetkitaplar where barkodno like'%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            baglanti.Close();
            if (txtBarkodNoAra.Text == "")
            {
                daset.Tables["emanetkitaplar"].Clear();
                emanetlistele();
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from emanetkitaplar where tc=@tc and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update kitap set stoksayisi=stoksayisi+'" + dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() + "' where barkodno=@barkodno", baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitaplar iade edildi.");
            daset.Tables["emanetkitaplar"].Clear();
            emanetlistele();
        }
    }
}
