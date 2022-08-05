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

namespace HastaneTMA.Doktor
{
    public partial class taniKoy : Form
    {
        int CalisanNo;
        string TCNo,Ad,Soyad;
        private Model1 TMA_DBContext;
        private void btn_TaniKoy_Click(object sender, EventArgs e)
        {
            Diagnostic diagnostic = new Diagnostic();
            diagnostic.DoktorID = CalisanNo;
            diagnostic.HastaTC = TCNo;
            diagnostic.Tani = txtBox_Tani.Text;   //BURAYI GİRSİN MAX 500 KARAKTER
            diagnostic.TaniTarihi = DateTime.Now;

            using (TMA_DBContext=new Model1())
            {
                try{
                    TMA_DBContext.Diagnostics.Add(diagnostic);
                    TMA_DBContext.SaveChanges();
                    MessageBox.Show("Tanı oluşturuldu.");
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı!");
                }
                
            }
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public taniKoy(int CalisanNo,string TCNo,string Ad,string Soyad)
        {
            InitializeComponent();
            this.CalisanNo = CalisanNo;
            this.TCNo = TCNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
        }

        private void TaniKoy_Load(object sender, EventArgs e)
        {
            lbl_AdSoyad.Text = Ad.Trim()+" "+Soyad.Trim()+" için tanı :";


        }
    }
}
