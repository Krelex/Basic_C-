using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 7.1 - Podprogrami
            Podprogram.zbroj();                                //7.1.1
            Podprogram.Hipotenuza();                           //7.1.2
            */

            
            // 7.2 - Funkcije
            Console.WriteLine(Funkcije.krug());                //7.2.1
            Console.WriteLine(Funkcije.jednokracan());         //7.2.2
            Console.WriteLine(Funkcije.KS_KW());               //7.2.3
            Console.WriteLine(Funkcije.CuF());                 //7.2.4


            // 7.2.5
            #region Udaljenos_7.2.5
            Console.WriteLine("Unesite kordinatu x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite kordinatu x2");
            double x2 = double.Parse(Console.ReadLine());      
            Console.WriteLine("Unesite kordinatu y1");         
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite kordinatu y2");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Funkcije.udaljenost(x1,y1,x2,y2));
            #endregion
             

            // 7.2.6
            #region ProstBroj_7.2.6
            int broj = int.Parse(Console.ReadLine());          
            Funkcije.prostBroj(broj);
            #endregion
            

            // 7.2.7
            #region prostBroj s ponavljanjem bez pucanja
            bool chek = true;
            while (chek)
            {
                try
                {
                    Console.WriteLine("Unesite neki broj : ");
                    int broj2 = int.Parse(Console.ReadLine());          
                    Funkcije.prostBroj(broj2);
                    bool chek2 = true;
                    while (chek2)
                    {
                        try
                        {
                            Console.WriteLine("Zelite li unjeti novi broj D/N ?");

                            char DANE = char.Parse(Console.ReadLine());
                            DANE = Char.ToUpper(DANE);
                            if (DANE == 'D')
                            {
                                chek = true;
                                chek2 = false;
                            }
                            else if (DANE == 'N')
                            {
                                chek = false;
                                chek2 = false;
                            }
                            else
                            {
                                throw new System.ArgumentException("Molimo vas unesite d ili n");
                                throw new System.FormatException("Molimo vas unesite d ili n");
                            }
                        }
                        catch (ArgumentException ex2)
                        {
                            Console.WriteLine(ex2.Message);
                            chek2 = true;
                        }
                        catch (FormatException ex2)
                        {
                            Console.WriteLine(ex2.Message);
                            chek2 = true;
                        }

                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Unesite prirodni broj!" + ex.Message);
                    chek = true;
                }
            }
            #endregion

            // 7.2.8
            #region Fatorijel_7.2.8
            Console.WriteLine("Unesite broj :");
            int bb = int.Parse(Console.ReadLine());
            Funkcije.faktorijel(bb);

            #endregion

            // 7.2.9
            #region Prosjek_7.2.9
            Console.WriteLine("Unesite prosjek : (koristite decimalni [,] ne [.]))");
            float pros = float.Parse(Console.ReadLine());
            Funkcije.prosjek(pros);
            #endregion

    
            // 7.2.10
            #region UkupnaCijena 
            bool validate = false;
            while (validate == false)
            {
                try
                {
                    Console.WriteLine("Unesite Cijenu :");
                    double cijena = double.Parse(Console.ReadLine());
                    validate = Funkcije.validate(cijena);
                    Console.WriteLine("Ukupuna iznaos za unesenu cijenu[{0}] inzosi : {1}", cijena, Funkcije.izracun(cijena));
                }
                catch (Exception EX)
                {
                    Console.WriteLine(EX.Message);
                    validate = false;
                }
            }

            Console.ReadKey(); 
           #endregion
        }
    }
}
