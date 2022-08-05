using HastaneTMA.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneTMA.Yonetici
{
    public partial class doktorIliskilendir : Form
    {
        private Model1 TMA_DBContext;
        public doktorIliskilendir()
        {
            InitializeComponent();
        }

        private void doktorIliskilendir_Load(object sender, EventArgs e)
        {
            this.clinicsTableAdapter.Fill(this.hastaneTMADataSet3.Clinics);

            using (TMA_DBContext = new Model1())
            {
                
                var calisanIDsFromUsers=TMA_DBContext.Users.Where(u => u.RolNo == 2).ToList();
                
                List<Employee> employees=new List<Employee> ();
                foreach (var item in calisanIDsFromUsers)
                {
                    dgv_DoktorListesi.Rows.Add(item.Employee.ID, item.Employee.Ad, item.Employee.Soyad);
                }
            }
        }

        private void dgv_DoktorListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Iliskilendir_Click(object sender, EventArgs e)
        {
            using (TMA_DBContext = new Model1())
            {
                try
                {
                    int DoctorID = int.Parse(dgv_DoktorListesi.CurrentRow.Cells[0].Value.ToString());
                    int KlinikID = int.Parse(dgv_KlinikListesi.CurrentRow.Cells[0].Value.ToString());

                    Doctor doctor = new Doctor();
                    doctor.DoktorID = DoctorID;
                    doctor.KlinikID = KlinikID;

                    TMA_DBContext.Doctors.Add(doctor);
                    TMA_DBContext.SaveChanges();
                    MessageBox.Show("Başarı ile kaydedildi!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı!\n" + ex.ToString());
                }
            }
        }
    }
}
