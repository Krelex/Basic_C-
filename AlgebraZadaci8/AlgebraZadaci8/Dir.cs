using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgebraZadaci8
{
    class Dir
    {
        public static void FindDir()
        {
            Console.WriteLine("Upisite putanju koju zelite !");
            string putanja = Console.ReadLine();
            bool postoji = Directory.Exists(putanja);

            List<string> dir = new List<string>();
            List<string> file = new List<string>();

            if (postoji)
            { 
                dir.AddRange(Directory.EnumerateDirectories(putanja));
                file.AddRange(Directory.EnumerateFiles(putanja));
            }
            else
            {
                Console.WriteLine("Nazalost putanja koju ste unjeli ne postoji!");
            }

            Console.WriteLine("Broj poddirektorija koji sadrzi navedena putanja[\"{0}\"] iznosi : {1}, a broji Datoteka koji sadrzi je {2}",putanja,dir.Count,file.Count);

            Console.WriteLine("Poddirektoriji ovog direktorija su :");
            foreach (var item in dir)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Path.GetFileName(item));
                Console.ForegroundColor = ConsoleColor.White;


            }

            Console.WriteLine("Fileovi ovog direktorija su :");
            foreach (var item in file)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Path.GetFileName(item));
                Console.ForegroundColor = ConsoleColor.White;


            }



        }
	
    }
}
