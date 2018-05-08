using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci9
{
    class Stoperica
    {
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        private TimeSpan _Razlika;

        public TimeSpan Razlika
        {
            get { return _Razlika; }
            set
            {

                _Razlika = value;
            }
        }
        public static void Pokreni()
        {
            Stoperica stoperica = new Stoperica();

            Console.WriteLine("Upisite slovo S za pocetak stoperice");
            char slovoStart = char.Parse(Console.ReadLine().ToUpper());

            stoperica.Pocetak(slovoStart);

            Console.WriteLine("Upisite slovo S za kraj stoperice");
            char slovoKraj = char.Parse(Console.ReadLine().ToUpper());

            stoperica.Kraj(slovoKraj);

            Console.WriteLine("Proteklo vrijeme = {0} Sec!", stoperica.Vrijeme().Seconds);

        }
        public void Pocetak(char slovoStart)
        {
            if (slovoStart == 'S')
            {
                this.Start = DateTime.Now;
                Console.WriteLine("Vrijeme je krenulo {0}", this.Start.ToLongTimeString());
            }
            else
            {
                throw new Exception("Molimo vas unesite slovo \"s\" za pocetak stopanja!");
            }
        }

        public void Kraj(char slovoKraj)
        {
            if (slovoKraj == 'S')
            {
                this.Stop = DateTime.Now;
                Console.WriteLine("Vrijeme je stalo {0}", this.Stop.ToLongTimeString());
            }
            else
            {
                throw new Exception("Molimo vas unesite slovo \"s\" za kraj stopanja!");
            }
        }


        public TimeSpan Vrijeme()
        {
            return this.Razlika = this.Stop - this.Start;
        }
    }
}
