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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 4;
            if(panel2.Width>400)
            {
                timer1.Stop();
                UyeGirisi uyegirisi = new UyeGirisi();
                uyegirisi.Show();
                this.Hide();
            }
        }
    }
}
