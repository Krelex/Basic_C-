using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgebraZadaci10
{
    class Program
    {
        static void Main(string[] args)
        {

            Brojevi.Brojii();
            // 11.1.1
            Imena.Pokreni();

            // 11.2.1
            PrviDirektorij.Putanja("C:\\Program Files");

            // 11.3.1
            Automobil.Start();




            Console.ReadKey();
        }
    }
}
