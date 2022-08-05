
namespace HastaneTMA
{
    partial class girisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkrani));
            this.lbl_TMAHastane = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txtBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBox_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TMAHastane
            // 
            this.lbl_TMAHastane.AutoSize = true;
            this.lbl_TMAHastane.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TMAHastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TMAHastane.Location = new System.Drawing.Point(186, 105);
            this.lbl_TMAHastane.Name = "lbl_TMAHastane";
            this.lbl_TMAHastane.Size = new System.Drawing.Size(606, 91);
            this.lbl_TMAHastane.TabIndex = 0;
            this.lbl_TMAHastane.Text = "TMA HASTANE";
            this.lbl_TMAHastane.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(582, 441);
            this.btn_Giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(132, 49);
            this.btn_Giris.TabIndex = 1;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txtBox_KullaniciAdi
            // 
            this.txtBox_KullaniciAdi.Location = new System.Drawing.Point(511, 287);
            this.txtBox_KullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_KullaniciAdi.MaxLength = 30;
            this.txtBox_KullaniciAdi.Name = "txtBox_KullaniciAdi";
            this.txtBox_KullaniciAdi.Size = new System.Drawing.Size(203, 28);
            this.txtBox_KullaniciAdi.TabIndex = 2;
            // 
            // txtBox_Sifre
            // 
            this.txtBox_Sifre.Location = new System.Drawing.Point(511, 380);
            this.txtBox_Sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Sifre.MaxLength = 30;
            this.txtBox_Sifre.Name = "txtBox_Sifre";
            this.txtBox_Sifre.PasswordChar = '⦿';
            this.txtBox_Sifre.Size = new System.Drawing.Size(203, 22);
            this.txtBox_Sifre.TabIndex = 3;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(257, 280);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(212, 36);
            this.lbl_KullaniciAdi.TabIndex = 4;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sifre.Location = new System.Drawing.Point(257, 366);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(99, 36);
            this.lbl_Sifre.TabIndex = 5;
            this.lbl_Sifre.Text = "Şifre :";
            // 
            // girisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 618);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.txtBox_Sifre);
            this.Controls.Add(this.txtBox_KullaniciAdi);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.lbl_TMAHastane);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(967, 665);
            this.MinimumSize = new System.Drawing.Size(967, 665);
            this.Name = "girisEkrani";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TMAHastane;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txtBox_KullaniciAdi;
        private System.Windows.Forms.TextBox txtBox_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Sifre;
    }
}

