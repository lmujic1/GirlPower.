using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Uposlenik : Osoba
    {
        [NotMapped]
        ICollection<Poruka> poruke;
       

        public void dodajPoruku (Poruka poruka)
        {
            poruke.Add(poruka);
        } 
        public ICollection<Poruka> Poruke { get => poruke; set => poruke = value; }
        
    }
}
