using HastaneTMA.Yonetici;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HastaneTMA.Model;
using System.ComponentModel;

namespace HastaneTMA.Model
{
    public partial class yoneticininEkrani : Form
    {
        private Model1 TMA_DBContext = new Model1();
        private int CalisanNo;
        public yoneticininEkrani(int CalisanNo)
        {
            InitializeComponent();
            this.CalisanNo = CalisanNo;


            //https://www.youtube.com/watch?v=TRH7rm8ozD4&ab_channel=FoxLearn
            // burda veri ekleme silme güncelleme anlatıyor
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yoneticininEkrani_Load(object sender, EventArgs e)
        {
            //this.employeesTableAdapter.Fill(this.hastaneTMADataSet.Employees);
            BindingSource bi_employees = new BindingSource();
            BindingList <Employee> bi_emList= new BindingList <Employee>();
            foreach (var item in TMA_DBContext.Employees.ToList())
            {
                bi_emList.Add(item);
            }
            bi_employees.DataSource = bi_emList;
            dgv_Calisanlar.DataSource = bi_employees;
            //---------------------------------------------
            //this.usersTableAdapter.Fill(this.hastaneTMADataSetUsers.Users);
            /*
            BindingSource bi_users = new BindingSource();
            BindingList<User> bi_usList = new BindingList<User>();
            foreach (var item in TMA_DBContext.Users.ToList())
            {
                bi_usList.Add(item);
            }
            bi_users.DataSource = bi_usList;
            dgv_.DataSource = bi_users;
            */
            //---------------------------------------------
            //this.expensesTableAdapter.Fill(this.hastaneTMADataSet2.Expenses);
            BindingSource bi_expenses = new BindingSource();
            BindingList<Expens> bi_exList = new BindingList<Expens>();
            foreach (var item in TMA_DBContext.Expenses.ToList())
            {
                bi_exList.Add(item);
            }
            bi_expenses.DataSource = bi_exList;
            dgv_Giderler.DataSource = bi_exList;
            //---------------------------------------------
            //this.incomesTableAdapter.Fill(this.hastaneTMADataSet1.Incomes);
            BindingSource bi_incomes = new BindingSource();
            BindingList<Income> bi_inList = new BindingList<Income>();
            foreach (var item in TMA_DBContext.Incomes.ToList())
            {
                bi_inList.Add(item);
            }
            bi_incomes.DataSource = bi_inList;
            dgv_Gelirler.DataSource = bi_inList;
            //---------------------------------------------
            //this.clinicsTableAdapter.Fill(this.hastaneTMAClinics.Clinics);
            BindingSource bi_klinik = new BindingSource();
            BindingList<Clinic> bi_klList = new BindingList<Clinic>();
            foreach (var item in TMA_DBContext.Clinics.ToList())
            {
                bi_klList.Add(item);
            }
            bi_klinik.DataSource = bi_klList;
            dgv_Klinikler.DataSource = bi_klList;




        }

        private void grpBox_Calisanlar_Enter(object sender, EventArgs e)
        {

        }

        private void grpBox_Klinikler_Enter(object sender, EventArgs e)
        {

        }

        private void refreshData(string tablo)
        {
            BindingSource bi = new BindingSource();
            switch (tablo)
            {
                case "Clinics":
                    var query_Clinics = from t in TMA_DBContext.Clinics
                                        orderby t.ID
                                        select new { t.ID, t.KlinikAdi };
                    bi.DataSource = query_Clinics.ToList();

                    dgv_Klinikler.DataSource = bi;
                    dgv_Klinikler.Refresh();
                    break;
                case "Employees":
                    var query_Employees = from t in TMA_DBContext.Employees
                                          orderby t.ID
                                          select new { t.ID, t.Ad, t.Soyad, t.Cinsiyet, t.DogumTarihi, t.IseGirisTarihi, t.maas };
                    bi.DataSource = query_Employees.ToList();

                    dgv_Calisanlar.DataSource = bi;
                    dgv_Calisanlar.Refresh();
                    break;
                case "Incomes":
                    var query_Incomes = from t in TMA_DBContext.Incomes
                                          orderby t.ID
                                          select new {t.ID,t.GelirAdi,t.Miktar,t.Tarih };
                    bi.DataSource = query_Incomes.ToList();
                    dgv_Gelirler.DataSource = bi;
                    dgv_Gelirler.Refresh();
                    break;
                case "Expenses":
                    var query_Expenses = from t in TMA_DBContext.Expenses
                                        orderby t.ID
                                        select new { t.ID, t.GiderAdi, t.Miktar, t.Tarih };
                    bi.DataSource = query_Expenses.ToList();
                    dgv_Giderler.DataSource = bi;
                    dgv_Giderler.Refresh();
                    break;

            };

        }

        private void btn_KlinikEkle_Click(object sender, EventArgs e)
        {
            if (txtBox_KlinikAdi != null)
            {
                Clinic clinic = new Clinic();
                clinic.KlinikAdi = txtBox_KlinikAdi.Text;
                TMA_DBContext.Clinics.Add(clinic);
                TMA_DBContext.SaveChanges();
                refreshData("Clinics");
            }
            else
                MessageBox.Show("Lütfen Değer Giriniz!");



        }

        private void btn_CalisanEkle_Click(object sender, EventArgs e)
        {
            // --- OBJENİN OLUŞTURULMASI VE DATABASE'E YÜKLENMESİ
            if (txtBox_Ad.Text != String.Empty && txtBox_Soyad.Text != String.Empty && (rdBtn_Erkek.Checked || rdBtn_Kadin.Checked) && txtBox_Maas.Text != String.Empty)
            {
                Employee employee = new Employee();
                employee.Ad = txtBox_Ad.Text;
                employee.Soyad = txtBox_Soyad.Text;
                employee.Cinsiyet = rdBtn_Erkek.Checked ? false : true;
                employee.DogumTarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString("yyyy-MM-dd"));
                employee.IseGirisTarihi = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                employee.maas = int.Parse(txtBox_Maas.Text.ToString());

                TMA_DBContext.Employees.Add(employee);
                TMA_DBContext.SaveChanges();
                refreshData("Employees");
            }
            else
                MessageBox.Show("Lütfen Boş alanları doldurunuz!");



            txtBox_Ad.Clear();
            txtBox_Soyad.Clear();
            rdBtn_Erkek.Invalidate();
            rdBtn_Kadin.Invalidate();
            txtBox_Maas.Clear();
        }

