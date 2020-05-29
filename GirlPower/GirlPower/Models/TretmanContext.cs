using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class TretmanContext
    {
        private ISortirajTretmane sort = new SortirajPoKategoriji();
        public ICollection<Tretman> soritrajPoFilteru(ICollection<Tretman> tretmani, string filter)
        {
            return sort.sortiraj(tretmani);
        }
        public void promijeniFilter(string filter)
        {
            if (filter.Equals("kategorija")) sort = new SortirajPoKategoriji();
            else sort = new SortirajPoCijeni();
        }

    }
}
