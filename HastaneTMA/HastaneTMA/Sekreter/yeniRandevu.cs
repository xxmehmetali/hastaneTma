using HastaneTMA.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using HastaneTMA.Model;

namespace HastaneTMA
{
    public partial class yeniRandevu : Form
    {
        private Model1 TMA_DBContext;
        public yeniRandevu()
        {
            InitializeComponent();

            TMA_DBContext = new Model1();
            var Clinics = TMA_DBContext.Clinics.ToList();
            foreach (Clinic Clinic in Clinics)
            {
                cbo_Klinik.Items.Add(Clinic.KlinikAdi);
            }

        }

        private void yeniRandevu_Load(object sender, EventArgs e)
        {




        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBox_UygunTarihler.Items.Clear();

            //aşağıdaki doktor ID verir
            int dxSelected = dx[cbo_Doktor.SelectedIndex];


            var uygunTarihler = TMA_DBContext.AppointmentHours.Where(u => u.DoktorID==dxSelected && u.Status==false).ToList();
            

            for (int k = 0; k < uygunTarihler.Count; k++)
            {
                var oneRow = uygunTarihler.Skip(k).Take(1).ToList();
                if(oneRow.FirstOrDefault().Hour>=DateTime.Now.AddDays(-1))
                    lstBox_UygunTarihler.Items.Add(oneRow.FirstOrDefault().Hour);
            }


            

        }


        int[] dx;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbo_Doktor.Items.Clear();

            //https://hexacodein.com/makale/linq-include-kullanimi

            var Doctors = TMA_DBContext.Doctors.Include("Employee").Where(d => d.KlinikID == cbo_Klinik.SelectedIndex + 1).ToList();
            int boyut = Doctors.Count();


            int i = 0;
            dx=new int[boyut];
            foreach (var d in Doctors)
            {
                cbo_Doktor.Items.Add(d.Employee.Ad.Trim(' ') + " " + d.Employee.Soyad.Trim(' '));

                dx[i] = d.DoktorID;
                i++;
            }


        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBox_UygunTarihler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            



        }

        private void btn_RandevuOlustur_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtBox_TC.Text) && cbo_Klinik.SelectedItem != null && cbo_Doktor.SelectedItem != null && lstBox_UygunTarihler.SelectedItem != null)
            {
                Appointment appointment = new Appointment();
                appointment.TCNo = txtBox_TC.Text.ToString();
                appointment.DoktorID = dx[cbo_Doktor.SelectedIndex];
                appointment.KlinikID = cbo_Klinik.SelectedIndex + 1;
                appointment.RandevuSaati = Convert.ToDateTime(lstBox_UygunTarihler.SelectedItem.ToString());

                var oneRow = TMA_DBContext.AppointmentHours.Where(h => h.Hour == appointment.RandevuSaati && h.DoktorID == appointment.DoktorID).ToList().FirstOrDefault();
                oneRow.Status = true;
                oneRow.HastaTC = appointment.TCNo;
                oneRow.DoktorID = appointment.DoktorID;

                // TRY CATCH KULLAN HATA ALIRSA İLK ÖNCE HASTAYI SİSTEME KAYIT ETMEMİZ GEREK
                TMA_DBContext.Appointments.Add(appointment);
                TMA_DBContext.SaveChanges();
                MessageBox.Show("Randevu başarı ile oluşturuldu.");

            }
            else
                MessageBox.Show("Lütfen boş alan bırakmayınız.");

        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
