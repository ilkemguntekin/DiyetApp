using DiyetApp.Besinler;
using DiyetApp.Contexts;
using DiyetApp.Kullanici;
using Microsoft.EntityFrameworkCore;
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
    public partial class RaporForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly Uye _uye;        
        public RaporForm(DiyetDbContext db, Uye uye)
        {
            _db = db;
            _uye = uye;

            InitializeComponent();

            Guncelle();
        }

        private void Guncelle()
        {          
            var result = (from p in _db.UyeYemekler
                          join c in _db.BesinPorsiyonlar on p.BesinId equals c.Id
                          where p.Zaman.Day == dtZaman.Value.Day
                          where p.UyeId == _uye.Id
                          select new { c.Ad });

            foreach(var item in result) 
            {
                lstbYemekler.Items.Add(item);                
            }
            
            List<int> idListe = new List<int>();
            idListe = _db.UyeYemekler.Where(x => x.Zaman.Day == dtZaman.Value.Day && x.UyeId == _uye.Id).Select(x => x.BesinId).ToList();

            double mevcutKalori = 0;
            foreach (int id in idListe)
            {
                mevcutKalori = mevcutKalori + _db.BesinPorsiyonlar.First(x => x.Id == id).Kalori;
            }

            pgbHedef.Maximum = (int)(_uye.HedefKalori * 1.25);
            pgbHedef.Value = (int)_uye.HedefKalori;
            pgbYapilan.Maximum = pgbHedef.Maximum;
            pgbYapilan.Value = (int)mevcutKalori;

            if (pgbYapilan.Value > pgbHedef.Value)
                pgbYapilan.ForeColor = Color.Red;
            else if(pgbYapilan.Value < pgbHedef.Value)
                pgbYapilan.ForeColor = Color.Blue;
            else
                pgbYapilan.ForeColor = Color.Green;

            int fark = (int)(_uye.HedefKalori - mevcutKalori);
            if(fark > 0)
            {
                lblRapor.Text = "Hedef kalorinize " + fark.ToString() + " kalori kalmıştır.";
            }
            else if(fark < 0)
            {
                fark = -1 * fark;
                lblRapor.Text = "Hedef kalorinizden " + fark.ToString() + " kalori fazla tüketmişsiniz.";
            }
            else
            {
                lblRapor.Text = "Tebrikler hedef kalorinize ulaştınız.";
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new AnaSayfaForm(_db, _uye);
            DialogResult dr = frm.ShowDialog();
        }

        private void lstbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yemekAd = lstbYemekler.GetItemText(lstbYemekler.SelectedItem);

            dgvYemekler.DataSource = _db.BesinPorsiyonlar.Where(x => x.Ad == yemekAd).ToList();
        }

        private void dtZaman_ValueChanged(object sender, EventArgs e)
        {
            lstbYemekler.Items.Clear();
            Guncelle();
        }
    }
}
