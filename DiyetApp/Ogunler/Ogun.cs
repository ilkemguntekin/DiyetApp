using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Ogunler
{
    public class Ogun
    {
        public int Id { get; set; }
        public string OgunAd { get; set; }

        public List<UyeYemek> UyeYemekler { get; set; }
    }
}
