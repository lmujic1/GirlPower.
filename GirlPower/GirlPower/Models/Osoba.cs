using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public abstract class Osoba
    {
         int id;
         string ime;
         string prezime;
         string korisnickoIme;
         string lozinka;
         string eMailTelefon;

      

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string EMailTelefon { get => eMailTelefon; set => eMailTelefon = value; }
        public int Id { get => id; set => id = value; }
    }
}
