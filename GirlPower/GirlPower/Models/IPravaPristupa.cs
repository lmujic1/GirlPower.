using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    interface IPravaPristupa
    {
        public void dodajNovuKategoriju(Kategorija kategorija);
        public void obrisiKategoriju(Kategorija kategorija);
        public void dodajNoviTretman(Tretman tretman);
        public void urediTretman(Tretman tretman);
        public void obrisiTretman(Tretman tretman);
        public void obrisiKlijenta(Klijent klijent);
        public void dodajNovogUposlenika(Uposlenik uposlenik);

        public void obrisiUposlenika(Uposlenik uposlenik);
        public void dodajRezervaciju(Rezervacija rezervacija);
        public void promijeniRezervaciju(Rezervacija rezervacija);
        public void obrisiRezervaciju(Rezervacija rezervacija);
    }
}
