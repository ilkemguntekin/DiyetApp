using DiyetApp.Besinler;
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
    public partial class GirisForm : Form
    {
        DiyetDbContext db = new DiyetDbContext();
        Uye uye = null;
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            btnKaydet.Visible = true;
            lblEmail.Visible = true;
            lblTelefon.Visible = true;
            lblSorular.Visible = true;
            txtEmail.Visible = true;
            txtTelefon.Visible = true;
            txtGizliYanit.Visible = true;
            btnUyeOl.Visible = false;
            btnGirisYap.Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye()
            {
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text,
                GizliYanit = txtGizliYanit.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text
            };

            if(txtKullaniciAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı adı girmek zorunludur.");
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email girmek zorunludur.");
                return;
            }

            if (txtGizliYanit.Text.Trim() == "")
            {
                MessageBox.Show("Gizli yanıt girmek zorunludur.");
                return;
            }

            if (txtSifre.Text.Trim() == "")
            {
                MessageBox.Show("Şifre girmek zorunludur.");
                return;
            }

            if (txtKullaniciAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı adı girmek zorunludur.");
                return;
            }

            if (db.Uyeler.Any(x => x.Email == uye.Email))
            {
                MessageBox.Show("Bu email daha önce kullanılmıştır. Lütfen yeni bir email adresi giriniz.");
                return;
            }

            if (db.Uyeler.Any(x => x.KullaniciAdi == uye.KullaniciAdi))
            {
                MessageBox.Show("Bu kullanıcı adı daha önce kullanılmıştır. Lütfen yeni bir kullanıcı adı giriniz.");
                return;
            }

            if (db.Uyeler.Any(x => x.Telefon == uye.Telefon))
            {
                MessageBox.Show("Bu telefon numarası daha önce kullanılmıştır. Lütfen yeni bir telefon numarası giriniz.");
                return;
            }

            db.Add(uye);
            db.SaveChanges();
            MessageBox.Show("Kayıt tamamlanmıştır.");

            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtGizliYanit.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";

            btnKaydet.Visible = false;
            lblEmail.Visible = false;
            lblTelefon.Visible = false;
            lblSorular.Visible = false;
            txtEmail.Visible = false;
            txtTelefon.Visible = false;
            txtGizliYanit.Visible = false;
            btnUyeOl.Visible = true;
            btnGirisYap.Visible = true;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            List<Uye> uyeler = db.Uyeler.ToList();
            bool basariliGiris = false;

            foreach (Uye kisi in uyeler)
            {
                if (kisi.KullaniciAdi == txtKullaniciAdi.Text)
                {
                    if (kisi.Sifre == txtSifre.Text)
                    {
                        MessageBox.Show("Giriş Yapılmıştır.");
                        basariliGiris = true;
                        uye = kisi;

                        Form frm = new AnaSayfaForm(db, uye);
                        DialogResult dr = frm.ShowDialog();
                        this.Close();

                        break;
                    }
                }
            }

            if (basariliGiris == false)
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz!");
                return;
            }         
        }

        private void btnUnuttum_Click(object sender, EventArgs e)
        {
            var frm = new SifremiUnuttumForm(db);
            DialogResult dr = frm.ShowDialog();
            this.Close();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            var frm = new AdminGirisForm(db);
            DialogResult dr = frm.ShowDialog();
            this.Close();
        }
    }
}
