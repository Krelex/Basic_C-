using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci
{
    class Nizovi
    {
       // 6.1.1 Unos-ispis
       public static void unosIspis()
        {
            int[] niz = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesite {0}. Broj: ",i+1);
                niz[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in niz)
            {
                Console.WriteLine(item);
            }
        }

       // 6.1.2 Max
       public static void max()
        {
            int[] niz = new int[5];
            int max = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesite {0}. Broj: ", i + 1);
                niz[i] = int.Parse(Console.ReadLine());

                if (niz[i] > max)
                {
                    max = niz[i];
                }
            }

            foreach (var item in niz)
            {
                if (item == max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(item);
                }else
                {
                    Console.ResetColor();
                    Console.WriteLine(item);

                }
            }
        }
       
       // 6.1.3 Zamijena Mjesta
       public static void zamjenaMjesta()
        {
            int[] niz = new int[10];
            int max = int.MinValue;
            int min = int.MinValue;
            int maxPosition = 0;
            int minPosition = 0;


            for (int i = 0; i < niz.Length ; i++)
            {
                Console.WriteLine("Unesite {0}. Broj: ", i + 1);
                niz[i] = int.Parse(Console.ReadLine());

                if (max < niz[i])
                {
                    max = niz[i];
                    maxPosition = i;
                }

                if (min > niz[i])
                {
                    min = niz[i];
                    minPosition = i;
                }
                
            }
            int zam = niz[minPosition];
            niz[minPosition] = niz[maxPosition];
            niz[maxPosition] = zam;

            foreach (int item in niz)
            {
                Console.WriteLine(item);
            }

        }
    }


}
