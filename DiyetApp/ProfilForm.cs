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
    public partial class ProfilForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly Uye _uye;
        public ProfilForm(DiyetDbContext db, Uye uye)
        {
            _db = db;
            _uye = uye;

            InitializeComponent();

            Guncelle(uye);
        }

        private void Guncelle(Uye uye)
        {
            lblAd.Text = uye.Ad.ToString();
            lblSoyad.Text = uye.Soyad.ToString();

            if (uye.Cinsiyet)
            {
                lblCinsiyet.Text = "Kadın";
            }
            else
            {
                lblCinsiyet.Text = "Erkek";
            }

            lblKilo.Text = uye.Kilo.ToString();
            lblBoy.Text = uye.Boy.ToString();
            lblYas.Text = uye.Yas.ToString();
            lblEmail.Text = uye.Email;
            lblTelefon.Text = uye.Telefon;
        }

        private void btnKBilDuzen_Click(object sender, EventArgs e)
        {
            txtAd.Visible = true;
            txtAd.Text = _uye.Ad;
            txtBoy.Visible = true;
            txtBoy.Text = _uye.Boy.ToString();
            chkErkek.Visible = true;
            chkKadin.Visible = true;

            if (_uye.Cinsiyet)
            {
                chkKadin.Checked = true;
            }
            else
                chkErkek.Checked = true;

            txtSoyad.Visible = true;
            txtSoyad.Text = _uye.Soyad;
            txtKilo.Visible = true;
            txtKilo.Text = _uye.Kilo.ToString();
            txtYas.Visible = true;
            txtYas.Text = _uye.Yas.ToString();
            btnKaydetKB.Visible = true;
        }

        private void btnKaydetKB_Click(object sender, EventArgs e)
        {
            _uye.Ad = txtAd.Text.Trim();
            _uye.Soyad = txtSoyad.Text.Trim();
            _uye.Boy = Convert.ToInt32(txtBoy.Text.Trim());
            _uye.Kilo = Convert.ToInt32(txtKilo.Text.Trim());
            _uye.Yas = Convert.ToInt32(txtYas.Text.Trim());

            if (chkKadin.Checked)
                _uye.Cinsiyet = true;
            else if (chkErkek.Checked)
                _uye.Cinsiyet = false;

            _db.SaveChanges();
            
            txtAd.Visible = false;
            txtBoy.Visible = false;
            chkErkek.Visible = false;
            chkKadin.Visible = false;
            txtSoyad.Visible = false;
            txtKilo.Visible = false;
            txtYas.Visible = false;
            btnKaydetKB.Visible = false;

            Guncelle(_uye);
        }

        private void btnIBilDuzen_Click(object sender, EventArgs e)
        {
            lblEmail.Visible= false;
            txtEmail.Visible = true;
            txtEmail.Text = _uye.Email;
            txtTelefon.Visible = true;
            txtTelefon.Text = _uye.Telefon;
            btnKaydetIB.Visible = true;
        }

        private void btnKaydetIB_Click(object sender, EventArgs e)
        {
            _uye.Email = txtEmail.Text.Trim();
            _uye.Telefon = txtTelefon.Text.Trim();

            _db.SaveChanges();

            lblEmail.Visible = true;
            txtEmail.Visible = false;
            txtTelefon.Visible = false;
            btnKaydetIB.Visible = false;

            Guncelle(_uye);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new AnaSayfaForm(_db, _uye);
            DialogResult dr = frm.ShowDialog();
        }
    }
}
