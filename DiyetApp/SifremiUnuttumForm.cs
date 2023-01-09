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
    public partial class SifremiUnuttumForm : Form
    {
        private readonly DiyetDbContext _db;
        
        public SifremiUnuttumForm(DiyetDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            List<Uye> uyeler = _db.Uyeler.ToList();
            bool var = false;

            foreach (Uye uye in uyeler)
            {
                if (txtGizliYanit.Text.Trim() == uye.GizliYanit && txtMail.Text.Trim() == uye.Email)
                {
                    var = true;
                    MessageBox.Show("Şifreniz: " + uye.Sifre.ToString());
                    break;
                }
            }

            if (var == false)
            {
                MessageBox.Show("Mail adresiniz ya da gizli yanıtınız hatalıdır.");
                return;
            }
            else
            {
                this.Close();
                var frm = new GirisForm();
                DialogResult dr = frm.ShowDialog();
            }                
        }
    }
}
