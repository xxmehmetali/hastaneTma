namespace HastaneTMA
{
    partial class yeniRandevu
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
            this.grpBox_RandevuOlustur = new System.Windows.Forms.GroupBox();
            this.lstBox_UygunTarihler = new System.Windows.Forms.ListBox();
            this.cbo_Doktor = new System.Windows.Forms.ComboBox();
            this.cbo_Klinik = new System.Windows.Forms.ComboBox();
            this.txtBox_TC = new System.Windows.Forms.TextBox();
            this.lbl_UygunTarihler = new System.Windows.Forms.Label();
            this.lbl_Doktor = new System.Windows.Forms.Label();
            this.lbl_Klinik = new System.Windows.Forms.Label();
            this.lbl_HastaTC = new System.Windows.Forms.Label();
            this.btn_RandevuOlustur = new System.Windows.Forms.Button();
            this.btn_Iptal = new System.Windows.Forms.Button();
            this.grpBox_RandevuOlustur.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_RandevuOlustur
            // 
            this.grpBox_RandevuOlustur.Controls.Add(this.lstBox_UygunTarihler);
            this.grpBox_RandevuOlustur.Controls.Add(this.cbo_Doktor);
            this.grpBox_RandevuOlustur.Controls.Add(this.cbo_Klinik);
            this.grpBox_RandevuOlustur.Controls.Add(this.txtBox_TC);
            this.grpBox_RandevuOlustur.Controls.Add(this.lbl_UygunTarihler);
            this.grpBox_RandevuOlustur.Controls.Add(this.lbl_Doktor);
            this.grpBox_RandevuOlustur.Controls.Add(this.lbl_Klinik);
            this.grpBox_RandevuOlustur.Controls.Add(this.lbl_HastaTC);
            this.grpBox_RandevuOlustur.Location = new System.Drawing.Point(47, 34);
            this.grpBox_RandevuOlustur.Name = "grpBox_RandevuOlustur";
            this.grpBox_RandevuOlustur.Size = new System.Drawing.Size(441, 459);
            this.grpBox_RandevuOlustur.TabIndex = 0;
            this.grpBox_RandevuOlustur.TabStop = false;
            this.grpBox_RandevuOlustur.Text = "Randevu Oluştur";
            // 
            // lstBox_UygunTarihler
            // 
            this.lstBox_UygunTarihler.FormattingEnabled = true;
            this.lstBox_UygunTarihler.ItemHeight = 16;
            this.lstBox_UygunTarihler.Location = new System.Drawing.Point(150, 246);
            this.lstBox_UygunTarihler.Name = "lstBox_UygunTarihler";
            this.lstBox_UygunTarihler.Size = new System.Drawing.Size(212, 180);
            this.lstBox_UygunTarihler.TabIndex = 9;
            this.lstBox_UygunTarihler.SelectedIndexChanged += new System.EventHandler(this.lstBox_UygunTarihler_SelectedIndexChanged);
            // 
            // cbo_Doktor
            // 
            this.cbo_Doktor.FormattingEnabled = true;
            this.cbo_Doktor.Location = new System.Drawing.Point(150, 185);
            this.cbo_Doktor.Name = "cbo_Doktor";
            this.cbo_Doktor.Size = new System.Drawing.Size(212, 24);
            this.cbo_Doktor.TabIndex = 8;
            this.cbo_Doktor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbo_Klinik
            // 
            this.cbo_Klinik.FormattingEnabled = true;
            this.cbo_Klinik.Location = new System.Drawing.Point(150, 124);
            this.cbo_Klinik.Name = "cbo_Klinik";
            this.cbo_Klinik.Size = new System.Drawing.Size(212, 24);
            this.cbo_Klinik.TabIndex = 7;
            this.cbo_Klinik.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBox_TC
            // 
            this.txtBox_TC.Location = new System.Drawing.Point(150, 62);
            this.txtBox_TC.MaxLength = 11;
            this.txtBox_TC.Name = "txtBox_TC";
            this.txtBox_TC.Size = new System.Drawing.Size(212, 22);
            this.txtBox_TC.TabIndex = 6;
            // 
            // lbl_UygunTarihler
            // 
            this.lbl_UygunTarihler.AutoSize = true;
            this.lbl_UygunTarihler.Location = new System.Drawing.Point(34, 246);
            this.lbl_UygunTarihler.Name = "lbl_UygunTarihler";
            this.lbl_UygunTarihler.Size = new System.Drawing.Size(101, 16);
            this.lbl_UygunTarihler.TabIndex = 3;
            this.lbl_UygunTarihler.Text = "Uygun Tarihler :";
            // 
            // lbl_Doktor
            // 
            this.lbl_Doktor.AutoSize = true;
            this.lbl_Doktor.Location = new System.Drawing.Point(34, 185);
            this.lbl_Doktor.Name = "lbl_Doktor";
            this.lbl_Doktor.Size = new System.Drawing.Size(53, 16);
            this.lbl_Doktor.TabIndex = 2;
            this.lbl_Doktor.Text = "Doktor :";
            // 
            // lbl_Klinik
            // 
            this.lbl_Klinik.AutoSize = true;
            this.lbl_Klinik.Location = new System.Drawing.Point(34, 124);
            this.lbl_Klinik.Name = "lbl_Klinik";
            this.lbl_Klinik.Size = new System.Drawing.Size(38, 16);
            this.lbl_Klinik.TabIndex = 1;
            this.lbl_Klinik.Text = "Klinik";
            // 
            // lbl_HastaTC
            // 
            this.lbl_HastaTC.AutoSize = true;
            this.lbl_HastaTC.Location = new System.Drawing.Point(34, 62);
            this.lbl_HastaTC.Name = "lbl_HastaTC";
            this.lbl_HastaTC.Size = new System.Drawing.Size(70, 16);
            this.lbl_HastaTC.TabIndex = 0;
            this.lbl_HastaTC.Text = "Hasta TC :";
            // 
            // btn_RandevuOlustur
            // 
            this.btn_RandevuOlustur.Location = new System.Drawing.Point(47, 526);
            this.btn_RandevuOlustur.Name = "btn_RandevuOlustur";
            this.btn_RandevuOlustur.Size = new System.Drawing.Size(185, 49);
            this.btn_RandevuOlustur.TabIndex = 3;
            this.btn_RandevuOlustur.Text = "Randevu Oluştur";
            this.btn_RandevuOlustur.UseVisualStyleBackColor = true;
            this.btn_RandevuOlustur.Click += new System.EventHandler(this.btn_RandevuOlustur_Click);
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Location = new System.Drawing.Point(303, 526);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(185, 49);
            this.btn_Iptal.TabIndex = 4;
            this.btn_Iptal.Text = "İptal";
            this.btn_Iptal.UseVisualStyleBackColor = true;
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // yeniRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 607);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_RandevuOlustur);
            this.Controls.Add(this.grpBox_RandevuOlustur);
            this.Name = "yeniRandevu";
            this.Text = "Yeni Randevu";
            this.Load += new System.EventHandler(this.yeniRandevu_Load);
            this.grpBox_RandevuOlustur.ResumeLayout(false);
            this.grpBox_RandevuOlustur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_RandevuOlustur;
        private System.Windows.Forms.Label lbl_UygunTarihler;
        private System.Windows.Forms.Label lbl_Doktor;
        private System.Windows.Forms.Label lbl_Klinik;
        private System.Windows.Forms.Label lbl_HastaTC;
        private System.Windows.Forms.ListBox lstBox_UygunTarihler;
        private System.Windows.Forms.ComboBox cbo_Doktor;
        private System.Windows.Forms.ComboBox cbo_Klinik;
        private System.Windows.Forms.TextBox txtBox_TC;
        private System.Windows.Forms.Button btn_RandevuOlustur;
        private System.Windows.Forms.Button btn_Iptal;
    }
}