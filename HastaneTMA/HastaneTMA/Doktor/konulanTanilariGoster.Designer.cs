namespace HastaneTMA.Doktor
{
    partial class konulanTanilariGoster
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
            this.dgv_KonulanTanilar = new System.Windows.Forms.DataGridView();
            this.HastaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaniTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KonulanTanilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KonulanTanilar
            // 
            this.dgv_KonulanTanilar.AllowUserToAddRows = false;
            this.dgv_KonulanTanilar.AllowUserToDeleteRows = false;
            this.dgv_KonulanTanilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KonulanTanilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KonulanTanilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HastaTC,
            this.Tani,
            this.TaniTarihi});
            this.dgv_KonulanTanilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KonulanTanilar.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_KonulanTanilar.Location = new System.Drawing.Point(0, 0);
            this.dgv_KonulanTanilar.MultiSelect = false;
            this.dgv_KonulanTanilar.Name = "dgv_KonulanTanilar";
            this.dgv_KonulanTanilar.ReadOnly = true;
            this.dgv_KonulanTanilar.RowHeadersWidth = 51;
            this.dgv_KonulanTanilar.RowTemplate.Height = 24;
            this.dgv_KonulanTanilar.Size = new System.Drawing.Size(800, 450);
            this.dgv_KonulanTanilar.TabIndex = 0;
            this.dgv_KonulanTanilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KonulanTanilar_CellContentClick);
            // 
            // HastaTC
            // 
            this.HastaTC.HeaderText = "HastaTC";
            this.HastaTC.MinimumWidth = 6;
            this.HastaTC.Name = "HastaTC";
            this.HastaTC.ReadOnly = true;
            // 
            // Tani
            // 
            this.Tani.HeaderText = "Tani";
            this.Tani.MinimumWidth = 6;
            this.Tani.Name = "Tani";
            this.Tani.ReadOnly = true;
            // 
            // TaniTarihi
            // 
            this.TaniTarihi.HeaderText = "TaniTarihi";
            this.TaniTarihi.MinimumWidth = 6;
            this.TaniTarihi.Name = "TaniTarihi";
            this.TaniTarihi.ReadOnly = true;
            // 
            // konulanTanilariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_KonulanTanilar);
            this.Name = "konulanTanilariGoster";
            this.Text = "Tanılar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KonulanTanilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KonulanTanilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tani;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaniTarihi;
    }
}