using HastaneTMA.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HastaneTMA.Model;

namespace HastaneTMA.Doktor
{
    public partial class doktorunEkrani : Form
    {
        private Model1 TMA_DBContext;
        private int CalisanNo;
        string Ad, Soyad, TCNo;
        public doktorunEkrani(int CalisanNo)
        {
            InitializeComponent();
            this.CalisanNo = CalisanNo;
        }

        private void doktorunEkrani_Load(object sender, EventArgs e)
        {


            using (TMA_DBContext = new Model1())
            {
                var calisanInfo = TMA_DBContext.Employees.ToList().Where(x => x.ID == CalisanNo).FirstOrDefault();
                string ad = calisanInfo.Ad;
                string soyad = calisanInfo.Soyad;
                lbl_Karsilama.Text = "Merhaba " + ad.Trim() + " " + soyad.Trim();
            }

            using (TMA_DBContext = new Model1())
            {
                var ap = TMA_DBContext.Appointments.Where(a => a.DoktorID == CalisanNo).ToList();
                for (int i = 0; i < ap.Count; i++)
                {
                    var oneRowAp=ap.Skip(i).Take(1).FirstOrDefault();
                    String TCNo = oneRowAp.TCNo;
                    DateTime RandevuSaati=oneRowAp.RandevuSaati;

                    //hastaya erişim
                    var oneRowPa = TMA_DBContext.Patients.ToList().Where(p => p.TCNo == TCNo).FirstOrDefault();
                    String Ad = oneRowPa.Ad;
                    String Soyad=oneRowPa.Soyad;
                    int Yas = oneRowPa.Yas;

                    dgv_Diagnostic.Rows.Add(TCNo,Ad,Soyad,Yas,RandevuSaati);
                }
            }
        }

        private void lbl_Karsilama_Click(object sender, EventArgs e)
        {

        }

        private void btn_KonulanTanilariGoster_Click(object sender, EventArgs e)
        {
            konulanTanilariGoster konulanTanilariGoster=new konulanTanilariGoster(CalisanNo,TCNo);
            konulanTanilariGoster.Show();
        }

        private void dgv_Diagnostic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TaniKoy_Click(object sender, EventArgs e)
        {
            
            TCNo = dgv_Diagnostic.CurrentRow.Cells[0].Value.ToString();
            Ad= dgv_Diagnostic.CurrentRow.Cells[1].Value.ToString();
            Soyad= dgv_Diagnostic.CurrentRow.Cells[2].Value.ToString();
            taniKoy taniKoy=new taniKoy(CalisanNo,TCNo,Ad,Soyad);
            taniKoy.Show();




        }
    }
}
