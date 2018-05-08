using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci10
{
    class Imena
    {
        public static void Pokreni()
        {
            Console.WriteLine("Program za unasanje imena ! (Program unasa imena dok ne unesete rijec \"kraj\" !)");
            List<string> imena = new List<string>();

            string chek = "";
            while(chek != "kraj")
            {
                Console.WriteLine("Unesite ime");
                chek = Console.ReadLine();

                if (chek.ToLower() == "kraj")
                    break;

                imena.Add(chek);

                imena = Imena.izvuci(imena);

            }

            Console.WriteLine("Ovu su imena koja sadrze slovo \"a\" ");
            foreach (var item in imena)
            {
                Console.WriteLine("Ime :{0}", item);
            }
        }

        private static List<string> izvuci(List<string> ulazna)
        {
            List<string> izlazna = (from ime in ulazna
                                    where ime.Contains('a') || ime.Contains('A')
                                    select ime).ToList();

            return izlazna;
        }
    }
}
