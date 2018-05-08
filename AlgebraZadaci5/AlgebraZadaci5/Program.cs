using AlgebraZadaci4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace AlgebraZadaci5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Proizvod proi = new Proizvod();
                proi.NaIzracunCijena += Proi_NaIzracunCijena;

                Console.WriteLine("Upisite naziv proizvoda");
                string naz = Console.ReadLine();
                proi.Naziv = naz;

                Console.WriteLine("Upisite osonovnu cijenu proizvoda");
                int cijena = int.Parse(Console.ReadLine());
                proi.OsnovnaCijena = cijena;

                Console.WriteLine("Upisite marzu cijenu proizvoda");
                double maza = double.Parse(Console.ReadLine());
                proi.Marza = maza;

                proi.IzracunaCijenu();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
        private static void Proi_NaIzracunCijena(object sender, EventArgs e)
        {
            Proizvod ukupno = (Proizvod)sender;
            Console.WriteLine("Ukupna cijena Prozivoda je " + ukupno.ukupna);
            Console.WriteLine("event je trigeran");
        }
    }
}
