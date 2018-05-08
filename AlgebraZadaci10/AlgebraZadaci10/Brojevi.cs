using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci10
{
    class Brojevi
    {
        public static void Brojii()
        {
            int chek = 1;
            List<int> skup = new List<int>();

            while (chek != 0)
            {
                Console.WriteLine("Unesite broj , za prekid unesite 0!");
                chek =int.Parse(Console.ReadLine());

                if (chek == 0)
                    break;


                skup.Add(chek);
            }

            var parni = (from par in skup
                         where par % 2 == 0
                         select par).ToList();

            var neparni = (from nep in skup
                         where nep % 2 != 0
                         select nep).ToList();

            Console.WriteLine("Broji Parni unesenih brojeva je = {0} ,a broji neprani brojeva je = {1}", parni.Count , neparni.Count);


        }
    }
}
