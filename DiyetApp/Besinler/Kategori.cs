using DiyetApp.Ogunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Besinler
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public override string ToString()
        {
            return Ad;
        }
        public List<BesinPorsiyon> BesinPorsiyonlar { get; set; }
    }
}
