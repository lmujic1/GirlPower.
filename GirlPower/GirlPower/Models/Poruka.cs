using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Poruka
    {
        private string posiljalac;
        private string primlac;
        private string tekstPoruke;
        private DateTime datumSlanja;

        public Poruka(string posiljalac, string primlac, string tekstPoruke, DateTime datumSlanja)
        {
            this.Posiljalac = posiljalac;
            this.Primlac = primlac;
            this.TekstPoruke = tekstPoruke;
            this.DatumSlanja = datumSlanja;
        }

        public string Posiljalac { get => posiljalac; set => posiljalac = value; }
        public string Primlac { get => primlac; set => primlac = value; }
        public string TekstPoruke { get => tekstPoruke; set => tekstPoruke = value; }
        public DateTime DatumSlanja { get => datumSlanja; set => datumSlanja = value; }
    }
}
