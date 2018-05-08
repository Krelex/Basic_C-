using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racuni.Model;
using Racuni.Repository;

namespace Racuni.Konzola
{
    /// <summary>
    /// DZ: Dohvat računa sa diska i ispis po broju računa
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Racun novi;
            //Logika za unos računa
            while(true)
            {

                while (true)
                {
                    //Dohvat Racuna
                    var stari = new Racun();

                    Console.WriteLine("Zelite li dohvatiti racun [n]");
                    string stavkaDN = Console.ReadLine();
                    if (stavkaDN.ToLower() == "n")
                    {
                        break;
                    }
                    Console.WriteLine("Upisite broj racuna koji zelite dohvatit");
                    int brojRacuna = int.Parse(Console.ReadLine());
                    RacuniRepo repo2 = new RacuniRepo();
                    stari = repo2.Izvuci(brojRacuna);
                    if (stari == null)
                    {
                        Console.WriteLine("Racun ne postoji!");
                    }
                    else
                    {
                        Ispis(stari);
                    }

                }



                //Reset račun objekta
                novi = new Racun();
                Console.WriteLine("Naziv kupca:");
                novi.NazivKupca = Console.ReadLine();
                Console.WriteLine("Djelatnik:");
                novi.Djelatnik = Console.ReadLine();
                //Console.WriteLine("Datum:");
                novi.Datum = DateTime.Now;
                Console.WriteLine("Broj računa:");
                novi.BrojRacuna = Console.ReadLine();
                //TODO:Stavke
                while(true)
                {
                    Stavka st = new Stavka();
                    Console.WriteLine("Naziv proizvoda:");
                    st.NazivProizvoda = Console.ReadLine();
                    Console.WriteLine("Količina:");
                    st.Kolicina = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Cijena:");
                    st.Cijena = decimal.Parse(Console.ReadLine());

                    novi.DodajStavku(st);

                    Console.WriteLine("Želite li unositi još stavaka? [n]");
                    string stavkaDN = Console.ReadLine();
                    if (stavkaDN.ToLower() == "n")
                    {
                        break;
                    }

                }

                //Spremanje računa
                RacuniRepo repo = new RacuniRepo();
                repo.Spremi(novi);

                Console.WriteLine("Želite li ispisati račun? [d]");
                if(Console.ReadLine().ToLower() == "d")
                {
                    Ispis(novi);
                }

                Console.WriteLine("Želite li unositi još računa? [n] ");
                string racuniDN = Console.ReadLine();
                if(racuniDN.ToLower() == "n")
                {
                    break;
                }



            }
            

            Console.WriteLine("Doviđenja");
            Console.ReadKey();
            
        }

        private static void Ispis(Racun novi)
        {
            Console.WriteLine("Broj računa:{0}", novi.BrojRacuna);
            Console.WriteLine("Iznos računa:{0}", novi.DajIznosRacuna());
            Console.WriteLine("Datum:{0}", novi.Datum);
            Console.WriteLine("Djelatnik:{0}", novi.Djelatnik);
            Console.WriteLine("Kupac:{0}", novi.NazivKupca);
            Console.WriteLine("----");

            int rbr = 0;
            foreach (Stavka st in novi.Stavke)
            {
                rbr++;
                Console.Write("{0}.|{1}|{2}|{3}|{4}", rbr, st.NazivProizvoda, st.Kolicina, st.Cijena, st.DajUkupnuCijenu());
                Console.WriteLine();
            }
        }
    }
}
