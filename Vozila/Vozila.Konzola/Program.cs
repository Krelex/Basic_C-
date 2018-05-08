using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Model;

namespace Vozila.Konzola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            //Vozilo wartburg = new Vozilo();

            List<Automobil> automobili = new List<Automobil>();

            List<Vozilo> vozila = new List<Vozilo>();
            Automobil auto = new Automobil();
            auto.Naziv = "Trabant";
            vozila.Add(auto);

            Brod br = new Brod();
            br.Naziv = "Bayliner";
            vozila.Add(br);

            foreach(Vozilo vz in vozila)
            {
                Console.WriteLine(vz.Naziv);
            }

            Console.ReadKey();
        }
    }
}
