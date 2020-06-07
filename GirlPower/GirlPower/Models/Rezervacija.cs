using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Rezervacija
    {

        int id;
        int idTretmana;
        int idUposlenika;
        int idKlijenta;
        Tretman tretman;
        DateTime datumVrijeme;
        Klijent klijent;
        Uposlenik uposlenik;

       

        public Tretman Tretman { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public Klijent Klijent { get; set; }
        public Uposlenik Uposlenik { get; set; }
        public int IdTretmana { get; set; }
        public int IdUposlenika { get; set ; }
        public int IdKlijenta { get; set; }
        public int Id { get; set; }
    }
}
