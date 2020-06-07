using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Rezervacija
    {

        int Id;
        int idTretmana;
        int idUposlenika;
        int idKlijenta;
        Tretman tretman;
        DateTime datumVrijeme;
        Klijent klijent;
        Uposlenik uposlenik;

       

        public Tretman Tretman { get => tretman; set => tretman = value; }
        public DateTime DatumVrijeme { get => datumVrijeme; set => datumVrijeme = value; }
        public Klijent Klijent { get => klijent; set => klijent = value; }
        public Uposlenik Uposlenik { get => uposlenik; set => uposlenik = value; }
        public int IdTretmana { get => idTretmana; set => idTretmana = value; }
        public int IdUposlenika { get => idUposlenika; set => idUposlenika = value; }
        public int IdKlijenta { get => idKlijenta; set => idKlijenta = value; }
        public int Id1 { get => Id; set => Id = value; }
    }
}
