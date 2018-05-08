using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci6
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba o1 = new Osoba("Filip", "Cogelja");

            o1.Pozdrav();

            Console.WriteLine(o1.Inicijali());

            Console.WriteLine("Upisite recenicu :");
            string recenica = Console.ReadLine();
            Console.WriteLine(o1.Kapitalizacija(recenica));


            // 9.1.1
            ManipulacijaTextom.unosZnaka();

            // 9.1.2
            ManipulacijaTextom.unosRijeci();

            // 9.1.3
            ManipulacijaTextom.NoviRed();

            // 9.1.4
            ManipulacijaTextom.BrojanjeRijeci();

            // 9.1.5
            ManipulacijaTextom.PonavljanjeRijeci();

            // 9.1.6
            ManipulacijaTextom.Palindrom();

            // 9.1.7
            

            Console.ReadKey();
        }
    }
}