        private void btn_KullaniciBilgileri_Click(object sender, EventArgs e)
        {
            kullaniciBilgileri kullaniciBilgileri = new kullaniciBilgileri();
            kullaniciBilgileri.Show();
        }

        private void btn_CalisanSil_Click(object sender, EventArgs e)
        {
            var calisanID = int.Parse(dgv_Calisanlar.CurrentRow.Cells[0].Value.ToString());

            using (TMA_DBContext = new Model1())
            {
                try
                {
                    var employee = TMA_DBContext.Employees.Where(em => em.ID == calisanID).ToList().FirstOrDefault();
                    TMA_DBContext.Employees.Remove(employee);
                    TMA_DBContext.SaveChanges();
                    refreshData("Employees");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı!");
                }
            }

        }

        private void btn_KullaniciEkle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtBox_KullaniciAdi.Text;
            string sifre = txtBox_Sifre.Text;
            int rolNo = int.Parse(txtBox_RolNo.Text);
            int calisanNo = int.Parse(txtBox_CalisanNo.Text);

            try
            {
                User user = new User();
                user.KullaniciAdi = kullaniciAdi;
                user.Sifre = sifre;
                user.RolNo = rolNo;
                user.CalisanNo = calisanNo;

                TMA_DBContext.Users.Add(user);
                TMA_DBContext.SaveChanges();
                MessageBox.Show("Kullanıcı başarılı bir şekilde kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı!\n" +
                    "Lütfen kullanıcı oluşturmadan önce çalışan oluşturunuz.");
            }
        }

