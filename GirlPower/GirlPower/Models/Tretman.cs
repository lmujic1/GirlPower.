using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Tretman : IPrototip
    {
        private string naziv;
        private Kategorija kategorija;
        private string opis;
        private double cijena;
        private int trajanje;
        private bool izvrsen;

        public Tretman(string naziv, Kategorija kategorija, string opis, double cijena, int trajanje, bool izvrsen)
        {
            this.naziv = naziv;
            this.kategorija = kategorija;
            this.opis = opis;
            this.cijena = cijena;
            this.trajanje = trajanje;
            this.izvrsen = izvrsen;
        }

        public Kategorija KategorijaTretmana { get => kategorija; set => kategorija = value; }
        public string OpisTretmana { get => opis; set => opis = value; }
        public double CijenaTretmana { get => cijena; set => cijena = value; }
        public int TrajanjeTretmana { get => trajanje; set => trajanje = value; }
        public bool Izvrsen { get => izvrsen; set => izvrsen = value; }
        private string NazivTretmana { get => naziv; set=> naziv=value; }
         
    }
}
