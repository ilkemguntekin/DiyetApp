using DiyetApp.Besinler;
using DiyetApp.Contexts;
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
    public partial class AdminGorevForm : Form
    {
        private readonly DiyetDbContext _db;
        public AdminGorevForm(DiyetDbContext db)
        {
            _db = db;

            InitializeComponent();
            Guncelle();
        }

        private void Guncelle()
        {
            dgvBesinler.DataSource = _db.BesinPorsiyonlar.ToList();
            dgvKategoriler.DataSource = _db.Kategoriler.ToList();
        }

        private void btnBEkle_Click(object sender, EventArgs e)
        {
            lblBAd.Visible = true;
            lblKId.Visible = true;
            lblKalori.Visible = true;
            txtBesinAd.Visible = true;
            txtKalori.Visible = true;
            txtKategoriId.Visible = true;
            btnBesinKaydet.Visible = true;
            lblBId.Text = "0";
        }

        private void btnBesinKaydet_Click(object sender, EventArgs e)
        {
            if(_db.BesinPorsiyonlar.Select(x => x.Id).Contains(Convert.ToInt32(lblBId.Text)))
            {
                BesinPorsiyon besin = (BesinPorsiyon)dgvBesinler.SelectedRows[0].DataBoundItem;
                besin.Ad = txtBesinAd.Text.Trim();
                besin.Kalori = Convert.ToDouble(txtKalori.Text.Trim());
                besin.KategoriId = Convert.ToInt32(txtKategoriId.Text.Trim());
                _db.SaveChanges();

                lblBAd.Visible = false;
                lblKId.Visible = false;
                lblKalori.Visible = false;
                txtBesinAd.Visible = false;
                txtKalori.Visible = false;
                txtKategoriId.Visible = false;
                btnBesinKaydet.Visible = false;


                txtBesinAd.Text = "";
                txtKalori.Text = "";
                txtKategoriAdi.Text = "";

                Guncelle();
            }
            else
            {
                BesinPorsiyon besin = new BesinPorsiyon();
                besin.Ad = txtBesinAd.Text.Trim();
                besin.Kalori = Convert.ToDouble(txtKalori.Text.Trim());
                besin.KategoriId = Convert.ToInt32(txtKategoriId.Text.Trim());
                besin.Porsiyon = 1;
                _db.BesinPorsiyonlar.Add(besin);
                _db.SaveChanges();

                lblBAd.Visible = false;
                lblKId.Visible = false;
                lblKalori.Visible = false;
                txtBesinAd.Visible = false;
                txtKalori.Visible = false;
                txtKategoriId.Visible = false;
                btnBesinKaydet.Visible = false;


                txtBesinAd.Text = "";
                txtKalori.Text = "";
                txtKategoriAdi.Text = "";

                Guncelle();
            }
        }

        private void btnBDuzenle_Click(object sender, EventArgs e)
        {
            lblBAd.Visible = true;
            lblKId.Visible = true;
            lblKalori.Visible = true;
            txtBesinAd.Visible = true;
            txtKalori.Visible = true;
            txtKategoriId.Visible = true;
            btnBesinKaydet.Visible = true;

            BesinPorsiyon besin = (BesinPorsiyon)dgvBesinler.SelectedRows[0].DataBoundItem;

            lblBId.Text = besin.Id.ToString();
            txtBesinAd.Text = besin.Ad.ToString();
            txtKalori.Text = besin.Kalori.ToString();
            txtKategoriId.Text = besin.KategoriId.ToString();
        }

        private void btnBSil_Click(object sender, EventArgs e)
        {
            BesinPorsiyon besin = (BesinPorsiyon)dgvBesinler.SelectedRows[0].DataBoundItem;

            _db.BesinPorsiyonlar.Remove(besin);
            _db.SaveChanges();

            Guncelle();
        }

        private void btnKEkle_Click(object sender, EventArgs e)
        {
            lblKAd.Visible = true;
            btnKategoriKaydet.Visible = true;
            txtKategoriAdi.Visible = true;
            txtKategoriAdi.Text = "";
            lblIdK.Text = "0";
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            if (_db.Kategoriler.Select(x => x.Id).Contains(Convert.ToInt32(lblIdK.Text)))
            {
                Kategori kategori = (Kategori)dgvKategoriler.SelectedRows[0].DataBoundItem;

                kategori.Ad = txtKategoriAdi.Text.Trim();
                _db.SaveChanges();

                lblKAd.Visible = false;
                btnKategoriKaydet.Visible = false;
                txtKategoriAdi.Visible = false;

                txtKategoriAdi.Text = "";

                Guncelle();
            }
            else
            {
                Kategori kategori = new Kategori();

                kategori.Ad = txtKategoriAdi.Text.Trim();
                _db.Kategoriler.Add(kategori);
                _db.SaveChanges();

                lblKAd.Visible = false;
                btnKategoriKaydet.Visible = false;
                txtKategoriAdi.Visible = false;

                txtKategoriAdi.Text = "";

                Guncelle();
            }
        }

        private void btnKDuzenle_Click(object sender, EventArgs e)
        {
            btnKategoriKaydet.Visible = true;
            lblKAd.Visible = true;
            txtKategoriAdi.Visible = true;

            Kategori kategori = (Kategori)dgvKategoriler.SelectedRows[0].DataBoundItem;

            lblIdK.Text = kategori.Id.ToString();
            txtKategoriAdi.Text = kategori.Ad.ToString();
        }

        private void btnKSil_Click(object sender, EventArgs e)
        {
            Kategori kategori = (Kategori)dgvKategoriler.SelectedRows[0].DataBoundItem;

            _db.Kategoriler.Remove(kategori);
            _db.SaveChanges();

            Guncelle();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            this.Hide();
>>>>>>> fba694f14585fe54c45248487a50e48b20d3de1c
            this.Close();
            var frm = new GirisForm();
            DialogResult dr = frm.ShowDialog();
        }
    }
}
