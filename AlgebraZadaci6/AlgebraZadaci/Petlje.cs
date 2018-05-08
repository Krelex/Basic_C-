using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci
{
    class Petlje
    {
        // 5.3.1 Neparni do 20
        public static void neparni()
        {
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        // 5.3.2 Djeljivi s 5
        public static void djeljiviPet()
        {
            for (int i = 5; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // 5.3.3 Suma 100 brojeva
        public static void suma()
        {
            int suma = 0;
            for (int i = 1; i < 100; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);
        }

        // 5.3.4 Fakrotijela
        public static void faktorijela()
        {
            Console.WriteLine("Upisite cijeli broj");
            int broj = int.Parse(Console.ReadLine());
            int fakt = 1;

            for (int i = 1; i < broj; i++)
            {
                fakt += fakt * i;
            }

            Console.WriteLine("Faktorijela broja {0} je {1} ", broj, fakt);
        }

        // 5.3.5 Djeljiv s 3
        public static void djeljivTri()
        {
            for (int i = 3; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Broj {0} je djeljiv s 3", i);
                }
            }
        }

        // 5.3.6 Prijestupne godine
        public static void prijestupna()
        {
            for (int i = 1900; i < 2007; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                {
                    Console.WriteLine("Godina {0}. je prijestupna !", i);
                }
                else if (i % 400 == 0)
                {
                    Console.WriteLine("Godina {0}. je prijestupna!", i);
                }
                else
                {
                    Console.WriteLine("Godina {0}. nije prijestupna", i);
                }

            }
        }

        // 5.3.7 7-3 Ispis
        public static void ispis()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Brojevi koji su djeljivi za 7 a nisu sa 3 su {0} ", i);
                }
            }
        }

        // 5.3.8 7-3 Koliko
        public static void koliko()
        {
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine("BrojevA koji su djeljivi za 7 a nisu sa 3 ima {0} ", count);
        }

        // 5.3.9 Djelitelj
        public static void djelitelj()
        {
            Console.WriteLine("Unesite broj");
            int broj = int.Parse(Console.ReadLine());

            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    Console.WriteLine("Djelitelj broja {0} je broj {1}", broj, i);
                }
            }
        }

        //5.3.10 Savrsen broj
        public static void savrsenBroj()
        {
            Console.WriteLine("Unesite broj");
            int broj = int.Parse(Console.ReadLine());
            int savrsen = 0;

            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    savrsen += i;
                    if (broj == savrsen)
                    {
                        Console.WriteLine("{0} je savrsen broj", savrsen);
                    }
                    else
                    {
                        Console.WriteLine("{0} nije savrsen broj", savrsen);
                    }
                }
            }

        }

        //5.3.11 Savrseni brojevi
        public static void savrseniBrojevi()
        {

            for (int j = 1; j < 1000; j++)
            {
                int savrsen = 0;
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        savrsen += i;
                        if (j == savrsen)
                        {
                            Console.WriteLine("{0} je savrsen broj", savrsen);
                        }
                    }
                }
            }
        }

        //5.3.12 Suma i Prosijek
        public static void SumaProsijek()
        {
            int suma = 0;
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("unesite {0}. broj", i + 1);
                int broj = int.Parse(Console.ReadLine());
                suma += broj;
                count++;
            }

            Console.WriteLine("Suma unesnih broja je {0}, a njihov prosijek je {1}", suma, suma / count);
        }

        //5.3.13 Min-Max
        public static void MinMax()
        {
            Console.WriteLine("Unesite 10 prirodnih brojeva");
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int i = 0; i < 10; i++)
            {
                double broj = int.Parse(Console.ReadLine());

                if (broj < min)
                {
                    min = broj;
                }

                if (broj > max)
                {
                    max = broj;
                }
            }

            Console.WriteLine("Maximalni broj :{0} | Minimalana broj :{1}", max, min);
        }

        // 5.3.14 Neparni brojevi
        public static void neparni_1_10()
        {
            Console.WriteLine("Neprani brojevi iz intervala od 1 do 10 su {}q");
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // 5.3.15 Ispis unatrag
        public static void unatrag()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 5.3.16 Potencije 1
        public static void potencije_1()
        {
            int rac = 1;
            int broj = 2;
            while (rac < 1000)
            {
                rac = rac * broj;
                Console.WriteLine(rac);
            }
        }

        // 5.3.17 Potencije 2 
        public static void potencije_2()
        {
            int rac = 1;
            int broj = 2;
            int count = 0;
            while (count < 10)
            {
                rac = rac * broj;
                Console.WriteLine("{0}. potencija broja 2 je {1}", count + 1, rac);
                count++;
            }
        }

        // 5.3.18 Unos ocjene
        public static void unosOcijene()
        {
            Console.WriteLine("Molimo vas unestie ocijenu od 1 do 5");
            int broj = -1;
            while (broj < 0 || broj > 6)
            {
                try
                {
                    broj = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Molimo vas unesite pravi broj " + ex.Message);
                }
            }
            Console.WriteLine("Uspjesno ste unjeli broj {0}", broj);
        }

        // 5.3.19 Suma
        public static void sumaBrojeva()
        {
            Console.WriteLine("Unesite prirodan broj ili 0 kako bi prekinuli program");
            int suma = 0;
            int broj = -1;

            while (broj != 0)
            {
                try
                {
                    broj = int.Parse(Console.ReadLine());
                    suma += broj;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Molimo vas unesite cijeli broji! ERROR --> {0}", ex.Message);
                }
            }
            Console.WriteLine("Bravo unjeli ste 0, suma svih prethodno unesenih brojeva je {0}", suma);
        }

        // 5.3.20 Par-Nepar
        public static void parNepar()
        {
            Console.WriteLine("Unesite prirodan broj ili 0 kako bi prekinuli program");
            int countPar = 0;
            int countNepar = 0;
            int broj = -1;

            while (broj != 0)
            {
                try
                {
                    broj = int.Parse(Console.ReadLine());
                    if (broj == 0)
                    {
                        break;
                    } else if (broj % 2 == 0)
                    {
                        countPar++;
                    } else if (broj % 2 != 0)
                    {
                        countNepar++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Molimo vas unesite cijeli broji! ERROR --> {0}", ex.Message);
                }
            }
            Console.WriteLine("Bravo unjeli ste 0, broj parnih brojva je : {0}, a neparnih {1}", countPar, countNepar);
        }

        // 5.3.21 Zavrsni uspijeh
        public static void zavrsni()
        {
            bool on = false;
            do
            {
                try
                {
                    Console.WriteLine("Upisite broj predmeta koji ce te unositi");
                    int suma = 0;
                    int predmeti = int.Parse(Console.ReadLine());

                    for (int i = 0; i < predmeti; i++)
                    {
                        try
                        {
                            Console.Write("Unesite {0}. ocijenu : ", i + 1);
                            int unos = int.Parse(Console.ReadLine());
                            if (unos == 1 || unos == 2 || unos == 3 || unos == 4 || unos == 5)
                            {
                                suma += unos;
                            }
                            else
                            {
                                Console.WriteLine("Uspijeh je nedovoljan!!");
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Molimo vas unesite cijeli broj! ", ex.Message);
                            i--;
                        }
                    }

                    Console.WriteLine("Prosijek unesenih ocijena je {0}", ((double)suma / predmeti));
                    on = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Molim vas unesite broj koji ce predstavljati broji predmeta -->", e.Message);
                    on = true;
                }
            } while (on);
        }


        // 5.3.22 Kalukator 2
        public static void kalukaltor_2()
        {
            bool stanje = false;
            bool stanje2 = true;
            string naredba = "DA";

            try
            {
                do
                {
                    if (naredba == "DA")
                    {
                        while (stanje2)
                        {
                            try
                            {
                                Grananje.kalkulator();
                                stanje2 = false;
                                

                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("Neispravan unos probajte ponovo! ", e.Message);
                                stanje2 = true;
                            }
                        }
                    }
                    else if (naredba == "NE")
                    {
                        Console.WriteLine("Zatvaranje kalkulatora...");
                        stanje = false;
                        break;
                    }
                    Console.WriteLine("Zelite li racunati ponovo DA/NE ?");
                    naredba = Console.ReadLine().ToUpper();
                    stanje = true;
                    stanje2 = true;

                } while (stanje);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unesite ispravnu naredbu");
                stanje = true;
            }
        }
     }
}
