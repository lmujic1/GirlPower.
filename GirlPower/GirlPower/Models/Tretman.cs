using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Tretman : IPrototip
    {
         int id;
         string naziv;
         Kategorija kategorija;
         string opis;
         double cijena;
         int trajanje;
         bool izvrsen;

      

        public Kategorija KategorijaTretmana { get => kategorija; set => kategorija = value; }
        public string OpisTretmana { get => opis; set => opis = value; }
        public double CijenaTretmana { get => cijena; set => cijena = value; }
        public int TrajanjeTretmana { get => trajanje; set => trajanje = value; }
        public bool Izvrsen { get => izvrsen; set => izvrsen = value; }
        public string NazivTretmana { get => naziv; set=> naziv=value; }
      
        public int Id { get => id; set => id = value; }

        public IPrototip kloniraj(string naziv, string opis, double cijena)
        {

            Tretman t = new Tretman();
            return t;
            //throw new NotImplementedException();
        }
    }
}
