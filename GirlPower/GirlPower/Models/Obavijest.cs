using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Obavijest
    {

        public enum TipObavijesti {
            HitanSlucaj,
                Popust}
        private string posiljalac;
        private string primalac;
        private string porukaObavijesti;
        private DateTime datumSlanja;
        private TipObavijesti tip;

        public Obavijest(string posiljalac, string primalac, string porukaObavijesti, DateTime datumSlanja, TipObavijesti tip)
        {
            this.posiljalac = posiljalac;
            this.primalac = primalac;
            this.porukaObavijesti = porukaObavijesti;
            this.datumSlanja = datumSlanja;
            this.tip = tip;
        }

        public string Primalac { get => primalac; set => primalac = value; }
       
        public DateTime DatumSlanja { get => datumSlanja; set => datumSlanja = value; }
       
        public string Posiljalac { get => posiljalac; set => posiljalac = value; }
        public string PorukaObavijesti { get => porukaObavijesti; set => porukaObavijesti = value; }
        private TipObavijesti Tip { get => tip; set => tip = value; }
    }
}
