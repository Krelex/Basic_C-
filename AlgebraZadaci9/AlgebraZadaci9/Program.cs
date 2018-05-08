using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chek = true;
            while (chek)
            {
                try
                {
                    Stoperica.Pokreni();
                    chek = false;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    chek = true;
                }
            }
            

            Console.ReadKey();

            // 12.1.1

            Osoba o1 = new Osoba("Filip", "Cogelja");

            o1.datumRodenjaEvent += datumRodenjaHandler;

            o1.Rodendan = new DateTime(1994, 12, 5);
            o1.spol = Spol.Musko;

            o1.datumRodenjaEvent -= datumRodenjaHandler;

            Console.WriteLine("Ime: {0}, Prezime: {1}, Rodendan {2}, Staros {3}. Godine, Spol : {4}", o1.Ime, o1.Prezime, o1.Rodendan.ToShortDateString(), o1.starost / 365, o1.spol);

            Console.ReadKey();


        }

        public static void datumRodenjaHandler (object sender, EventArgs e)
        {
            var pok = (Osoba)sender;
            Console.WriteLine("Osoba je upisala datum rodenja [{0}]", pok.Rodendan.ToShortDateString());
        }
    }
}
