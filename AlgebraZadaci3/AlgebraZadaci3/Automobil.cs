using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci3
{
    class Automobil
    {
        public string MarkaAutomobila { get; set; }
        private double ks;
        public double KS
        {
          get { return ks; }

          set
            {
                if (value < 0)
                {
                    throw new Exception("Unesite pozitivnu KS-agu");
                }
                else
                {
                    this.ks = value;
                }
            }
        }
        private double osnovnaCijena;

        public double OsnovnaCijena
        {
            get { return OsnovnaCijena; }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Unesite pozitivnu cijenu automobila");
                }
                else
                {
                    this.OsnovnaCijena = value;
                }
            }
        }

        public Automobil ()
        {

        }
        public Automobil(string marka , double ks , double Osnovna) 
        {
            this.MarkaAutomobila = marka;
            this.KS = ks;
            this.OsnovnaCijena = Osnovna;
        }

        private double IznosPoreza ()
        {
            if (this.KS < 50)
            {
                return 0.05;
            }
            else if(this.KS < 150)
            {
                return 0.1;
            }
            else
            {
                return 0.15;
            }
        }

        public void UkupnaCijena()
        {
            double ukupno =this.OsnovnaCijena + (this.OsnovnaCijena * this.IznosPoreza());
            Console.WriteLine("Porez za auto sa [{0}] KS iznosi {1}%",this.KS , this.IznosPoreza() * 100);
            Console.WriteLine("Ukupna cijena vozilaza navedenu cirfu[{1}] je {0}", ukupno , this.OsnovnaCijena);
        }

        public bool validate()
        {
            if (this.OsnovnaCijena < 0)
            {
                throw new Exception("Unesite pozitivnu cijenu automobila");
            }
            else if (this.KS < 0)
            {
                throw new Exception("Unesite pozitivnu KS-agu");
            }
            else
            {
                return true;
            }
        }
    }
}
