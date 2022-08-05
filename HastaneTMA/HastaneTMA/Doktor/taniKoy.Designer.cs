namespace HastaneTMA.Doktor
{
    partial class taniKoy
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
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.txtBox_Tani = new System.Windows.Forms.TextBox();
            this.btn_TaniKoy = new System.Windows.Forms.Button();
            this.btn_Iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AdSoyad.Location = new System.Drawing.Point(67, 50);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(59, 20);
            this.lbl_AdSoyad.TabIndex = 1;
            this.lbl_AdSoyad.Text = "label2";
            // 
            // txtBox_Tani
            // 
            this.txtBox_Tani.Location = new System.Drawing.Point(71, 89);
            this.txtBox_Tani.Multiline = true;
            this.txtBox_Tani.Name = "txtBox_Tani";
            this.txtBox_Tani.Size = new System.Drawing.Size(450, 234);
            this.txtBox_Tani.TabIndex = 2;
            // 
            // btn_TaniKoy
            // 
            this.btn_TaniKoy.Location = new System.Drawing.Point(71, 352);
            this.btn_TaniKoy.Name = "btn_TaniKoy";
            this.btn_TaniKoy.Size = new System.Drawing.Size(131, 44);
            this.btn_TaniKoy.TabIndex = 3;
            this.btn_TaniKoy.Text = "Tanı Koy";
            this.btn_TaniKoy.UseVisualStyleBackColor = true;
            this.btn_TaniKoy.Click += new System.EventHandler(this.btn_TaniKoy_Click);
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Location = new System.Drawing.Point(233, 352);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(131, 44);
            this.btn_Iptal.TabIndex = 4;
            this.btn_Iptal.Text = "İptal";
            this.btn_Iptal.UseVisualStyleBackColor = true;
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // taniKoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 434);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_TaniKoy);
            this.Controls.Add(this.txtBox_Tani);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Name = "taniKoy";
            this.Text = "Tanı Koyma Ekranı";
            this.Load += new System.EventHandler(this.TaniKoy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.TextBox txtBox_Tani;
        private System.Windows.Forms.Button btn_TaniKoy;
        private System.Windows.Forms.Button btn_Iptal;
    }
}