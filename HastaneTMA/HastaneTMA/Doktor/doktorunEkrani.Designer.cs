namespace HastaneTMA.Doktor
{
    partial class doktorunEkrani
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
            this.lbl_Karsilama = new System.Windows.Forms.Label();
            this.dgv_Diagnostic = new System.Windows.Forms.DataGridView();
            this.HastaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaYasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaneTMADataSetDiagnostic = new HastaneTMA.HastaneTMADataSetDiagnostic();
            this.diagnosticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticTableAdapter = new HastaneTMA.HastaneTMADataSetDiagnosticTableAdapters.DiagnosticTableAdapter();
            this.btn_TaniKoy = new System.Windows.Forms.Button();
            this.btn_KonulanTanilariGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diagnostic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetDiagnostic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Karsilama
            // 
            this.lbl_Karsilama.AutoSize = true;
            this.lbl_Karsilama.Location = new System.Drawing.Point(31, 21);
            this.lbl_Karsilama.Name = "lbl_Karsilama";
            this.lbl_Karsilama.Size = new System.Drawing.Size(44, 16);
            this.lbl_Karsilama.TabIndex = 2;
            this.lbl_Karsilama.Text = "label1";
            this.lbl_Karsilama.Click += new System.EventHandler(this.lbl_Karsilama_Click);
            // 
            // dgv_Diagnostic
            // 
            this.dgv_Diagnostic.AllowUserToAddRows = false;
            this.dgv_Diagnostic.AllowUserToDeleteRows = false;
            this.dgv_Diagnostic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Diagnostic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Diagnostic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Diagnostic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HastaTC,
            this.HastaAdi,
            this.HastaSoyadi,
            this.HastaYasi,
            this.RandevuSaati});
            this.dgv_Diagnostic.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Diagnostic.Location = new System.Drawing.Point(34, 60);
            this.dgv_Diagnostic.MultiSelect = false;
            this.dgv_Diagnostic.Name = "dgv_Diagnostic";
            this.dgv_Diagnostic.ReadOnly = true;
            this.dgv_Diagnostic.RowHeadersWidth = 51;
            this.dgv_Diagnostic.RowTemplate.Height = 24;
            this.dgv_Diagnostic.Size = new System.Drawing.Size(901, 247);
            this.dgv_Diagnostic.TabIndex = 3;
            this.dgv_Diagnostic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Diagnostic_CellContentClick);
            // 
            // HastaTC
            // 
            this.HastaTC.HeaderText = "HastaTC";
            this.HastaTC.MinimumWidth = 6;
            this.HastaTC.Name = "HastaTC";
            this.HastaTC.ReadOnly = true;
            // 
            // HastaAdi
            // 
            this.HastaAdi.HeaderText = "HastaAdi";
            this.HastaAdi.MinimumWidth = 6;
            this.HastaAdi.Name = "HastaAdi";
            this.HastaAdi.ReadOnly = true;
            // 
            // HastaSoyadi
            // 
            this.HastaSoyadi.HeaderText = "HastaSoyadi";
            this.HastaSoyadi.MinimumWidth = 6;
            this.HastaSoyadi.Name = "HastaSoyadi";
            this.HastaSoyadi.ReadOnly = true;
            // 
            // HastaYasi
            // 
            this.HastaYasi.HeaderText = "HastaYasi";
            this.HastaYasi.MinimumWidth = 6;
            this.HastaYasi.Name = "HastaYasi";
            this.HastaYasi.ReadOnly = true;
            // 
            // RandevuSaati
            // 
            this.RandevuSaati.HeaderText = "RandevuSaati";
            this.RandevuSaati.MinimumWidth = 6;
            this.RandevuSaati.Name = "RandevuSaati";
            this.RandevuSaati.ReadOnly = true;
            // 
            // hastaneTMADataSetDiagnostic
            // 
            this.hastaneTMADataSetDiagnostic.DataSetName = "HastaneTMADataSetDiagnostic";
            this.hastaneTMADataSetDiagnostic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosticBindingSource
            // 
            this.diagnosticBindingSource.DataMember = "Diagnostic";
            this.diagnosticBindingSource.DataSource = this.hastaneTMADataSetDiagnostic;
            // 
            // diagnosticTableAdapter
            // 
            this.diagnosticTableAdapter.ClearBeforeFill = true;
            // 
            // btn_TaniKoy
            // 
            this.btn_TaniKoy.Location = new System.Drawing.Point(34, 327);
            this.btn_TaniKoy.Name = "btn_TaniKoy";
            this.btn_TaniKoy.Size = new System.Drawing.Size(151, 51);
            this.btn_TaniKoy.TabIndex = 4;
            this.btn_TaniKoy.Text = "Tanı Koy";
            this.btn_TaniKoy.UseVisualStyleBackColor = true;
            this.btn_TaniKoy.Click += new System.EventHandler(this.btn_TaniKoy_Click);
            // 
            // btn_KonulanTanilariGoster
            // 
            this.btn_KonulanTanilariGoster.Location = new System.Drawing.Point(216, 327);
            this.btn_KonulanTanilariGoster.Name = "btn_KonulanTanilariGoster";
            this.btn_KonulanTanilariGoster.Size = new System.Drawing.Size(151, 51);
            this.btn_KonulanTanilariGoster.TabIndex = 5;
            this.btn_KonulanTanilariGoster.Text = "Konulan Tanıları Göster";
            this.btn_KonulanTanilariGoster.UseVisualStyleBackColor = true;
            this.btn_KonulanTanilariGoster.Click += new System.EventHandler(this.btn_KonulanTanilariGoster_Click);
            // 
            // doktorunEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(977, 392);
            this.Controls.Add(this.btn_KonulanTanilariGoster);
            this.Controls.Add(this.btn_TaniKoy);
            this.Controls.Add(this.dgv_Diagnostic);
            this.Controls.Add(this.lbl_Karsilama);
            this.MaximumSize = new System.Drawing.Size(995, 439);
            this.MinimumSize = new System.Drawing.Size(995, 439);
            this.Name = "doktorunEkrani";
            this.Text = "Doktor Arayüzü";
            this.Load += new System.EventHandler(this.doktorunEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diagnostic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetDiagnostic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Karsilama;
        private System.Windows.Forms.DataGridView dgv_Diagnostic;
        private HastaneTMADataSetDiagnostic hastaneTMADataSetDiagnostic;
        private System.Windows.Forms.BindingSource diagnosticBindingSource;
        private HastaneTMADataSetDiagnosticTableAdapters.DiagnosticTableAdapter diagnosticTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaYasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuSaati;
        private System.Windows.Forms.Button btn_TaniKoy;
        private System.Windows.Forms.Button btn_KonulanTanilariGoster;
    }
}