using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Vozilo: System.Object
    {
        public string Naziv { get; set; }
        public string Boja { get; set; }
        public int KS { get; set; }

        public decimal KSToKW()
        {
            return this.KS * (decimal)0.736;
        }
    }
}
