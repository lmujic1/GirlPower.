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
                Popust,
            NoviTretman}

        int id;
        string posiljalac;
        string primalac;
        string porukaObavijesti;
        DateTime datumSlanja;
        TipObavijesti tip;

        


        public string Primalac { get => primalac; set => primalac = value; }
       
        public DateTime DatumSlanja { get => datumSlanja; set => datumSlanja = value; }
       
        public string Posiljalac { get => posiljalac; set => posiljalac = value; }
        public string PorukaObavijesti { get => porukaObavijesti; set => porukaObavijesti = value; }
        public TipObavijesti Tip { get => tip; set => tip = value; }
    }
}
