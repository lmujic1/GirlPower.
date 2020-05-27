using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Administrator : Osoba
    {
        public Administrator(string ime, string prezime, string korisnickoIme, string lozinka, string eMailTelefon) : base(ime, prezime, korisnickoIme, lozinka, eMailTelefon)
        {
        }
    }
}
