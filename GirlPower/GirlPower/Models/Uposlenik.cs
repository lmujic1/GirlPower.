using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Uposlenik : Osoba
    {
        private ICollection<Poruka> poruke;
        public Uposlenik(string ime, string prezime, string korisnickoIme, string lozinka, string eMailTelefon, ICollection<Poruka> poruke) : base(ime, prezime, korisnickoIme, lozinka, eMailTelefon)
        {
            this.Poruke = poruke;
        }

        public void dodajPoruku (Poruka poruka)
        {
            poruke.Add(poruka);
        } 
        public ICollection<Poruka> Poruke { get => poruke; set => poruke = value; }
    }
}
