using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneTMA.Model;


namespace HastaneTMA
{
    public partial class hastaEkle : Form
    {
        public hastaEkle()
        {
            InitializeComponent();
            
        }

        private void hastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btn_YeniHastaEkle_Click(object sender, EventArgs e)
        {
            Model1 TMA_DBContext = new Model1();
            // --- HASTA BİLGİLERİ
            string TCNo = txtBox_TC.Text;
            string Ad=txtBox_Ad.Text;
            string Soyad=txtBox_Soyad.Text;
            bool Cinsiyet;
            if (rdBtn_CinsiyetErkek.Checked)
                Cinsiyet = false;
            else
                Cinsiyet=true;
            string yas = dateTime_Yas.Value.ToString("yyyy");

            // --- ADRES
            string Ilce=txtBox_Ilce.Text;
            string Adres=txtBox_Adres.Text;
            string PostaKodu = txtBox_PostaKodu.Text;
            


            //--------------------------------------------------
            //Patient objesi :

            Patient patient=new Patient();
            patient.Ad = Ad;
            patient.Soyad = Soyad;
            patient.TCNo = TCNo;
            patient.Cinsiyet = Cinsiyet;
            patient.Yas = 2021-Convert.ToInt32(yas);
            patient.Ilce = Ilce;
            patient.Adres = Adres;
            patient.PostaKodu= PostaKodu;


            //try catch ekle buraya
            try {
                TMA_DBContext.Patients.Add(patient);
                TMA_DBContext.SaveChanges();
                MessageBox.Show("Hasta Eklendi!");
            }
            catch { MessageBox.Show("Hasta zaten kayıtlı!"); }
            




            txtBox_TC.Clear();
            txtBox_Ad.Clear();
            txtBox_Soyad.Clear();

            txtBox_Ilce.Clear();
            txtBox_Adres.Clear();
            txtBox_PostaKodu.Clear();

        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
