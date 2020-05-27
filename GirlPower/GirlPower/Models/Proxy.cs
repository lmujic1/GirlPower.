using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Proxy : IPravaPristupa
    {
        private int nivoPristupa = 0;
        private IPravaPristupa pravaPristupa;
        public void promijeniPravaPristupa(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme.StartsWith("AD")) nivoPristupa = 1;
            else if (korisnickoIme.StartsWith("UP")) nivoPristupa = 2;
        }
        public void dodajNoviTretman(Tretman tretman)
        {
            if (nivoPristupa == 1)
            {
                pravaPristupa.dodajNoviTretman(tretman);
            }
            else return;
        }

        public void dodajNovogUposlenika(Uposlenik uposlenik)
        {
            if (nivoPristupa == 1)
            {
                pravaPristupa.dodajNovogUposlenika(uposlenik);
            }
            else return;
        }

        public void dodajNovuKategoriju(Kategorija kategorija)
        {
            if (nivoPristupa == 1)
            {
                pravaPristupa.dodajNovuKategoriju(kategorija);
            }
            else return;
        }

        public void dodajRezervaciju(Rezervacija rezervacija)
        {
            if (nivoPristupa==1 || nivoPristupa == 2)
            {
                pravaPristupa.dodajRezervaciju(rezervacija);
            }
            else return;
        }

        public void obrisiKategoriju(Kategorija kategorija)
        {
            if (nivoPristupa == 1)
            {
                pravaPristupa.obrisiKategoriju(kategorija);
            }
            else return;
        }

        public void obrisiKlijenta(Klijent klijent)
        {
            if(nivoPristupa==1) { 
                pravaPristupa.obrisiKlijenta(klijent);
            }
            else return;
        }

        public void obrisiRezervaciju(Rezervacija rezervacija)
        {
            if (nivoPristupa == 1 || nivoPristupa == 2)
            {
                pravaPristupa.obrisiRezervaciju(rezervacija);
            }
            else return;
        }

        public void obrisiTretman(Tretman tretman)
        {
            if (nivoPristupa == 1)
            {
                pravaPristupa.obrisiTretman(tretman);
            }
            else return;
        }

        public void obrisiUposlenika(Uposlenik uposlenik)
        {
            if (nivoPristupa == 1)
            {
                pravaPristupa.obrisiUposlenika(uposlenik);
            }
            else return;
        }

       

        public void promijeniRezervaciju(Rezervacija rezervacija)
        {
            if (nivoPristupa == 1 || nivoPristupa == 2)
            {
                pravaPristupa.promijeniRezervaciju(rezervacija);
            }
            else return;
        }

        public void urediTretman(Tretman tretman)
        {
            if (nivoPristupa == 1)
            {
                pravaPristupa.urediTretman(tretman);
            }
            else return;
        }
    }
}
