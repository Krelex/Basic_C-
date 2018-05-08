using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci
{

    // Zadaci 5.1.1 i 5.1.2

    class Varijable
    {
      
        public static int ucitaj()
        {
            Console.WriteLine("Upisite cijeli broj : ");
            return int.Parse(Console.ReadLine());
        }

        public static void zbroj(int a, int b)
        {
            Console.WriteLine("Zbroj brojeva je :{0}", a + b);

        }

        public static void razlika(int a, int b)
        {
            Console.WriteLine("Zbroj brojeva je :{0}", a - b);
        }

        public static void umnozak(int a, int b)
        {
            Console.WriteLine("Umnozak brojeva je :{0}", a * b);
        }

        public static void kvocijent(int a, int b)
        {
            Console.WriteLine("Kvocijent brojeva je :{0}", (float)a / (float)b);
        }


    }
}
