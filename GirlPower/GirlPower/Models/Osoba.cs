using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public abstract class Osoba
    {
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;
        private string eMailTelefon;

        protected Osoba(string ime, string prezime, string korisnickoIme, string lozinka, string eMailTelefon)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
            this.EMailTelefon = eMailTelefon;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string EMailTelefon { get => eMailTelefon; set => eMailTelefon = value; }
    }
}
