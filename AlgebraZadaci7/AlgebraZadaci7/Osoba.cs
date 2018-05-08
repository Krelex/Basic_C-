using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci6
{
    class Osoba
    {
        #region Osoba 9.1.7
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime , string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public void Pozdrav()
        {
            Console.WriteLine("Dobar Dan!, {0}", this.Ime);
        }

        public string Inicijali()
        {
            string CharIme = this.Ime[0].ToString().ToUpper();
            string CharPrezime = this.Prezime[0].ToString().ToUpper();
            return string.Format("{0}. {1}.", CharIme, CharPrezime);
        }

        public string Kapitalizacija(string text)
        {
            string now = text;
            string charHolder = "";
            

            for (int i = 0; i < now.Length; i++)
            {
                if (i == 0)
                {
                    charHolder = now[0].ToString();
                    now = now.Remove(i, 1);
                    now = now.Insert(i, charHolder.ToUpper());
                }
                if(char.IsSeparator(now[i]))
                {
                    charHolder = now[i + 1].ToString();
                    now = now.Remove(i + 1, 1);
                    now = now.Insert(i + 1, charHolder.ToUpper());
                }
            }
                
            return now;
        }


            
        
            
            
            
            #endregion
    }
}
