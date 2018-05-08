using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.1 
            /*
             
            // Proizvod_8.1.1

            #region Proizvod_8.1.1
            bool chek = false;
            while (chek == false)
            {
                try
                {
                    Console.WriteLine("Unesite ime artiklav :");
                    string naziv = Console.ReadLine();
                    Console.WriteLine("Unesite cijenu artikla :");
                    double cijena = double.Parse(Console.ReadLine());
                    
                    Proizvod p1 = new Proizvod(naziv, cijena);

                    chek = p1.izracun();

                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    chek = false;
                }
            }
            #endregion

            // Automobil_8.1.2


            #region Automobil_8.1.2
            // (StackOverflowException izazvan kod pokusaja 
            // implementacije validacije u set-er "OsnovnaCijena" (kada upisem -broj) 
            // ,a identican kod u set-er "KS" (kada upisem -broj) na baca taj exception)
            bool chek2 = false;
            while ( chek2 == false)
            {
                try
                {
                    Console.WriteLine("Unesite  Marku automobila:");
                    string marka = Console.ReadLine();
                    Console.WriteLine("Unesite KS automobila :");
                    double ks = double.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite cijenu automobila :");
                    double cijena = double.Parse(Console.ReadLine());

                    Automobil a1 = new Automobil(marka, ks, cijena);

                    //chek2 = a1.validate();
                    a1.UkupnaCijena();

                    Console.ReadKey();
                    

                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                    chek2 = false;
                }

              
            }
            #endregion
            */
            // Zaposlenik_8.1.3


            #region Zaposlenik_8.1.3
            Console.WriteLine("Unesite  Ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite  Prezime:");
            string prezime = Console.ReadLine();
            Console.WriteLine("Unesite  JMBG:");
            int jmbg = int.Parse(Console.ReadLine());

            Zaposlenik z1 = new Zaposlenik(ime, prezime, jmbg);

            z1.BrojBodova = 1000;
            z1.VrijednosBoda = 10;

            Console.WriteLine(z1.NetoIzracunaPlate());
            Console.WriteLine(z1.BrutoIzracunaPlate());

            Console.ReadLine();
            #endregion






        }
    }
}
