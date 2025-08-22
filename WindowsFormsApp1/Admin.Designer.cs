
namespace WindowsFormsApp1
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRezKitapVer = new System.Windows.Forms.Button();
            this.btnRezerveEt = new System.Windows.Forms.Button();
            this.btnEkitapVer = new System.Windows.Forms.Button();
            this.btnEKitapİade = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnEKitapListele = new System.Windows.Forms.Button();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnRezKitapVer);
            this.panel1.Controls.Add(this.btnRezerveEt);
            this.panel1.Controls.Add(this.btnEkitapVer);
            this.panel1.Controls.Add(this.btnEKitapİade);
            this.panel1.Controls.Add(this.btnUyeEkle);
            this.panel1.Controls.Add(this.btnKitapListele);
            this.panel1.Controls.Add(this.btnEKitapListele);
            this.panel1.Controls.Add(this.btnUyeListele);
            this.panel1.Controls.Add(this.btnKitapEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1111, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 653);
            this.panel1.TabIndex = 20;
            // 
            // btnRezKitapVer
            // 
            this.btnRezKitapVer.ForeColor = System.Drawing.Color.Maroon;
            this.btnRezKitapVer.Location = new System.Drawing.Point(25, 573);
            this.btnRezKitapVer.Name = "btnRezKitapVer";
            this.btnRezKitapVer.Size = new System.Drawing.Size(149, 46);
            this.btnRezKitapVer.TabIndex = 8;
            this.btnRezKitapVer.Text = "Rezerve Edilmiş Kitap Ver";
            this.btnRezKitapVer.UseVisualStyleBackColor = true;
            this.btnRezKitapVer.Click += new System.EventHandler(this.btnRezKitapVer_Click);
            // 
            // btnRezerveEt
            // 
            this.btnRezerveEt.ForeColor = System.Drawing.Color.Maroon;
            this.btnRezerveEt.Location = new System.Drawing.Point(25, 524);
            this.btnRezerveEt.Name = "btnRezerveEt";
            this.btnRezerveEt.Size = new System.Drawing.Size(149, 43);
            this.btnRezerveEt.TabIndex = 7;
            this.btnRezerveEt.Text = "Kitap Rezerve Et";
            this.btnRezerveEt.UseVisualStyleBackColor = true;
            this.btnRezerveEt.Click += new System.EventHandler(this.btnRezerveEt_Click);
            // 
            // btnEkitapVer
            // 
            this.btnEkitapVer.ForeColor = System.Drawing.Color.Maroon;
            this.btnEkitapVer.Location = new System.Drawing.Point(25, 325);
            this.btnEkitapVer.Name = "btnEkitapVer";
            this.btnEkitapVer.Size = new System.Drawing.Size(149, 43);
            this.btnEkitapVer.TabIndex = 4;
            this.btnEkitapVer.Text = "Emanet Kitap Verme";
            this.btnEkitapVer.UseVisualStyleBackColor = true;
            this.btnEkitapVer.Click += new System.EventHandler(this.btnEkitapVer_Click);
            // 
            // btnEKitapİade
            // 
            this.btnEKitapİade.ForeColor = System.Drawing.Color.Maroon;
            this.btnEKitapİade.Location = new System.Drawing.Point(25, 426);
            this.btnEKitapİade.Name = "btnEKitapİade";
            this.btnEKitapİade.Size = new System.Drawing.Size(149, 46);
            this.btnEKitapİade.TabIndex = 3;
            this.btnEKitapİade.Text = "Emanet Kitap İade";
            this.btnEKitapİade.UseVisualStyleBackColor = true;
            this.btnEKitapİade.Click += new System.EventHandler(this.btnEKitapİade_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.ForeColor = System.Drawing.Color.Maroon;
            this.btnUyeEkle.Location = new System.Drawing.Point(25, 32);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(149, 46);
            this.btnUyeEkle.TabIndex = 3;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.ForeColor = System.Drawing.Color.Maroon;
            this.btnKitapListele.Location = new System.Drawing.Point(25, 226);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(149, 46);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnEKitapListele
            // 
            this.btnEKitapListele.ForeColor = System.Drawing.Color.Maroon;
            this.btnEKitapListele.Location = new System.Drawing.Point(25, 374);
            this.btnEKitapListele.Name = "btnEKitapListele";
            this.btnEKitapListele.Size = new System.Drawing.Size(149, 46);
            this.btnEKitapListele.TabIndex = 1;
            this.btnEKitapListele.Text = "Emanet Kitap Listeme";
            this.btnEKitapListele.UseVisualStyleBackColor = true;
            this.btnEKitapListele.Click += new System.EventHandler(this.btnEKitapListele_Click);
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.ForeColor = System.Drawing.Color.Maroon;
            this.btnUyeListele.Location = new System.Drawing.Point(25, 84);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(149, 46);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listele";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.ForeColor = System.Drawing.Color.Maroon;
            this.btnKitapEkle.Location = new System.Drawing.Point(25, 177);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(149, 43);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._124383;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 653);
            this.panel2.TabIndex = 22;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEKitapİade;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnEKitapListele;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEkitapVer;
        private System.Windows.Forms.Button btnRezKitapVer;
        private System.Windows.Forms.Button btnRezerveEt;
    }
}