using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci2
{
    // 7.2 Funkcije
    class Funkcije
    {
        // 7.2.1 Krug
        #region Krug_7.2.1
        public static string krug()
        {
            Console.WriteLine("Unesite radius kruga");

            float r = float.Parse(Console.ReadLine());

            return string.Format("Opseg  kruga je : {0} ,a Povrsina kruga je : {1}", opseg(r), povrsina(r));
        }

        public static double opseg(float r)
        {
            float radius = r;
            double pi = Math.PI;

            return 2 * radius * pi;
        }

        public static double povrsina(float r)
        {
            float radius = r;
            double pi = Math.PI;

            radius = radius * radius;

            return radius * pi;
        }

        #endregion

        // 7.2.2 Jednokracan trokut
        #region Jednokracan trokut_7.2.2
        public static string jednokracan()
        {

            Console.WriteLine("Unesite kaktete jednokracnog trokuta {}");
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());

            return string.Format("Povrsina jednokracnog trokuta je {0}", (k1 * k2) / 2);
        }
        #endregion

        // 7.2.3 KS u KW
        #region KS u KW_7.2.3
        public static string KS_KW()
        {
            Console.WriteLine("Unesite KS :");
            double KS = double.Parse(Console.ReadLine());


            return string.Format("{0}. KS  ===> {1}. KW", KS, KS * 0.763);
        }
        #endregion

        // 7.2.4 Celzij u Fahrenheit
        #region Celzij u Fahrenheit_7.2.4
        public static string CuF()
        {
            Console.WriteLine("Unesite stupnjeve celzijusive :");
            double C = double.Parse(Console.ReadLine());

            return string.Format("{0}. C  ===> {1}. F", C, (double)(9/5*C)+32);
        }
        #endregion

        // 7.2.5 Udaljenost
        #region udaljenost_7.2.5
        public static double udaljenost(double x1 , double y1 , double x2 , double y2)
        {
            return Math.Sqrt(((x2-x1)*(x2-x1))+ ((y2 - y1) * (y2 - y1)));
        }
        #endregion

        // 7.2.6 Prost broj
        #region udaljenost_7.2.5
        public static void prostBroj(int broj)
        {

            

            if (checkProst(broj))
            {
                Console.WriteLine("Broj je prost");
            }
            else
            {
                Console.WriteLine("Broj nije prost");
            }
        }

        public static bool checkProst(int broj)
        {
            bool prost = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {

                     prost = false;

                }
                else
                {
                    prost = true;
                }
            }
            return prost;
        }
        #endregion

        // 7.2.7 Prost broj V 2.0
        #region udaljenost_7.2.5
        public static void prostBroj2(int broj)
        {
                if (checkProst(broj))
                {
                    Console.WriteLine("Broj je prost");
                }
                else
                {
                    Console.WriteLine("Broj nije prost");
                }
        }
        #endregion

        // 7.2.8 Fakrotijel
        #region faktorijel_7.2.8
        public static void faktorijel(int broj)
        {
            Console.WriteLine("Faktorije broja {1} je {0}",chekFakt(broj) , broj);
        }

        public static double chekFakt(int broj)
        {
            int broj2 = 1;
            for(int i=1; i < broj; i++)
            {
                broj2 += broj2 * i;
            }

            return broj2;
        }

        #endregion

        // 7.2.9 Prosijek
        #region prosijek_7.2.9 
        public static void prosjek(float pros)
        {
            if (pros < 1.5)
            {
                Console.WriteLine("Prosjek je NEDOVOLJAN !!");
            }else if (pros < 2.5)
            {
                Console.WriteLine("Prosjek je DOVOLJAN !!");
            }else if(pros< 3.5)
            {
                Console.WriteLine("Prosjek je DOBAR !!");
            }else if (pros < 4.5)
            {
                Console.WriteLine("Prosjek je VRLO DOBAR !!");
            }else if (pros <= 5.0)
            {
                Console.WriteLine("Prosjke je ODLICAN !!");
            }
            else
            {
                Console.WriteLine("Unjeli ste netocan prosjek!");
            }
            
        }
        #endregion

        // 7.2.10 Ukupna cijena
        #region ukupnaCijena_7.2.10
        public static double izracun(double ulazna)
        {

            double ukupna = ulazna + marza(ulazna) + porez(ulazna) + pdv(ulazna);
            return ukupna;
        }
        public static bool validate(double ulazna)
        {
            if (ulazna < 0)
            {
                throw new Exception("Unesite pozitivan broj");
            }
            else
            {
                return true;
            }
        }

        private static double marza(double ulazna)
        {
            
            if(ulazna <= 100)
            {
                return 5.5;
            }
            else if (ulazna <= 250)
            {
                return 9.5;
            }
            else if(ulazna <= 500 && ulazna >= 1000)
            {
                return 15;
            }
            else 
            {
                return 50;
            }
            
         
        }

        private static double porez(double ulazna)
        {
            if (ulazna <= 100)
            {
                return ulazna * 0.02;
            }
            else if (ulazna <= 250)
            {
                return ulazna * 0.03;
            }
            else if (ulazna <= 500)
            {
                return ulazna * 0.04;
            }
            else if (ulazna <= 10)
            {
                return ulazna * 0.05;
            }
            else
            {
                return ulazna * 0.1;
            }
        }

        private static double pdv(double ulazna)
        {
            return ulazna * 0.25;
        }
        #endregion
    }
}
