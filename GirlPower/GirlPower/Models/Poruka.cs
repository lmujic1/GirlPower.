using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Poruka
    {
        int id;
        string posiljalac;
        string primlac;
        string tekstPoruke;
        DateTime datumSlanja;

      

        public string Posiljalac { get => posiljalac; set => posiljalac = value; }
        public string Primlac { get => primlac; set => primlac = value; }
        public string TekstPoruke { get => tekstPoruke; set => tekstPoruke = value; }
        public DateTime DatumSlanja { get => datumSlanja; set => datumSlanja = value; }
        public int Id { get => id; set => id = value; }
    }
}
