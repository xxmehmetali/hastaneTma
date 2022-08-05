namespace HastaneTMA.Yonetici
{
    partial class doktorIliskilendir
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DoktorListesi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Iliskilendir = new System.Windows.Forms.Button();
            this.dgv_KlinikListesi = new System.Windows.Forms.DataGridView();
            this.hastaneTMAClinics = new HastaneTMA.HastaneTMAClinics();
            this.hastaneTMAClinicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneTMADataSet3 = new HastaneTMA.HastaneTMADataSet3();
            this.clinicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicsTableAdapter = new HastaneTMA.HastaneTMADataSet3TableAdapters.ClinicsTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klinikAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalisanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoktorListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KlinikListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMAClinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMAClinicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlişkilendirilecek Doktor:";
            // 
            // dgv_DoktorListesi
            // 
            this.dgv_DoktorListesi.AllowUserToAddRows = false;
            this.dgv_DoktorListesi.AllowUserToDeleteRows = false;
            this.dgv_DoktorListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DoktorListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoktorListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalisanNo,
            this.Ad,
            this.Soyad});
            this.dgv_DoktorListesi.Location = new System.Drawing.Point(45, 66);
            this.dgv_DoktorListesi.MultiSelect = false;
            this.dgv_DoktorListesi.Name = "dgv_DoktorListesi";
            this.dgv_DoktorListesi.ReadOnly = true;
            this.dgv_DoktorListesi.RowHeadersWidth = 51;
            this.dgv_DoktorListesi.RowTemplate.Height = 24;
            this.dgv_DoktorListesi.Size = new System.Drawing.Size(470, 177);
            this.dgv_DoktorListesi.TabIndex = 2;
            this.dgv_DoktorListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DoktorListesi_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlişkilendirilecek Klinik:";
            // 
            // btn_Iliskilendir
            // 
            this.btn_Iliskilendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Iliskilendir.Location = new System.Drawing.Point(296, 504);
            this.btn_Iliskilendir.Name = "btn_Iliskilendir";
            this.btn_Iliskilendir.Size = new System.Drawing.Size(219, 55);
            this.btn_Iliskilendir.TabIndex = 5;
            this.btn_Iliskilendir.Text = "Doktor ve Kliniği İlişkilendir";
            this.btn_Iliskilendir.UseVisualStyleBackColor = true;
            this.btn_Iliskilendir.Click += new System.EventHandler(this.btn_Iliskilendir_Click);
            // 
            // dgv_KlinikListesi
            // 
            this.dgv_KlinikListesi.AllowUserToAddRows = false;
            this.dgv_KlinikListesi.AllowUserToDeleteRows = false;
            this.dgv_KlinikListesi.AutoGenerateColumns = false;
            this.dgv_KlinikListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KlinikListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KlinikListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.klinikAdiDataGridViewTextBoxColumn});
            this.dgv_KlinikListesi.DataSource = this.clinicsBindingSource;
            this.dgv_KlinikListesi.Location = new System.Drawing.Point(45, 302);
            this.dgv_KlinikListesi.MultiSelect = false;
            this.dgv_KlinikListesi.Name = "dgv_KlinikListesi";
            this.dgv_KlinikListesi.ReadOnly = true;
            this.dgv_KlinikListesi.RowHeadersWidth = 51;
            this.dgv_KlinikListesi.RowTemplate.Height = 24;
            this.dgv_KlinikListesi.Size = new System.Drawing.Size(470, 177);
            this.dgv_KlinikListesi.TabIndex = 6;
            // 
            // hastaneTMAClinics
            // 
            this.hastaneTMAClinics.DataSetName = "HastaneTMAClinics";
            this.hastaneTMAClinics.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneTMAClinicsBindingSource
            // 
            this.hastaneTMAClinicsBindingSource.DataSource = this.hastaneTMAClinics;
            this.hastaneTMAClinicsBindingSource.Position = 0;
            // 
            // hastaneTMADataSet3
            // 
            this.hastaneTMADataSet3.DataSetName = "HastaneTMADataSet3";
            this.hastaneTMADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicsBindingSource
            // 
            this.clinicsBindingSource.DataMember = "Clinics";
            this.clinicsBindingSource.DataSource = this.hastaneTMADataSet3;
            // 
            // clinicsTableAdapter
            // 
            this.clinicsTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // klinikAdiDataGridViewTextBoxColumn
            // 
            this.klinikAdiDataGridViewTextBoxColumn.DataPropertyName = "KlinikAdi";
            this.klinikAdiDataGridViewTextBoxColumn.HeaderText = "KlinikAdi";
            this.klinikAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.klinikAdiDataGridViewTextBoxColumn.Name = "klinikAdiDataGridViewTextBoxColumn";
            this.klinikAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CalisanNo
            // 
            this.CalisanNo.HeaderText = "CalisanNo";
            this.CalisanNo.MinimumWidth = 6;
            this.CalisanNo.Name = "CalisanNo";
            this.CalisanNo.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            // 
            // doktorIliskilendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 610);
            this.Controls.Add(this.dgv_KlinikListesi);
            this.Controls.Add(this.btn_Iliskilendir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_DoktorListesi);
            this.Controls.Add(this.label1);
            this.Name = "doktorIliskilendir";
            this.Text = "Doktor İlişkilendir";
            this.Load += new System.EventHandler(this.doktorIliskilendir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoktorListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KlinikListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMAClinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMAClinicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DoktorListesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Iliskilendir;
        private System.Windows.Forms.DataGridView dgv_KlinikListesi;
        private System.Windows.Forms.BindingSource hastaneTMAClinicsBindingSource;
        private HastaneTMAClinics hastaneTMAClinics;
        private HastaneTMADataSet3 hastaneTMADataSet3;
        private System.Windows.Forms.BindingSource clinicsBindingSource;
        private HastaneTMADataSet3TableAdapters.ClinicsTableAdapter clinicsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klinikAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalisanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
    }
}