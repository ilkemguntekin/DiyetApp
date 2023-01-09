using DiyetApp.Besinler;
using DiyetApp.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Ogunler
{
    public class UyeYemek
    {
        public int Id { get; set; }

        public DateTime Zaman { get; set; }

        [ForeignKey("Uye")]
        public int UyeId { get; set; }

        [ForeignKey("BesinPorsiyon")]
        public int BesinId { get; set; }

        [ForeignKey("Ogun")]
        public int OgunId { get; set; }

        public Uye Uye { get; set; }
        public BesinPorsiyon Besin { get; set; }
        public Ogun Ogun { get; set; }
    }
}
