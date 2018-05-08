using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci3
{
    class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int JMBG { get; set; }
        public double BrojBodova { get; set; }
        public double VrijednosBoda { get; set; }
        public double Porez
        {
            get
            {
                if (this.NetoIzracunaPlate() < 3000)
                {
                    return 0.06;
                }
                else if (this.NetoIzracunaPlate() < 6000)
                {
                    return 0.12;
                }
                else
                {
                    return 0.20;
                }
            }
            private set { }
        }

        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime , string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }
        public Zaposlenik(string ime, string prezime, int jmbg)
        {
            this.JMBG = jmbg;
            this.Ime = ime;
            this.Prezime = prezime;
        }
        

        

        public double NetoIzracunaPlate()
        {
            return this.BrojBodova * this.VrijednosBoda;
        }

        public double BrutoIzracunaPlate()
        {
            return this.NetoIzracunaPlate() + ( this.NetoIzracunaPlate() * this.Porez);
        }


    }

}

