using DiyetApp.Contexts;
using DiyetApp.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetApp
{
    public partial class AdminGirisForm : Form
    {
        private readonly DiyetDbContext _db;
        public AdminGirisForm(DiyetDbContext db)
        {
            _db = db;

            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            List<Admin> adminler = _db.Adminler.ToList();
            bool var = false;
            foreach (Admin admin in adminler)
            {
                if(admin.AdminAd == txtAdminAd.Text.Trim() && admin.Sifre == txtSifre.Text.Trim())
                {
                    var = true;
                    MessageBox.Show("Giriş Yapıldı.");
                    this.Close();
                    var frm = new AdminGorevForm(_db);
                    DialogResult dr = frm.ShowDialog();
                    break;
                }
            }

            if(var == false)
            {
                MessageBox.Show("Bilgileriniz yanlıştır. Giriş yapılamadı.");
                return;
            }
        }
    }
}
