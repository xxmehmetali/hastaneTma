using HastaneTMA.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneTMA.Sekreter
{
    public partial class randevuSil : Form
    {
        private string TCNo;
        private Model1 TMA_DBContext;
        List<Appointment> randevular;
        public randevuSil()
        {
            InitializeComponent();
        }

        private void txtBox_HastaTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void randevuSil_Load(object sender, EventArgs e)
        {

        }

        private void btn_RandevuSil_Click(object sender, EventArgs e)
        {
            string RandevuSaati = lstBox_Randevular.SelectedItem.ToString();

            using (TMA_DBContext = new Model1())
            {
                try
                {
                    var tarih = Convert.ToDateTime(lstBox_Randevular.SelectedItem.ToString());
                    var kaldir = TMA_DBContext.Appointments.Where(a => a.TCNo == TCNo && a.RandevuSaati == tarih).FirstOrDefault();
                    TMA_DBContext.Appointments.Remove(kaldir);
                    TMA_DBContext.SaveChanges();
                    MessageBox.Show("Randevu Başarıyla Silindi!");
                    txtBox_HastaTC.Clear();
                    lstBox_Randevular.Items.Clear();
                }
                catch
                {
                    MessageBox.Show("Bir sorunla karşılaşıldı.");
                }
            }
        }

        private void btn_RandevulariListele_Click(object sender, EventArgs e)
        {
            lstBox_Randevular.Items.Clear();
            TCNo = txtBox_HastaTC.Text;
            using (TMA_DBContext = new Model1())
            {
                try
                {
                    randevular = TMA_DBContext.Appointments.Where(a => a.TCNo == TCNo).ToList();
                    foreach (var item in randevular)
                        lstBox_Randevular.Items.Add(item.RandevuSaati);

                    var AdSoyad = TMA_DBContext.Patients.Where(p => p.TCNo == TCNo).FirstOrDefault();
                    lbl_HastaAdSoyad.Text = AdSoyad.Ad.Trim() + " " + AdSoyad.Soyad.Trim() + "\niçin alınmış randevular :";

                }
                catch
                {
                    MessageBox.Show("Bir sorunla karşılaşıldı!");
                }
            }

        }
    }
}
