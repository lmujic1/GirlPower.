using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public interface IKreatorIteratora
    {
        public void kreirajIterator(int vrsta, ICollection<Rezervacija> rezervacije);
    }
}
