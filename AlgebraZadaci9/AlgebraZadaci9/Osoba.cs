using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci9
{
    class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        private DateTime _Rodendan;

        public DateTime Rodendan
        {
            get { return _Rodendan; }
            set
            {
                _Rodendan = value;

                TimeSpan tim = DateTime.Now - value;
                starost = (int) tim.Days;

                if (datumRodenjaEvent != null)
                {
                    datumRodenjaEvent(this, EventArgs.Empty);
                }

            }
        }

        public int starost { get; private set; }
        public Spol spol { get; set; }

        public Osoba(string ime , string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public delegate void datumRodenjaDelegat (object obj, EventArgs e);
        public event datumRodenjaDelegat datumRodenjaEvent;


    }
}
