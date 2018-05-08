using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci2
{
    // 7.1 Podprogrami
    class Podprogram
    {
        // 7.1.1 Zbroj
        public static void zbroj()
        {

            Console.WriteLine("Unesite 2 broja:");
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je {0}", b+c);

        }

        public static void Hipotenuza()
        {
            Console.WriteLine("Unesite duzinu dviju kateta");
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Hipotenuza je {0}", hipFormula(b, c));

        }

        public static double hipFormula (int a , int b)
        {
            a = a * a;
            b = b * b;
            double c = a + b;

            return Math.Sqrt(c);

        }
    }
}
