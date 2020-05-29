using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public interface ISortirajTretmane
    {
        public ICollection<Tretman> sortiraj(ICollection<Tretman> tretmani);
    }
}
