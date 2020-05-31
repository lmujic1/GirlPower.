using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Rezervacija
    {

        private int idTretmana;
        private int idUposlenika;
        private int idKlijenta;
        private Tretman tretman;
        private DateTime datumVrijeme;
        private Klijent klijent;
        private Uposlenik uposlenik;

        public Rezervacija(int idTretmana, int idUposlenika, int idKlijenta, Tretman tretman, DateTime datumVrijeme, Klijent klijent, Uposlenik uposlenik)
        {
            this.IdTretmana = idTretmana;
            this.IdUposlenika = idUposlenika;
            this.IdKlijenta = idKlijenta;
            this.tretman = tretman;
            this.datumVrijeme = datumVrijeme;
            this.klijent = klijent;
            this.uposlenik = uposlenik;
        }

        public Tretman Tretman { get => tretman; set => tretman = value; }
        public DateTime DatumVrijeme { get => datumVrijeme; set => datumVrijeme = value; }
        public Klijent Klijent { get => klijent; set => klijent = value; }
        public Uposlenik Uposlenik { get => uposlenik; set => uposlenik = value; }
        public int IdTretmana { get => idTretmana; set => idTretmana = value; }
        public int IdUposlenika { get => idUposlenika; set => idUposlenika = value; }
        public int IdKlijenta { get => idKlijenta; set => idKlijenta = value; }
    }
}
