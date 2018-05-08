using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgebraZadaci;


namespace AlgebraZadaci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variajble 5.1
            /*
            int b1 = Varijable.ucitaj();
            int b2 = Varijable.ucitaj();

            Varijable.zbroj(b1, b2);              // 5.1.1
            Varijable.razlika(b1, b2); 
            Varijable.umnozak(b1, b2);            // 5.1.2
            Varijable.kvocijent(b1, b2);  
            */

            // Grananje 5.2
            /*
            Grananje.ucitaj();                    // 5.2.1
            Grananje.kalkulator();                // 5.2.2
            Grananje.veliki();                    // 5.2.3
            Grananje.znamenke();                  // 5.2.4
            Grananje.interval();                  // 5.2.5
            Grananje.dobarBroj1();                // 5.2.6
            Grananje.dobarBroj2();                // 5.2.7
            Grananje.PrijestupnaGodina();         // 5.2.8
            Grananje.CijeloBrojno();              // 5.2.9
            */

            // Petlje 5.3
            /*
            Petlje.neparni();                     // 5.3.1
            Petlje.djeljiviPet();                 // 5.3.2
            Petlje.suma();                        // 5.3.3
            Petlje.faktorijela();                 // 5.3.4
            Petlje.djeljivTri();                  // 5.3.5
            Petlje.prijestupna();                 // 5.3.6
            Petlje.ispis();                       // 5.3.7
            Petlje.koliko();                      // 5.3.8
            Petlje.djelitelj();                   // 5.3.9
            Petlje.savrsenBroj();                 // 5.3.10
            Petlje.savrseniBrojevi();             // 5.3.11
            Petlje.SumaProsijek();                // 5.3.12
            Petlje.MinMax();                      // 5.3.13
            Petlje.neparni_1_10();                // 5.3.14
            Petlje.unatrag();                     // 5.3.15
            Petlje.potencije_1();                 // 5.3.16
            Petlje.potencije_2();                 // 5.3.17
            Petlje.unosOcijene();                 // 5.3.18
            Petlje.sumaBrojeva();                 // 5.3.19
            Petlje.parNepar();                    // 5.3.20
            Petlje.zavrsni();                     // 5.3.21    */
            Petlje.kalukaltor_2();                // 5.3.22
            


            // Nizovi 6.1
            /*
            Nizovi.unosIspis();                   // 6.1.1
            Nizovi.max();                         // 6.1.2
            Nizovi.zamjenaMjesta();               // 6.1.3
            */

            // Collections 6.2
            /*
            Collections.naopako();                // 6.2.1
            Collections.parNepar();               // 6.2.2
            Collections.sort();                   // 6.2.3
            Collections.znamenke();               // 6.2.4
             */

            // Kolekcije i Metode

            // Upis i ispis svih brojeva
            List<int> brojevi = KolekcijeIMetode.unos();
            KolekcijeIMetode.ispis(brojevi);

            // Upis i ispis samo parnih brojeva
            List<int> parni = KolekcijeIMetode.dohvatiParne(brojevi);
            KolekcijeIMetode.ispis(parni,"parni");
            

            //upisi i ispis neparnih brojeva
            List<int> neparni = KolekcijeIMetode.dohvatiNeparne(brojevi);
            KolekcijeIMetode.ispis(neparni, "neparni");





            Console.ReadKey();
        }
    }
}
