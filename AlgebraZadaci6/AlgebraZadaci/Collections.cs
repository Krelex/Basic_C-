using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci
{
    class Collections
    {
        // 6.2.1 Naopako
        public static void naopako()
        {
            ArrayList arList = new ArrayList();
            for(int i=0; i < 10; i++)
            {
                object element = Console.ReadLine();
                arList.Add(element);
            }

            arList.Reverse();

            foreach (var item in arList)
            {
                Console.WriteLine("Elementi okrenutog niza su : {0}",item);
            }
        }

        // 6.2.2 Par-Nepar
        public static void parNepar()
        {
            List<int> Parni = new List<int>();
            List<int> Neparni = new List<int>();
            Console.WriteLine("Unesite 10 prirodnih brojeva!");

            for(int i= 0; i < 10; i++)
            {
                Console.WriteLine(" {0}. broj :",i);
                int broj = int.Parse(Console.ReadLine());

                if (broj % 2 == 0)
                {
                    Console.WriteLine("Broj je paran!");
                    Parni.Add(broj);
                }
                else
                {
                    Console.WriteLine("Broj je neparan");
                    Neparni.Add(broj);
                }
            }

            Console.WriteLine("Parni brojevi su :");
            foreach (int item in Parni)
            {
                Console.Write(" {0},",item );
            }

            Console.WriteLine("Neparni brojevi su :");
            foreach (int item in Neparni)
            {
                Console.Write(" {0},", item);
            }
        }

        // 6.2.3 Sort
        public static void sort()
        {
            int broj = -1;
            List<int> lista = new List<int>();
            while (broj != 0)
            {
                Console.WriteLine("Unesite bilo koji prirodan broji , ukoliko zelite prekinuti petlju unesite 0!");
                broj = int.Parse(Console.ReadLine());
                lista.Add(broj);
            }

            lista.Sort();

            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
        }

        // 6.2.4 Znamenke
        public static void znamenke()
        {
            Console.WriteLine("Unesite cijeli broj");
            int broj = int.Parse(Console.ReadLine());
            string sbroj = broj.ToString();
            List<char> charBroj = new List<char>();
            char[] nizC = sbroj.ToCharArray();
            var noviNiz = nizC.Reverse();


            foreach (char item in noviNiz)
            {
                Console.Write(item);
            }

            
        }
    }


}
