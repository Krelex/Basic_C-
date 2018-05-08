using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racuni.Model
{
    public class Racun
    {
        public string NazivKupca { get; set; }
        public string Djelatnik { get; set; }
        public DateTime Datum { get; set; }
        public string BrojRacuna { get; set; }
        public List<Stavka> Stavke { get; set; }

        public Racun()
        {
            Stavke = new List<Stavka>();
        }

        public void DodajStavku(Stavka novaStavka)
        {
            this.Stavke.Add(novaStavka);
        }

        public decimal DajIznosRacuna()
        {
            decimal iznos = 0;

            foreach(var stavka in Stavke)
            {
                iznos += stavka.DajUkupnuCijenu();
            }

            return iznos;
        }

    }
}
