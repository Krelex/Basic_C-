using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci4
{
    class Vozilo
    {
        public string Naziv { get; set; }
        public string Boja { get; set; }
        public int KS { get; set; }

        public double KS_to_KW()
        {
            return this.KS * 0.736;
        }
        
        public Vozilo()
        {

        }

        public Vozilo(string naziv , string boja , int ks)
        {
            this.Naziv = naziv;
            this.Boja = boja;
            this.KS = ks;
        }
    }
}
