using HastaneTMA.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using HastaneTMA.Doktor;

namespace HastaneTMA
{
    /*
                 1-SEKRETER
                 2-DOKTOR
                 3-YÖNETİCİ
     
     */

    public partial class girisEkrani : Form
    {
        private Model1 TMA_DBContext;


        public girisEkrani()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {






            using (TMA_DBContext = new Model1()) {
                DateTime today = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                DateTime hour = new DateTime(today.Year, today.Month, today.Day, 09, 00, 00);
                var Doctors = TMA_DBContext.Doctors.ToList();

                // --- DOKTOR SAYISI
                for (int k = 0; k < TMA_DBContext.Doctors.Count(); k++)
                {
                    // --- GÜN
                    for (int j = 0; j < 7; j++)
                    {
                        // --- SAATLER
                        for (int i = 0; i < 10; i++)
                        {
                            AppointmentHour appointmentHour = new AppointmentHour();
                            appointmentHour.Hour = hour;
                            appointmentHour.Status = false;
                            appointmentHour.HastaTC = null;

                            var oneRow = Doctors.OrderBy(x => x.ID).Skip(k).Take(1).ToList();
                            appointmentHour.DoktorID =oneRow.FirstOrDefault(r=>r.ID==r.ID).DoktorID;

                            var check = TMA_DBContext.AppointmentHours.Any(ah => ah.Hour == appointmentHour.Hour && ah.DoktorID==appointmentHour.DoktorID);

                            if (check == false)
                            {
                                TMA_DBContext.AppointmentHours.Add(appointmentHour);
                                TMA_DBContext.SaveChanges();
                            }
                            hour = hour.AddHours(1);
                        }
                        today = today.AddDays(1);
                        hour = new DateTime(today.Year, today.Month, today.Day, 09, 00, 00);
                    }
                    today= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    hour = new DateTime(today.Year, today.Month, today.Day, 09, 00, 00);
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            using (TMA_DBContext = new Model1())
            {

                string KullaniciAdi = txtBox_KullaniciAdi.Text;
                string Sifre = txtBox_Sifre.Text;


                var user = TMA_DBContext.Users.FirstOrDefault(u => u.KullaniciAdi == KullaniciAdi);
                if (user != null)
                {
                    if (user.Sifre.ToString().Trim(' ') == Sifre)
                    {
                        switch (user.RolNo)
                        {
                            // --- SEKRETER
                            case 1:
                                sekreterinEkrani sekreterinEkrani = new sekreterinEkrani(user.CalisanNo);
                                this.Hide();
                                sekreterinEkrani.Show();
                                break;

                            // --- DOKTOR
                            case 2:
                                doktorunEkrani doktorunEkrani = new doktorunEkrani(user.CalisanNo);
                                this.Hide();
                                doktorunEkrani.Show();
                                break;

                            // --- Yönetici
                            case 3:
                                yoneticininEkrani yoneticininEkrani=new yoneticininEkrani(user.CalisanNo);
                                this.Hide();
                                yoneticininEkrani.Show();
                                break;
                        };
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş!");
                    }
                }
                else
                    MessageBox.Show("Kullanıcı Bulunamadı!");
            }


        }
    }
}
