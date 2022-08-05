using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneTMA.Sekreter;

namespace HastaneTMA
{
    public partial class sekreterinEkrani : Form
    {
        private int CalisanNo;
        public sekreterinEkrani(int CalisanNo)
        {
            InitializeComponent();
            this.CalisanNo = CalisanNo;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_YeniHastaEkle_Click(object sender, EventArgs e)
        {
            hastaEkle hastaEkle = new hastaEkle();
            hastaEkle.Show();
        }

        private void btn_YeniRandevuEkle_Click(object sender, EventArgs e)
        {
            yeniRandevu yeniRandevu = new yeniRandevu();
            yeniRandevu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastaSil hastaSil= new hastaSil();
            hastaSil.Show();
        }

        private void sekreterinEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_RandevuIptal_Click(object sender, EventArgs e)
        {
            randevuSil randevuSil=new randevuSil();
            randevuSil.Show();
        }
    }
}
