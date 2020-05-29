using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class SortirajPoKategoriji : ISortirajTretmane
    {
        public ICollection<Tretman> sortiraj(ICollection<Tretman> tretmani)
        {
            tretmani.OrderBy((x) => x.KategorijaTretmana);
            return tretmani;
            //throw new NotImplementedException();
        }
    }
}
