using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class Kategorija
    {
        string naziv;
        int id;

        
        public string NazivKategorije { get => naziv; set=>naziv=value;}
        public int Id { get => id; set => id = value; }
    }
}
