using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Rezervacija
    {
        private Tretman tretman;
        private DateTime datumVrijeme;
        private Klijent klijent;
        private Uposlenik uposlenik;

        public Rezervacija(Tretman tretman, DateTime datumVrijeme, Klijent klijent, Uposlenik uposlenik)
        {
            this.tretman = tretman;
            this.datumVrijeme = datumVrijeme;
            this.klijent = klijent;
            this.uposlenik = uposlenik;
        }

        public Tretman Tretman { get => tretman; set => tretman = value; }
        public DateTime DatumVrijeme { get => datumVrijeme; set => datumVrijeme = value; }
        public Klijent Klijent { get => klijent; set => klijent = value; }
        public Uposlenik Uposlenik { get => uposlenik; set => uposlenik = value; }
    }
}
