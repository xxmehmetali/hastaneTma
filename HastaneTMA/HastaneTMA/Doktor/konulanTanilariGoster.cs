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
    public partial class konulanTanilariGoster : Form
    {
        int CalisanNo;
        string TCNo;

        private Model1 TMA_DBContext;
        public konulanTanilariGoster(int CalisanNo,string TCNo)
        {
            InitializeComponent();
            this.CalisanNo = CalisanNo;
            this.TCNo = TCNo;


            using (TMA_DBContext = new Model1())
            {
                var tanilar = TMA_DBContext.Diagnostics.Where(t => t.DoktorID == CalisanNo).ToList();
                foreach (var t in tanilar)
                    dgv_KonulanTanilar.Rows.Add(t.HastaTC, t.Tani, t.TaniTarihi);
                
            }
        }

        private void dgv_KonulanTanilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
        }
    }
}
