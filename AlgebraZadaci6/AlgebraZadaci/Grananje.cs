using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci
{
    class Grananje
    {
        public static void ucitaj()
        {

            // 5.2.1 Pozitivan ili negativan broj


            Console.WriteLine("Upisite cijeli broj : ");
            int broj = int.Parse(Console.ReadLine());
            bool rjes = Grananje.pozNeg(broj);
            if (broj == 0)
            {
                Console.WriteLine("Broji je nula");
            }
            else
            {
                if (rjes == true)
                {
                    Console.WriteLine("Broji je poitivan");
                }
                else
                {
                    Console.WriteLine("Broji je negativan");

                }
            }

        }

        // 5.2.1 Pozitivan ili negativan broj
        public static bool pozNeg(int broj)
        {
            if (broj % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 5.2.2 Kalkulator
        public static void kalkulator()
        {
            Console.WriteLine("Upisite 1. cijeli broj : ");
            int broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite 2. cijeli broj : ");
            int broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite racunsku operaciju: (| + | - | * | / |) ");
            char oper = char.Parse(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    Console.WriteLine(broj1 + broj2);
                    break;

                case '-':
                    Console.WriteLine(broj1 - broj2);
                    break;

                case '*':
                    Console.WriteLine(broj1 * broj2);
                    break;

                case '/':
                    Console.WriteLine(broj1 / broj2);
                    break;

                default:
                    Console.WriteLine("Jbga error!");
                    break;
            }
        }

        // 5.2.3    Veliki Broj
        public static void veliki()
        {
            Console.WriteLine("Upisite mali ili veliki broj :D");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 3)
            {
                Console.WriteLine("Broj je velik!");
            }
            else
            {
                Console.WriteLine("Broje nije velik!");
            }
        }

        // 5.2.4 X-znamenkasti broj
        public static void znamenke()
        {
            Console.WriteLine("Upisite broji");
            int broj = int.Parse(Console.ReadLine());
            if (broj < 0)
            {
                broj = -broj;
            }
            string sBroj = broj.ToString();

            if (sBroj.Length == 1)
            {
                Console.WriteLine("Broj je jednoznamankast");
            }
            else if (sBroj.Length == 2)
            {
                Console.WriteLine("Broji je dvoznamenkast");
            }
            else if (sBroj.Length == 3)
            {
                Console.WriteLine("Broj je troznamnkast");
            }
            else if (sBroj.Length >= 4)
            {
                Console.WriteLine("Broji je cetveroznamenkast");
            }
            else
            {
                Console.WriteLine("Krivi unos");
            }

        }

        // 5.2.5 U intervalu
        public static void interval()
        {
            Console.WriteLine("Upisite broji");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 100 || broj < 200)
            {
                Console.WriteLine("u intervalu je");
            }
            else
            {
                Console.WriteLine("NIJE!");
            }
        }

        // 5.2.6 Dobar broj 1
        public static void dobarBroj1()
        {
            Console.WriteLine("Upisite broji");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 3 == 0 || broj % 5 == 0)
            {
                Console.WriteLine("broje je doabar");
            }
            else
            {
                Console.WriteLine("NIJE dobar broj!");
            }
        }

        // 5.2.7 Dobar broj 2
        public static void dobarBroj2()
        {
            Console.WriteLine("Upisite broji");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 4 == 0 && broj < 100)
            {
                Console.WriteLine("broje je doabar");
            }
            else
            {
                Console.WriteLine("NIJE dobar broj!");
            }
        }

        // 5.2.8 Prijestupna godina
        public static void PrijestupnaGodina ()
        {
            Console.WriteLine("Upisite godinu");
            int godina = int.Parse(Console.ReadLine());

            if (godina % 4 == 0 && godina % 100 != 0)
            {
                Console.WriteLine("Godina je prijestupna !");
            }
            else if (godina % 400 == 0)
            {
                Console.WriteLine("Godina je prijestupna!");
            }
            else
            {   
                Console.WriteLine("Godina nije prijestupna");
            }
        }

        // 5.2.9 Cijeloborno dijeljene 
        public static void CijeloBrojno()
        {
            int broj = int.Parse(Console.ReadLine());
            if (broj == 0)
            {
                Console.WriteLine("Broj je nula");
            }else if (broj % 2 == 0)
            {
                Console.WriteLine("Broji je Pozitivan");
            }else
            {
                Console.WriteLine("Broji je negativan");
            }

            if (broj % 3 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 3");
            }
            else
            {
                Console.WriteLine("Broji nije djeljiv s 3 ostatak je {0}", broj % 3);
            }
        }
     }
}
