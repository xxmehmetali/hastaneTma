namespace HastaneTMA
{
    partial class hastaSil
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
            this.lbl_TCNo = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txtBox_HastaTC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_TCNo
            // 
            this.lbl_TCNo.AutoSize = true;
            this.lbl_TCNo.Location = new System.Drawing.Point(48, 55);
            this.lbl_TCNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TCNo.Name = "lbl_TCNo";
            this.lbl_TCNo.Size = new System.Drawing.Size(52, 16);
            this.lbl_TCNo.TabIndex = 0;
            this.lbl_TCNo.Text = "TC No :";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(52, 102);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(263, 43);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "Hastayı Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txtBox_HastaTC
            // 
            this.txtBox_HastaTC.Location = new System.Drawing.Point(123, 52);
            this.txtBox_HastaTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_HastaTC.Name = "txtBox_HastaTC";
            this.txtBox_HastaTC.Size = new System.Drawing.Size(191, 22);
            this.txtBox_HastaTC.TabIndex = 2;
            // 
            // hastaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 188);
            this.Controls.Add(this.txtBox_HastaTC);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.lbl_TCNo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "hastaSil";
            this.Text = "Hasta Sil";
            this.Load += new System.EventHandler(this.hastaSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TCNo;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txtBox_HastaTC;
    }
}