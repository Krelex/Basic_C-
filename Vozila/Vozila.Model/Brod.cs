using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Brod: Vozilo
    {
        #region Events
        public delegate void PromjenaIstisnineDelegat(decimal stara, decimal nova);
        public event PromjenaIstisnineDelegat PromjenaIstisnineEvent;
        #endregion
        private decimal _istisnina;

        public decimal Istisnina
        {
            get { return _istisnina; }
            set
            {
                if (PromjenaIstisnineEvent != null)
                {
                    PromjenaIstisnineEvent(_istisnina, value);
                }
                _istisnina = value;
            }
        }

        public string Detalji()
        {
            return string.Format("Naziv:{0}, Boja:{2}, KS:{1}, Istisnina:{3} ", base.Naziv, base.KS, base.Boja, this.Istisnina);

        }

        public override string ToString()
        {
            return string.Format("Naziv:{0}, Boja:{2}, KS:{1}, Istisnina:{3} ", base.Naziv, base.KS, base.Boja, this.Istisnina);

        }

    }
}
