using DiyetApp.Besinler;
using DiyetApp.Contexts;
using DiyetApp.Kullanici;
using DiyetApp.Ogunler;
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
    public partial class YemekForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly Uye _uye;
        public YemekForm(DiyetDbContext db, Uye uye)
        {
            _db = db;
            _uye = uye;
            InitializeComponent();

            dgvYemekler.DataSource = db.BesinPorsiyonlar.ToList();
            dgvYemekler.Columns[5].Visible = false;

            Guncelle(db);
        }

        private void Guncelle(DiyetDbContext db)
        {
            dgvSabah.DataSource = db.UyeYemekler.Where(x => x.UyeId == _uye.Id && x.OgunId == 1 && x.Zaman.Day == DateTime.Now.Day).ToList();
            //dgvSabah.DataSource = db.UyeYemekler.Where(x => x.UyeId == _uye.Id && x.OgunId == 1 && x.Zaman.Day == DateTime.Now.Day).Select(x => new UyeYemekTablo { BesinAd = x.Besin.Ad, Id = x.Id, OgunAd = x.Ogun.OgunAd, Zaman = x.Zaman.ToString() }).ToList();
            dgvOgle.DataSource = db.UyeYemekler.Where(x => x.UyeId == _uye.Id && x.OgunId == 2 && x.Zaman.Day == DateTime.Now.Day).ToList();
            dgvAksam.DataSource = db.UyeYemekler.Where(x => x.UyeId == _uye.Id && x.OgunId == 3 && x.Zaman.Day == DateTime.Now.Day).ToList();
            lblHedefKalori.Text = _uye.HedefKalori.ToString();

            foreach (DataGridViewColumn column in dgvSabah.Columns)
            {
                column.Visible = false;
            }
            dgvSabah.Columns[0].Visible = true;
            dgvSabah.Columns[1].Visible = true;
            dgvSabah.Columns[2].Visible = true;
            dgvSabah.Columns[3].Visible = true;

            foreach (DataGridViewColumn column in dgvOgle.Columns)
            {
                column.Visible = false;
            }

            dgvOgle.Columns[0].Visible = true;
            dgvOgle.Columns[1].Visible = true;
            dgvOgle.Columns[2].Visible = true;
            dgvOgle.Columns[3].Visible = true;

            foreach (DataGridViewColumn column in dgvAksam.Columns)
            {
                column.Visible = false;
            }

            dgvAksam.Columns[0].Visible = true;
            dgvAksam.Columns[1].Visible = true;
            dgvAksam.Columns[2].Visible = true;
            dgvAksam.Columns[3].Visible = true;

            cmbPorsiyon.SelectedIndex = 0;
            rbSabah.Checked = true;

            //
            double mevcutKalori = 0;
            List<int> idListe = new List<int>();
            idListe = _db.UyeYemekler.Where(x => x.Zaman.Day == DateTime.Now.Day && x.UyeId == _uye.Id).Select(x => x.BesinId).ToList();
            foreach (int id in idListe)
            {
                mevcutKalori = mevcutKalori + _db.BesinPorsiyonlar.First(x => x.Id == id).Kalori;
            }
            lblMevcutKalori.Text = mevcutKalori.ToString();

            prbKalori.Minimum = 0;
            prbKalori.Maximum = (int)_uye.HedefKalori;
            if (mevcutKalori > _uye.HedefKalori)
            {
                prbKalori.Value = (int)_uye.HedefKalori;
            }
            else
                prbKalori.Value = (int)mevcutKalori;

            SatirSec();
        }

        private void SatirSec()
        {
            bool IsRowSelected = false;
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    DataGridView dgv = (DataGridView)control;
                    if (dgv.SelectedRows.Count > 0)
                    {
                        IsRowSelected = true;
                        break;
                    }
                }
            }

            if (IsRowSelected == false)
            {
                dgvYemekler.Rows[0].Selected = true;
            }
        }

        private void txtYemek_TextChanged(object sender, EventArgs e)
        {
            dgvYemekler.DataSource = _db.BesinPorsiyonlar.Where(x => x.Ad.Contains(txtYemek.Text)).ToList();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            if (dgvYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Yemek Seçiniz");
                return;
            }

            BesinPorsiyon Besin = (BesinPorsiyon)dgvYemekler.SelectedRows[0].DataBoundItem;


            int deger = Convert.ToInt32(cmbPorsiyon.SelectedItem);

            if (rbSabah.Checked)
            {
                while (deger > 0)
                {
                    UyeYemek uyeYemek = new UyeYemek();
                    uyeYemek.Zaman = dtZaman.Value;
                    uyeYemek.BesinId = Besin.Id;
                    uyeYemek.UyeId = _uye.Id;
                    uyeYemek.OgunId = 1;
                    _db.Add(uyeYemek);
                    _db.SaveChanges();
                    deger--;
                }
                Guncelle(_db);
            }
            else if (rbOgle.Checked)
            {
                while (deger > 0)
                {
                    UyeYemek uyeYemek = new UyeYemek();
                    uyeYemek.Zaman = dtZaman.Value;
                    uyeYemek.BesinId = Besin.Id;
                    uyeYemek.UyeId = _uye.Id;
                    uyeYemek.OgunId = 2;
                    _db.Add(uyeYemek);
                    _db.SaveChanges();
                    deger--;
                }
                Guncelle(_db);
            }
            else
            {
                while (deger > 0)
                {
                    UyeYemek uyeYemek = new UyeYemek();
                    uyeYemek.Zaman = dtZaman.Value;
                    uyeYemek.BesinId = Besin.Id;
                    uyeYemek.UyeId = _uye.Id;
                    uyeYemek.OgunId = 3;
                    _db.Add(uyeYemek);
                    _db.SaveChanges();
                    deger--;
                }
                Guncelle(_db);
            }
        }

        private void dgvYemekler_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAksam.Rows)
            {
                row.Selected = row.DataBoundItem == null;             
            }
            foreach (DataGridViewRow row in dgvOgle.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
            foreach (DataGridViewRow row in dgvSabah.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
        }

        private void dgvSabah_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAksam.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
            foreach (DataGridViewRow row in dgvOgle.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
            foreach (DataGridViewRow row in dgvYemekler.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
        }

        private void dgvOgle_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAksam.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
            foreach (DataGridViewRow row in dgvYemekler.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
            foreach (DataGridViewRow row in dgvSabah.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
        }

        private void dgvAksam_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvYemekler.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
            foreach (DataGridViewRow row in dgvOgle.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
            foreach (DataGridViewRow row in dgvSabah.Rows)
            {
                row.Selected = row.DataBoundItem == null;
            }
        }

        private void btnOgunYemekSil_Click(object sender, EventArgs e)
        {
            if (dgvYemekler.SelectedCells.Count != 0)
            {
                MessageBox.Show("Silinecek yemeği öğününüzden seçiniz.");
                return;
            }

            if (dgvSabah.SelectedCells.Count == 0 && dgvOgle.SelectedCells.Count == 0 && dgvAksam.SelectedCells.Count == 0)
            {
                MessageBox.Show("Silinecek yemeği öğününüzden seçiniz.");
                return;
            }

            if (dgvSabah.SelectedCells.Count != 0)
            {
                _db.UyeYemekler.Remove((UyeYemek)dgvSabah.SelectedRows[0].DataBoundItem);
                _db.SaveChanges();
            }

            if (dgvOgle.SelectedCells.Count != 0)
            {
                _db.UyeYemekler.Remove((UyeYemek)dgvOgle.SelectedRows[0].DataBoundItem);
                _db.SaveChanges();
            }

            if (dgvAksam.SelectedCells.Count != 0)
            {
                _db.UyeYemekler.Remove((UyeYemek)dgvAksam.SelectedRows[0].DataBoundItem);
                _db.SaveChanges();
            }

            Guncelle(_db);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var frm = new AnaSayfaForm(_db, _uye);
            DialogResult dr = frm.ShowDialog();
        }
    }
}
