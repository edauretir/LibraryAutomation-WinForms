
namespace WindowsFormsApp1
{
    partial class KitapRezervasyon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label16 = new System.Windows.Forms.Label();
            this.lblKitapSayi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblKayitliKitapSayi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnRezerveEt = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpKitapBilgi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.grpUyeBilgi = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpKitapBilgi.SuspendLayout();
            this.grpUyeBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(538, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 24);
            this.label16.TabIndex = 81;
            this.label16.Text = "KİTAP RERZERVASYON";
            // 
            // lblKitapSayi
            // 
            this.lblKitapSayi.AutoSize = true;
            this.lblKitapSayi.ForeColor = System.Drawing.Color.White;
            this.lblKitapSayi.Location = new System.Drawing.Point(737, 541);
            this.lblKitapSayi.Name = "lblKitapSayi";
            this.lblKitapSayi.Size = new System.Drawing.Size(0, 17);
            this.lblKitapSayi.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(654, 541);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 79;
            this.label15.Text = "Kitap Sayısı";
            // 
            // lblKayitliKitapSayi
            // 
            this.lblKayitliKitapSayi.AutoSize = true;
            this.lblKayitliKitapSayi.ForeColor = System.Drawing.Color.White;
            this.lblKayitliKitapSayi.Location = new System.Drawing.Point(561, 541);
            this.lblKayitliKitapSayi.Name = "lblKayitliKitapSayi";
            this.lblKayitliKitapSayi.Size = new System.Drawing.Size(0, 17);
            this.lblKayitliKitapSayi.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(433, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Kayıtlı Kitap Sayısı";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1006, 61);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 40);
            this.btnSil.TabIndex = 76;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnRezerveEt
            // 
            this.btnRezerveEt.Location = new System.Drawing.Point(810, 529);
            this.btnRezerveEt.Name = "btnRezerveEt";
            this.btnRezerveEt.Size = new System.Drawing.Size(92, 40);
            this.btnRezerveEt.TabIndex = 75;
            this.btnRezerveEt.Text = "Rezerve Et";
            this.btnRezerveEt.UseVisualStyleBackColor = true;
            this.btnRezerveEt.Click += new System.EventHandler(this.btnRezerveEt_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(908, 529);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(92, 40);
            this.btnİptal.TabIndex = 74;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(204, 586);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 40);
            this.btnEkle.TabIndex = 73;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpKitapBilgi
            // 
            this.grpKitapBilgi.BackColor = System.Drawing.Color.Transparent;
            this.grpKitapBilgi.Controls.Add(this.label4);
            this.grpKitapBilgi.Controls.Add(this.txtSayfaSayisi);
            this.grpKitapBilgi.Controls.Add(this.label11);
            this.grpKitapBilgi.Controls.Add(this.label12);
            this.grpKitapBilgi.Controls.Add(this.label9);
            this.grpKitapBilgi.Controls.Add(this.label5);
            this.grpKitapBilgi.Controls.Add(this.label6);
            this.grpKitapBilgi.Controls.Add(this.label7);
            this.grpKitapBilgi.Controls.Add(this.label8);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker2);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker1);
            this.grpKitapBilgi.Controls.Add(this.txtKitapSayisi);
            this.grpKitapBilgi.Controls.Add(this.txtYayinEvi);
            this.grpKitapBilgi.Controls.Add(this.txtYazari);
            this.grpKitapBilgi.Controls.Add(this.txtKitapAdi);
            this.grpKitapBilgi.Controls.Add(this.txtBarkodNo);
            this.grpKitapBilgi.ForeColor = System.Drawing.Color.White;
            this.grpKitapBilgi.Location = new System.Drawing.Point(35, 272);
            this.grpKitapBilgi.Name = "grpKitapBilgi";
            this.grpKitapBilgi.Size = new System.Drawing.Size(261, 308);
            this.grpKitapBilgi.TabIndex = 72;
            this.grpKitapBilgi.TabStop = false;
            this.grpKitapBilgi.Text = "Kitap Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(124, 167);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(131, 22);
            this.txtSayfaSayisi.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Teslim Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "İade Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kitap Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Barkod No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kitap Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Yazarı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Yayın Evi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 275);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(124, 203);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(131, 22);
            this.txtKitapSayisi.TabIndex = 13;
            this.txtKitapSayisi.Text = "1";
            this.txtKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(124, 131);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(131, 22);
            this.txtYayinEvi.TabIndex = 12;
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(124, 95);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(131, 22);
            this.txtYazari.TabIndex = 11;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(124, 59);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(131, 22);
            this.txtKitapAdi.TabIndex = 10;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(124, 23);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(131, 22);
            this.txtBarkodNo.TabIndex = 9;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // grpUyeBilgi
            // 
            this.grpUyeBilgi.BackColor = System.Drawing.Color.Transparent;
            this.grpUyeBilgi.Controls.Add(this.dateTimePicker3);
            this.grpUyeBilgi.Controls.Add(this.txtSoyad);
            this.grpUyeBilgi.Controls.Add(this.label14);
            this.grpUyeBilgi.Controls.Add(this.label13);
            this.grpUyeBilgi.Controls.Add(this.txtTelefon);
            this.grpUyeBilgi.Controls.Add(this.txtAd);
            this.grpUyeBilgi.Controls.Add(this.txtTcAra);
            this.grpUyeBilgi.Controls.Add(this.label3);
            this.grpUyeBilgi.Controls.Add(this.label2);
            this.grpUyeBilgi.Controls.Add(this.label1);
            this.grpUyeBilgi.ForeColor = System.Drawing.Color.White;
            this.grpUyeBilgi.Location = new System.Drawing.Point(35, 61);
            this.grpUyeBilgi.Name = "grpUyeBilgi";
            this.grpUyeBilgi.Size = new System.Drawing.Size(261, 187);
            this.grpUyeBilgi.TabIndex = 71;
            this.grpUyeBilgi.TabStop = false;
            this.grpUyeBilgi.Text = "Üye Bigilri";
            this.grpUyeBilgi.Enter += new System.EventHandler(this.grpUyeBilgi_Enter);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(122, 113);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(122, 74);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(131, 22);
            this.txtSoyad.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(57, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Soyad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(49, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(122, 149);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(131, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(124, 46);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(131, 22);
            this.txtAd.TabIndex = 6;
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(124, 18);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(131, 22);
            this.txtTcAra.TabIndex = 5;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DogTar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Ara";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 459);
            this.dataGridView1.TabIndex = 70;
            // 
            // KitapRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblKitapSayi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblKayitliKitapSayi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnRezerveEt);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpKitapBilgi);
            this.Controls.Add(this.grpUyeBilgi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Rezervasyon";
            this.Load += new System.EventHandler(this.KitapRezervasyon_Load);
            this.grpKitapBilgi.ResumeLayout(false);
            this.grpKitapBilgi.PerformLayout();
            this.grpUyeBilgi.ResumeLayout(false);
            this.grpUyeBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblKitapSayi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblKayitliKitapSayi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnRezerveEt;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpKitapBilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.GroupBox grpUyeBilgi;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}