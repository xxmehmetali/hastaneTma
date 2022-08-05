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
    public partial class hastaSil : Form
    {
        private Model1 TMA_DBContext;
        public hastaSil()
        {
            InitializeComponent();
        }

        private void hastaSil_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string TCNo = txtBox_HastaTC.Text;
            TMA_DBContext = new Model1();

            //Patient patient=new Patient() { TCNo=TCNo};

            var table = TMA_DBContext.Patients.ToList();
            var res = table.Where(s => s.TCNo==TCNo).ToList();


            TMA_DBContext.Patients.RemoveRange(res);
            TMA_DBContext.SaveChanges();


            MessageBox.Show("HASTA SİLİNDİ");

        }
    }
}
