using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Klijent : Osoba, IKlijentObserver
    {
         int idKlijenta;
         bool registrovan;
         ICollection<Poruka> poruke;
         ICollection<Obavijest> obavijesti;

        [NotMapped]
        public ICollection<Poruka> Poruke { get => poruke; set => poruke = value; }
        [NotMapped]
        public ICollection<Obavijest> Obavijesti { get => obavijesti; set => obavijesti = value; }
        public bool Registrovan { get => registrovan; set => registrovan = value; }
        public int IdKlijenta { get => idKlijenta; set => idKlijenta = value; }

        public void dodajPoruku(Poruka poruka) { Poruke.Add(poruka); }
        public void dodajObavijest(Obavijest obavijest) { obavijesti.Add(obavijest); }

        public void update(Obavijest obavijest)
        {
            obavijesti.Add(obavijest);
            //throw new NotImplementedException();
        }
    }
}
