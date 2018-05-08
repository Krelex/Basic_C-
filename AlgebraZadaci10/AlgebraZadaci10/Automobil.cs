using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci10
{
    class Automobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Zapremnina { get; set; }

        public Automobil(string marka , string model , int zapremnina)
        {
            this.Marka = marka;
            this.Model = model;
            this.Zapremnina = zapremnina;
        }

        public static void Start()
        {
            List<Automobil> auti = new List<Automobil>();

            string chek = "d";
            while (chek == "d")
            {
                Console.WriteLine("Unesite Marku Auta");
                string marka = Console.ReadLine();
                Console.WriteLine("Unesite Model Auta");
                string model = Console.ReadLine();
                Console.WriteLine("Unesite Zapremninu Auta");
                int zapremnina =int.Parse(Console.ReadLine());

                auti.Add(new Automobil(marka, model, zapremnina));

                Console.WriteLine("Zelite li unjeti novo vozilo? Press [d]");
                chek = Console.ReadLine();

            }

            auti = (from auto in auti
                    where auto.Zapremnina > 1600
                    orderby auto.Model descending
                    select auto).ToList();

            foreach (var item in auti)
            {
                if (auti.Count == 0)
                {
                    Console.WriteLine("Nazalost nije pronadeno niti jedno vozilo");
                }
                else
                {
                    Console.WriteLine("Auto je pronaden Marka : {0} Model : {1} Zapremnina  {2}", item.Marka , item.Model , item.Zapremnina) ;
                }
                
            }
        }

    }
}
