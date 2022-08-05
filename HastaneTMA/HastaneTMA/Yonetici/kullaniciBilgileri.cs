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

namespace HastaneTMA.Yonetici
{
    public partial class kullaniciBilgileri : Form
    {
        private Model1 TMA_DBContext=new Model1();
        public kullaniciBilgileri()
        {
            InitializeComponent();
        }

        private void kullaniciBilgileri_Load(object sender, EventArgs e)
        {

            //this.usersTableAdapter.Fill(this.hastaneTMADataSetUsers2.Users);
            BindingSource bi_users = new BindingSource();
            BindingList<User> bi_usList = new BindingList<User>();
            foreach (var item in TMA_DBContext.Users.ToList())
            {
                bi_usList.Add(item);
            }
            bi_users.DataSource = bi_usList;
            dataGridView1.DataSource = bi_users;

        }

        private void btn_KullaniciyiSil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
