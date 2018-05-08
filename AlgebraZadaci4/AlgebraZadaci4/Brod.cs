using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci4
{
    class Brod : Vozilo
    {
        public Brod()
        {

        }
        public Brod(string naziv, string boja, int ks, double istisnina) : base(naziv, boja, ks)
        {
            this.Istisnina = istisnina;

           
        }

        private double istisnina;

        

        public double Istisnina
        {
            get { return istisnina; }

            set
            {
                istisnina = value;

                if (NaPromjenuIstisnine != null)
                {
                    NaPromjenuIstisnine(this, EventArgs.Empty);
                }
            }
        }

        public delegate void NaPromjenuIstisnineDelegat(object sender, EventArgs e);
        public event NaPromjenuIstisnineDelegat NaPromjenuIstisnine;



    }
}