        private void btn_KullaniciSil_Click(object sender, EventArgs e)
        {
            int kullaniciID = int.Parse(txtBox_KullaniciSil.Text.ToString());

            using (TMA_DBContext = new Model1())
            {
                try
                {
                    var kullanici = TMA_DBContext.Users.Where(ku => ku.ID == kullaniciID).ToList().FirstOrDefault();

                    TMA_DBContext.Users.Remove(kullanici);
                    TMA_DBContext.SaveChanges();
                    MessageBox.Show("Kullanıcı başarılı bir şekilde silindi.");

                    txtBox_KullaniciSil.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Bir hatayla karşılaşıldı!\n"+ex.ToString());
                }
            }
        }

        private void btn_KlinikSil_Click(object sender, EventArgs e)
        {


            try
            {
                var klinikID = int.Parse(dgv_Klinikler.CurrentRow.Cells[0].Value.ToString());

                var klinik = TMA_DBContext.Clinics.Where(k => k.ID == klinikID).ToList().FirstOrDefault();
                TMA_DBContext.Clinics.Remove(klinik);
                TMA_DBContext.SaveChanges();
                MessageBox.Show("Başarıyla Silindi!");
                refreshData("Clinics");
            }
            catch
            {
                MessageBox.Show("Bir hatayla karşılaşıldı!");
            }

        }

        private void btn_GelirEkle_Click(object sender, EventArgs e)
        {

            try
            {
                string gelirAdi = txtBox_GelirAdi.Text;
                int gelirMiktar = int.Parse(txtBox_GelirMiktar.Text.ToString());
                DateTime gelirTarih = DateTime.Now;

                Income income = new Income();
                income.GelirAdi = gelirAdi;
                income.Miktar = gelirMiktar;
                income.Tarih = gelirTarih;

                TMA_DBContext.Incomes.Add(income);
                TMA_DBContext.SaveChanges();
                MessageBox.Show("Başarıyla Eklendi!");
                refreshData("Incomes");
            }
            catch
            {
                MessageBox.Show("Bir hatayla karşılaşıldı!\n" +
                    "Hata nedeni istenmeyen tipte veri girilmesi olabilir.");
            }

        }

        private void btn_GelirSil_Click(object sender, EventArgs e)
        {

            try
            {
                int GelirID = int.Parse(dgv_Gelirler.CurrentRow.Cells[0].Value.ToString());
                var Gelir = TMA_DBContext.Incomes.Where(income => income.ID == GelirID).ToList().FirstOrDefault();
                TMA_DBContext.Incomes.Remove(Gelir);
                TMA_DBContext.SaveChanges();

                MessageBox.Show("Başarıyla Silindi!");
                refreshData("Incomes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı!\n" + ex.ToString());
            }
        }

        private void btn_GiderSil_Click(object sender, EventArgs e)
        {
            try
            {
                int GiderID = int.Parse(dgv_Giderler.CurrentRow.Cells[0].Value.ToString());
                var Gider = TMA_DBContext.Expenses.Where(expense => expense.ID == GiderID).ToList().FirstOrDefault();
                TMA_DBContext.Expenses.Remove(Gider);
                TMA_DBContext.SaveChanges();

                MessageBox.Show("Başarıyla Silindi!");
                refreshData("Expenses");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı!\n" + ex.ToString());
            }
        }

        private void btn_GiderEkle_Click(object sender, EventArgs e)
        {

            try
            {
                string giderAdi = txtBox_GiderAdi.Text;
                int giderMiktar = int.Parse(txtBox_GiderMiktar.Text.ToString());
                DateTime giderTarih = DateTime.Now;


                Expens expens = new Expens();
                expens.GiderAdi = giderAdi;
                expens.Miktar = giderMiktar;
                expens.Tarih = giderTarih;

                TMA_DBContext.Expenses.Add(expens);
                TMA_DBContext.SaveChanges();
                MessageBox.Show("Başarıyla Eklendi!");
                refreshData("Expenses");
            }
            catch
            {
                MessageBox.Show("Bir hatayla karşılaşıldı!\n" +
                    "Hata nedeni istenmeyen tipte veri girilmesi olabilir.");
            }
        }

        private void txtBox_KullaniciSil_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DoktorIliskilendir_Click(object sender, EventArgs e)
        {
            doktorIliskilendir doktorIliskilendir = new doktorIliskilendir();
            doktorIliskilendir.Show();
        }

        private void dgv_Calisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
