using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgebraZadaci8
{
    class _3or7_10_1_2
    {
        public static void a3or7()
        {
            int broj = 1;
            while (broj < 100)
            {
                if (broj % 3 == 0 || broj % 7 == 0)
                {
                    using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\3or7zares.txt", FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.Write(broj + ", ");
                        }
                    }

                    using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\3or7uNoviRed.txt", FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.WriteLine(broj);
                        }
                    }
                }
                broj++;
            }

        }
    }
}
