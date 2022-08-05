namespace HastaneTMA.Yonetici
{
    partial class kullaniciBilgileri
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneTMADataSetUsers2 = new HastaneTMA.HastaneTMADataSetUsers2();
            this.hastaneTMADataSetUsers = new HastaneTMA.HastaneTMADataSetUsers();
            this.hastaneTMADataSetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new HastaneTMA.HastaneTMADataSetUsers2TableAdapters.UsersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calisanNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetUsers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hastaneTMADataSetUsers2;
            // 
            // hastaneTMADataSetUsers2
            // 
            this.hastaneTMADataSetUsers2.DataSetName = "HastaneTMADataSetUsers2";
            this.hastaneTMADataSetUsers2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneTMADataSetUsers
            // 
            this.hastaneTMADataSetUsers.DataSetName = "HastaneTMADataSetUsers";
            this.hastaneTMADataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneTMADataSetUsersBindingSource
            // 
            this.hastaneTMADataSetUsersBindingSource.DataSource = this.hastaneTMADataSetUsers;
            this.hastaneTMADataSetUsersBindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.rolNoDataGridViewTextBoxColumn,
            this.calisanNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calisanNoDataGridViewTextBoxColumn
            // 
            this.calisanNoDataGridViewTextBoxColumn.DataPropertyName = "CalisanNo";
            this.calisanNoDataGridViewTextBoxColumn.HeaderText = "CalisanNo";
            this.calisanNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calisanNoDataGridViewTextBoxColumn.Name = "calisanNoDataGridViewTextBoxColumn";
            this.calisanNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolNoDataGridViewTextBoxColumn
            // 
            this.rolNoDataGridViewTextBoxColumn.DataPropertyName = "RolNo";
            this.rolNoDataGridViewTextBoxColumn.HeaderText = "RolNo";
            this.rolNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolNoDataGridViewTextBoxColumn.Name = "rolNoDataGridViewTextBoxColumn";
            this.rolNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 451);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(834, 498);
            this.MinimumSize = new System.Drawing.Size(834, 498);
            this.Name = "kullaniciBilgileri";
            this.Text = "Kullanıcı Bilgileri";
            this.Load += new System.EventHandler(this.kullaniciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetUsers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneTMADataSetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hastaneTMADataSetUsersBindingSource;
        private HastaneTMADataSetUsers hastaneTMADataSetUsers;
        private HastaneTMADataSetUsers2 hastaneTMADataSetUsers2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HastaneTMADataSetUsers2TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanNoDataGridViewTextBoxColumn;
    }
}