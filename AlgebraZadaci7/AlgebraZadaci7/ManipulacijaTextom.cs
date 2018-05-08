using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace AlgebraZadaci6
{
    class ManipulacijaTextom
    {
        #region Znam u Rijeci_9.1.1
        public static void unosZnaka()
        {
            Console.WriteLine("Upisite rijec :");
            string rijec = Console.ReadLine();
            Console.WriteLine("Upisite znak");
            char znak;
            bool isChar = char.TryParse(Console.ReadLine(), out znak);
            int count = 0;

            foreach (char item in rijec)
            {
                if(item == znak)
                {
                    count++;
                }
            }

            Console.WriteLine("char [{0}] se nalazi u rijeci \"{1}\"  [{2}.] puta", znak,rijec,count);
        }
        #endregion

        #region Rijeci u Recenici 9.1.2
        public static void unosRijeci ()
        {
            Console.WriteLine("Upisite recenicu");
            string recenica = Console.ReadLine();
            Console.WriteLine("Upisite rijec");
            string rijec = Console.ReadLine();

            int count = 0;

            for (int i =0; i <= recenica.Length - rijec.Length; i++)
            {
                if (recenica.Substring(i, rijec.Length).ToLower() == rijec.ToLower())
                {
                    count++;
                }
            }
            Console.WriteLine("rijec [{0}] se nalazi u recenici \"{1}\"  [{2}.] puta", rijec, recenica, count);
         }
        #endregion

        #region Rijec u novi Red 9.1.3
        public static void NoviRed()
        {
            Console.WriteLine("Upisite recenicu");
            string recenica = Console.ReadLine();
            string[] noviRed = recenica.Split(' ');

            foreach (var item in noviRed)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Brojanje rijeci u recenici 9.1.4
        public static void BrojanjeRijeci()
        {
            Console.WriteLine("Upisite recenicu");
            string recenica = Console.ReadLine();
            string[] noviRed = recenica.Split(' ');

            Console.WriteLine("Kolcina rijeci u recenici je {0}",noviRed.Length);
          
        }
        #endregion

        #region Koliko puta se ponavlja rijec 9.1.5
        public static void PonavljanjeRijeci()
        {
            Console.WriteLine("Upisite recenicu");
            string recenica = Console.ReadLine().ToLower();
            string[] noviRed = recenica.Split(' ');
            ArrayList prviPut =new ArrayList();

            for (int i = 0; i < noviRed.Length; i++)
            {
                //prviPut.Add(noviRed.Distinct().ToArray()); 
                int count = 0;
                foreach (var item in noviRed)
                {
                    if (item == noviRed[i])
                    {
                        count++;
                    }
                }
                if (!prviPut.Contains(noviRed[i]))
                {
                    Console.WriteLine("Rijec {0} se u recenici pojavljuje {1}", noviRed[i], count);
                    prviPut.Add(noviRed[i]);
                }
            }
        }
        #endregion

        #region Palindrom 9.1.6
        public static void  Palindrom()
        {
            Console.WriteLine("Upisite recenicu");
            string recenica = Console.ReadLine();
            char[] okrenuta = recenica.ToCharArray();
            Array.Reverse(okrenuta);
            string output = new string(okrenuta);

            if( string.Equals(
                recenica.Replace(" ", string.Empty)
                .ToLower(), 
                output.Replace(" ", string.Empty.ToLower())))
                {
                     Console.WriteLine("Recenica je palindrom!");
                }
            else
                {
                     Console.WriteLine("Receninca nije palindrom!");
                }
        }
        #endregion

    }

}
