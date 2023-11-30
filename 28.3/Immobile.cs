using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._3
{
    internal class Immobile
    {
        public string Codice { get; set; }
        public string Indirizzo { get; set; }
        public int CAP { get; set; }
        public string Città { get; set; }
        public double Superficie { get; set; }

        public List<Box> Box { get; set; }
        public List<Appartamento> Appartamenti { get; set; }
        public List<Villa> Ville { get; set; }

    }
}
