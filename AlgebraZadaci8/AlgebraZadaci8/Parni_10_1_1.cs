using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgebraZadaci8
{
    class Parni_10_1_1
    {
        public static void Parni ()
        {
            int broj = 1;
            while(broj < 100)
            {
                if(broj % 2 == 0)
                {
                    using (FileStream fs = new FileStream(Environment.CurrentDirectory+"\\Parni.txt",FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.Write(broj+", ");
                        }
                    }
                }
                broj++;
            }

            using (var fs2 = new FileStream(Environment.CurrentDirectory+"\\Parni.txt",FileMode.Open))
            {
                using (var sr2 = new StreamReader(fs2))
                {
                    while (!sr2.EndOfStream)
                    {
                        Console.WriteLine(sr2.ReadLine());

                    }
                }
            }
        }
    }
}
