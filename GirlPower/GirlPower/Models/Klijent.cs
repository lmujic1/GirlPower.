using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Klijent : Osoba, IKlijentObserver
    {
        private bool registrovan;
        private ICollection<Poruka> poruke;
        private ICollection<Obavijest> obavijesti;

        public Klijent(string ime, string prezime, string korisnickoIme, string lozinka, string eMailTelefon, bool registrovan, ICollection<Poruka> poruke, ICollection<Obavijest> obavijesti) : base(ime, prezime, korisnickoIme, lozinka, eMailTelefon)
        {
            this.Registrovan = registrovan;
            this.Poruke = poruke;
            this.obavijesti = obavijesti;
        }
        public ICollection<Poruka> Poruke { get => poruke; set => poruke = value; }
        public ICollection<Obavijest> Obavijesti { get => obavijesti; set => obavijesti = value; }
        public bool Registrovan { get => registrovan; set => registrovan = value; }

        public void dodajPoruku(Poruka poruka) { Poruke.Add(poruka); }
        public void dodajObavijest(Obavijest obavijest) { obavijesti.Add(obavijest); }
        

    }
}
