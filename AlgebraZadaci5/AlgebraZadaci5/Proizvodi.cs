
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci4
    {
        public class Proizvod
        {
            public string Naziv { get; set; }
            public double OsnovnaCijena { get; set; }
        public double ukupna { get; set; }

        private double marza;

            public double Marza
            {
                get { return marza; }

                set
                {
                    if (value > 0 && value < 1)
                    {
                        marza = value;
                    }
                    else
                    {
                        throw new Exception("Mazrza mora biti izmedu 0 i 1");
                    }
                }
            }

            public void IzracunaCijenu()
            {
                this.ukupna = this.OsnovnaCijena + (this.OsnovnaCijena * this.marza);

                if (NaIzracunCijena != null)
                {
                    NaIzracunCijena(this, EventArgs.Empty);
                }

            }

            public delegate void NaIzracunCijenaDelegat(object sender, EventArgs e);
            public event NaIzracunCijenaDelegat NaIzracunCijena;


        }
    }

