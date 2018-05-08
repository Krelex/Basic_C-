namespace Racuni.Model
{
    public class Stavka
    {
        public string NazivProizvoda { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public decimal DajUkupnuCijenu()
        {
            return Kolicina * Cijena;
        }
    }
}