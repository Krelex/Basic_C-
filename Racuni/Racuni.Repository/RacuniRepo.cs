using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racuni.Model;
using System.IO;

namespace Racuni.Repository
{
    public class RacuniRepo
    {
        private readonly string _baznaPutanja = Environment.CurrentDirectory + "\\Racuni\\";

        public RacuniRepo()
        {
            if(!Directory.Exists(_baznaPutanja))
            {
                Directory.CreateDirectory(_baznaPutanja);
            }
        }

        public void Spremi(Racun noviRacun)
        {
            using (FileStream fs = new FileStream(_baznaPutanja + noviRacun.BrojRacuna + ".txt", FileMode.CreateNew))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(noviRacun.BrojRacuna);
                    sw.WriteLine(noviRacun.DajIznosRacuna());
                    sw.WriteLine(noviRacun.Datum);
                    sw.WriteLine(noviRacun.Djelatnik);
                    sw.WriteLine(noviRacun.NazivKupca);
                    sw.WriteLine("----");

                    int rbr = 0;
                    foreach(Stavka st in noviRacun.Stavke)
                    {
                        rbr++;
                        sw.Write("{0}.|{1}|{2}|{3}|{4}", rbr, st.NazivProizvoda, st.Kolicina, st.Cijena, st.DajUkupnuCijenu());
                        sw.WriteLine();
                    }
                }
            }
        }

        public Racun Izvuci(int brojRacuna)
        {
            if (Directory.Exists(_baznaPutanja))
            {
                if(File.Exists(_baznaPutanja + brojRacuna + ".txt"))
                {
                    using (FileStream fs = new FileStream(_baznaPutanja + brojRacuna + ".txt", FileMode.Open))
                    {
                        using (StreamReader sw = new StreamReader(fs))
                        {
                            Racun rac = new Racun();
                            rac.BrojRacuna = sw.ReadLine();
                            sw.ReadLine();
                            rac.Datum = DateTime.Parse(sw.ReadLine());
                            rac.Djelatnik = sw.ReadLine();
                            rac.NazivKupca = sw.ReadLine();
                            sw.ReadLine();
                            while (sw.Peek() >= 0)
                            {
                                Stavka stavka = new Stavka();
                                string recenica =  sw.ReadLine();
                                string[] recStavka = recenica.Split('|');

                                for(int i=0; i< recStavka.Length; i++)
                                {
                                    if(i == 1)
                                    {
                                        stavka.NazivProizvoda = recStavka[i].Trim();
                                    }
                                    else if (i == 2)
                                    {
                                        stavka.Kolicina =decimal.Parse(recStavka[i].Trim());
                                    }
                                    else if  ( i == 3)
                                    {
                                        stavka.Cijena =decimal.Parse(recStavka[i].Trim());
                                    }
                                }

                                rac.Stavke.Add(stavka);
                            }

                            return rac;

                        }
                    }

                }
                else
                {
                    return  null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
