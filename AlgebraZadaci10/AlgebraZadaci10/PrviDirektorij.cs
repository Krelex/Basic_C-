using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgebraZadaci10
{
    class PrviDirektorij
    {
        public static void Putanja (string imePutanje)
        {
            List<string> dirList = new List<string>();
            if (Directory.Exists(imePutanje))
            {
                dirList.AddRange(Directory.EnumerateDirectories(imePutanje));
                Console.WriteLine(PrviDirektorij.izvuci(dirList));
            }
            else
            {
                Console.WriteLine("Putanja ne postoji");
            }   

             
        }

        private static string izvuci(List<string> ulazna)
        {
            string izlazna = (from ime in ulazna
                              orderby ime
                              select ime).FirstOrDefault();

            return Path.GetFileName(izlazna);
        }


    }
}
