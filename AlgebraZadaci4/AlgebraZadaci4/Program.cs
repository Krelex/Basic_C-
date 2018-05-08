using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static AlgebraZadaci4.Brod;


namespace AlgebraZadaci4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            char chek = 'd';

            ArrayList vozila = new ArrayList(); 
            List<Automobil> auti= new List<Automobil>(); 

            while (chek == 'd' || chek =='D')
            {
                try
                {
                    Console.WriteLine("Ukoliko zelite unjeti automobil pritisnite 1 ,a zelite li unjeti brod pritisnite 0");
                    char unos = char.Parse(Console.ReadLine());

                    if(unos == '1')
                    {
                        Console.WriteLine("Unesite Naziv , Boju , KS-u i i Ccm");
                        Console.Write("Naziv :");
                        string Naziv = Console.ReadLine();
                        Console.Write("Boja :");
                        string Boja = Console.ReadLine();
                        Console.Write("KS :");
                        int KS =int.Parse(Console.ReadLine());
                        Console.Write("Ccm :");
                        double Ccm = double.Parse(Console.ReadLine());

                        Automobil auto = new Automobil(Naziv, Boja, KS, Ccm);
                        vozila.Add(auto);
                        auti.Add(auto);

                        Console.WriteLine("Zelite li unosti jos vozila ako zelite upsiite 'd'/'D' ");
                        chek = char.Parse(Console.ReadLine());

                    }
                    else if(unos == '0')
                    {
                        Console.WriteLine("Unesite Naziv , Boju , KS-u i i Istinina");
                        Console.Write("Naziv :");
                        string Naziv = Console.ReadLine();
                        Console.Write("Boja :");
                        string Boja = Console.ReadLine();
                        Console.Write("KS :");
                        int KS = int.Parse(Console.ReadLine());
                        Console.Write("Istisnina :");
                        double Ccm = double.Parse(Console.ReadLine());
                        
                        Brod brod = new Brod();
                        brod.NaPromjenuIstisnine += new NaPromjenuIstisnineDelegat((S, E) => Console.WriteLine("Objekt broj je kreiran"));

                        brod.Naziv = Naziv;
                        brod.Boja = Boja;
                        brod.KS = KS;
                        brod.Istisnina = Ccm;



                        vozila.Add(brod);
                        Console.WriteLine("Zelite li unosti jos vozila ako zelite upsiite 'd'/'D' ");
                        chek = char.Parse(Console.ReadLine());
                        brod.NaPromjenuIstisnine -= new Brod.NaPromjenuIstisnineDelegat((S, E) => Console.WriteLine("Objekt broj je kreiran"));
                    }
                    else
                    {
                        throw new Exception("Unesite 0 ili 1");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    chek = 'd';
                }
               
                
            }

            foreach (var a1 in auti)
            {
                Console.WriteLine("Auti u Listi su" + a1.Naziv);
            }

            foreach (var v in vozila) 
            {

                Console.WriteLine("Vozila u listi su " + v);
            }
            

            
            Console.ReadKey();
            
        }

        
    }
}
