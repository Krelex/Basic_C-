using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci4
{
    class Automobil : Vozilo
    {
        public double Ccm { get; set; }

        public override string ToString()
        {
            return "Ime automobila je : " + base.Naziv + " a KS je : " + base.KS;
        }

        public Automobil (string naziv, string boja, int ks , double cm) : base(naziv , boja , ks)
        {
            this.Ccm = cm;
        }
    }
}
