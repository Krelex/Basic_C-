using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci3
{
    class Proizvod
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        private double Marza { get; set; }
        private double Porez { get; set; }

        public Proizvod()
        {

        }

        public Proizvod(string naziv , double cijena)
        {
            this.Naziv = naziv;
            this.Cijena = cijena;
        }

        public bool izracun()
        {
            bool chek = this.validate();
            double ukupna = this.Cijena + this.marza() + this.porez() + this.pdv();
            Console.WriteLine("Marza za artikl [{1}] iznosi {0}", this.Marza , this.Naziv);
            Console.WriteLine("Porez za artikl [{1}] iznosi {0}", this.Porez , this.Naziv);
            Console.WriteLine("Ukupna iznos za navedenu cijenu [{1}] iznosi {0} (MALOPRODAJNA CIJENA)", ukupna , this.Cijena);
            return chek;
        }

        private  bool validate()
        {
            double ulazna = this.Cijena;

            if (ulazna < 0)
            {
                throw new Exception("Unesite pozitivan broj");
            }
            else
            {
                return true;
            }
        }

        private double marza()
        {
            double ulazna = this.Cijena;

            if (ulazna <= 100)
            {
                return this.Marza = 5.5;
            }
            else if (ulazna <= 250)
            {
                return this.Marza = 9.5;
            }
            else if (ulazna <= 500 && ulazna >= 1000)
            {
                return this.Marza = 15;
            }
            else
            {
                return this.Marza = 50;
            }


        }

        private double porez()
        {
            double ulazna = this.Cijena;

            if (ulazna <= 100)
            {
                return this.Porez = ulazna * 0.02;
            }
            else if (ulazna <= 250)
            {
                return this.Porez = ulazna * 0.03;
            }
            else if (ulazna <= 500)
            {
                return this.Porez = ulazna * 0.04;
            }
            else if (ulazna <= 10)
            {
                return this.Porez = ulazna * 0.05;
            }
            else
            {
                return this.Porez = ulazna * 0.1;
            }
        }

        private double pdv()
        {
            double ulazna = this.Cijena;
            return ulazna * 0.25;
        }
    }
}
