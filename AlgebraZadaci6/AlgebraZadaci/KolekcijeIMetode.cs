using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci
{
    class KolekcijeIMetode
    {
        //1. Unos brojeva dok ne unesemo 0
        //2. Ispis svih brojeva
        //3. Dohvat parnih brojeva
        //4. Ispis parnih brojeva
        //DZ
        //5. Dohvat svih neparnih brojeva pomoću funkcije
        //6. Ispis svih neparnih brojeva
        //7. Svi neparni brojevi kod ispisa moraju biti plavi. :)

        // Metoda za unos brojva
        public static List<int> unos()
        {
            Console.WriteLine("Unosite brojeve sve dok ne upisite 0");
            List<int> brojevi = new List<int>();
            int broj = -1;
            while (broj != 0)
            {   

                broj = int.Parse(Console.ReadLine());
                if(broj == 0)
                {
                    break;
                }
                brojevi.Add(broj);
            }

            return brojevi;
        }

        // Metoda ispis() za ispis svih brojva sa 1 parametrom
        public static void ispis(List<int> brojevi)
        {
            Console.WriteLine("Brojevi koje smo unjeli su: ");
            foreach (int item in brojevi)
            {
                Console.WriteLine(item);
            }
        }

        // Metoda ispis() za ispis parnih ili neparnih brojva ovisno o rezulatatu drugog parametra
        public static void ispis(List<int> brojevi, string ime)
        {
            if (ime == "parni")
            {
                Console.WriteLine("Parni brojevi koje smo unjeli su: ");
                foreach (int item in brojevi)
                {
                    Console.WriteLine(item);
                }
            }
            else if (ime == "neparni")
            {
                Console.WriteLine("Neparni brojevi koje smo unjeli su: ");
                foreach (int item in brojevi)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(item);
                }
            }else
            {
                Console.WriteLine("Unjeli ste krivu kljucnu rijc na drugi parametar");
            }
        }

        
        // Metoda za dohvacanje parnih elementa iz vec posoojece kolekcije
        public static List<int> dohvatiParne(List<int> brojevi) 
        {
            List<int> novaLista = new List<int>();
            foreach (int item in brojevi)
            {
                if(item % 2 == 0)
                {
                    novaLista.Add(item);
                }
            }

            return novaLista;
        }

        // Metoda za dohvacanje neparnih elementa iz vec postojece kolekcije
        public static List<int> dohvatiNeparne(List<int> brojevi)
        {
            List<int> novaLista = new List<int>();
            foreach (int item in brojevi)
            {
                if (item % 2 != 0)
                {
                    novaLista.Add(item);
                }
            }

            return novaLista;
        }
    }
}
