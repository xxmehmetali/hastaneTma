namespace HastaneTMA.Sekreter
{
    partial class randevuSil
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
            this.txtBox_HastaTC = new System.Windows.Forms.TextBox();
            this.btn_RandevuSil = new System.Windows.Forms.Button();
            this.lbl_TCNo = new System.Windows.Forms.Label();
            this.lstBox_Randevular = new System.Windows.Forms.ListBox();
            this.btn_RandevulariListele = new System.Windows.Forms.Button();
            this.lbl_HastaAdSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_HastaTC
            // 
            this.txtBox_HastaTC.Location = new System.Drawing.Point(123, 40);
            this.txtBox_HastaTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_HastaTC.Name = "txtBox_HastaTC";
            this.txtBox_HastaTC.Size = new System.Drawing.Size(191, 22);
            this.txtBox_HastaTC.TabIndex = 5;
            this.txtBox_HastaTC.TextChanged += new System.EventHandler(this.txtBox_HastaTC_TextChanged);
            // 
            // btn_RandevuSil
            // 
            this.btn_RandevuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RandevuSil.Location = new System.Drawing.Point(51, 349);
            this.btn_RandevuSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RandevuSil.Name = "btn_RandevuSil";
            this.btn_RandevuSil.Size = new System.Drawing.Size(263, 43);
            this.btn_RandevuSil.TabIndex = 4;
            this.btn_RandevuSil.Text = "Randevuyu Sil";
            this.btn_RandevuSil.UseVisualStyleBackColor = true;
            this.btn_RandevuSil.Click += new System.EventHandler(this.btn_RandevuSil_Click);
            // 
            // lbl_TCNo
            // 
            this.lbl_TCNo.AutoSize = true;
            this.lbl_TCNo.Location = new System.Drawing.Point(48, 43);
            this.lbl_TCNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TCNo.Name = "lbl_TCNo";
            this.lbl_TCNo.Size = new System.Drawing.Size(52, 16);
            this.lbl_TCNo.TabIndex = 3;
            this.lbl_TCNo.Text = "TC No :";
            // 
            // lstBox_Randevular
            // 
            this.lstBox_Randevular.FormattingEnabled = true;
            this.lstBox_Randevular.ItemHeight = 16;
            this.lstBox_Randevular.Location = new System.Drawing.Point(51, 197);
            this.lstBox_Randevular.Name = "lstBox_Randevular";
            this.lstBox_Randevular.Size = new System.Drawing.Size(263, 132);
            this.lstBox_Randevular.TabIndex = 6;
            // 
            // btn_RandevulariListele
            // 
            this.btn_RandevulariListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RandevulariListele.Location = new System.Drawing.Point(51, 88);
            this.btn_RandevulariListele.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RandevulariListele.Name = "btn_RandevulariListele";
            this.btn_RandevulariListele.Size = new System.Drawing.Size(263, 43);
            this.btn_RandevulariListele.TabIndex = 7;
            this.btn_RandevulariListele.Text = "Randevuları Listele";
            this.btn_RandevulariListele.UseVisualStyleBackColor = true;
            this.btn_RandevulariListele.Click += new System.EventHandler(this.btn_RandevulariListele_Click);
            // 
            // lbl_HastaAdSoyad
            // 
            this.lbl_HastaAdSoyad.AutoSize = true;
            this.lbl_HastaAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HastaAdSoyad.Location = new System.Drawing.Point(47, 156);
            this.lbl_HastaAdSoyad.Name = "lbl_HastaAdSoyad";
            this.lbl_HastaAdSoyad.Size = new System.Drawing.Size(0, 18);
            this.lbl_HastaAdSoyad.TabIndex = 8;
            // 
            // randevuSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 417);
            this.Controls.Add(this.lbl_HastaAdSoyad);
            this.Controls.Add(this.btn_RandevulariListele);
            this.Controls.Add(this.lstBox_Randevular);
            this.Controls.Add(this.txtBox_HastaTC);
            this.Controls.Add(this.btn_RandevuSil);
            this.Controls.Add(this.lbl_TCNo);
            this.Name = "randevuSil";
            this.Text = "Randevu Sil";
            this.Load += new System.EventHandler(this.randevuSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_HastaTC;
        private System.Windows.Forms.Button btn_RandevuSil;
        private System.Windows.Forms.Label lbl_TCNo;
        private System.Windows.Forms.ListBox lstBox_Randevular;
        private System.Windows.Forms.Button btn_RandevulariListele;
        private System.Windows.Forms.Label lbl_HastaAdSoyad;
    }
}