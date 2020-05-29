using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public interface Registracija
    {
        public void registrujSe(string ime, string prezime, string korisnickoIme, string lozinka, string eMailTelefon);
    }
}
