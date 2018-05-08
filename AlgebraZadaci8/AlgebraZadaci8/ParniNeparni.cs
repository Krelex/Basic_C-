using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgebraZadaci8
{
    class ParniNeparni
    {
        public static void ParniNeparnii()
        {
            int broj = 1;

            while (broj != 0)
            {
                Console.WriteLine("Unesite Broj !");
                broj = int.Parse(Console.ReadLine());

                if (broj == 0)
                    break;


                if (broj % 2 == 0 )
                {
                    using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\parniNovo.txt", FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.Write(broj + ", ");
                        }
                    }

                    
                }
                else
                {
                    using (FileStream fs1 = new FileStream(Environment.CurrentDirectory + "\\neparni.txt", FileMode.Append))
                    {
                        using (StreamWriter sw1 = new StreamWriter(fs1))
                        {
                            sw1.WriteLine(broj);
                        }
                    }
                }
                
            }

        }
    }
}
