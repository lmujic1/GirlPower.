using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public interface IPrototip
    {
        public IPrototip kloniraj(string naziv, string opis, double cijena);
    }
}
