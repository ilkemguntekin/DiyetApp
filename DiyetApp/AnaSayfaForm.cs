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
    public partial class AnaSayfaForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly Uye _uye;
        public AnaSayfaForm(DiyetDbContext db, Uye uye)
        {
            _db = db;
            _uye = uye;
            InitializeComponent();

            // Sol groupBox
            lblBoy.Text = uye.Boy.ToString();
            lblHedef.Text = uye.HedefKalori.ToString();
            lblKilo.Text = uye.Kilo.ToString();

            grbKullanici.Text = uye.Ad + " " + uye.Soyad;

            // Sağ groupBox
            List<BesinPorsiyon> Yemekler = db.BesinPorsiyonlar.Where(x => x.KategoriId != 2).ToList();
            List<int> yemekIds = new List<int>();
            Random rnd = new Random();
            foreach(BesinPorsiyon besin in Yemekler)
            {
                yemekIds.Add(besin.Id);
            }

            int yemekId = yemekIds[rnd.Next(0, yemekIds.Count - 1)];
            lblYemekOneri.Text = db.BesinPorsiyonlar.First(x => x.Id == yemekId).Ad;

            rnd = new Random();
            List<BesinPorsiyon> Icecekler = db.BesinPorsiyonlar.Where(x => x.KategoriId == 2).ToList();
            List<int> icecekIds = new List<int>();
            foreach (BesinPorsiyon icecek in Icecekler)
            {
                icecekIds.Add(icecek.Id);
            }
            int icecekId = icecekIds[rnd.Next(0, icecekIds.Count - 1)];
            lblIcecekOneri.Text = db.BesinPorsiyonlar.First(x => x.Id == icecekId).Ad;
        }

        private void btnEv_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new AnaSayfaForm(_db, _uye);
            DialogResult dr = frm.ShowDialog();
        }

        private void btnYemek_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var frm = new YemekForm(_db, _uye);
            DialogResult dr = frm.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var frm = new RaporForm(_db, _uye);
            DialogResult dr = frm.ShowDialog();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var frm = new ProfilForm(_db, _uye);
            DialogResult dr = frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var frm = new GirisForm();
            DialogResult dr = frm.ShowDialog();
        }
    }
}
