using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public interface IKlijentObserver
    {
        public void update(Obavijest obavijest);
    }
}
