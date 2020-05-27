using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace GirlPower.Models
{
    public class DatumVrijemeIterator : IteratorRezervacija
    {
        private ICollection<Rezervacija> rezervacije;
        private int trenutnaRezervacija;

        public DatumVrijemeIterator(ICollection<Rezervacija> rezervacije)
        {
            this.rezervacije = rezervacije;
        }

        public Rezervacija dajSljedecuRezervaciju()
        {
            Rezervacija trenutna = rezervacije.ElementAt(trenutnaRezervacija);
            rezervacije.OrderBy((x) => x.DatumVrijeme);
            int noviIndex = rezervacije.IndexOf(trenutna);
            trenutnaRezervacija = noviIndex + 1;
            return rezervacije.ElementAt(trenutnaRezervacija);
            //throw new NotImplementedException();
        }
    }
}
