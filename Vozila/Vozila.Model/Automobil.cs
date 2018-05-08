using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Automobil: Vozilo
    {
        public decimal Ccm { get; set; }

        public override string ToString()
        {
            return string.Format("Naziv:{0}, Boja:{2}, KS:{1}, Ccm:{3} ", base.Naziv, base.KS, base.Boja, this.Ccm);
        }
    }
}
