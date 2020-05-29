using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class SortirajPoCijeni : ISortirajTretmane
    {
        public ICollection<Tretman> sortiraj(ICollection<Tretman> tretmani)
        {
            tretmani.OrderBy((x) => x.CijenaTretmana);
            return tretmani;
            //throw new NotImplementedException();
        }
    }
}
