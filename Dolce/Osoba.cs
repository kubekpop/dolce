namespace Dolce
{
    public class Osoba
    {
        private string id;
        private string imie;
        private string nazwisko;
        private string pesel;

        public string Id { get => id; set => id = value; }
        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; set => pesel = value; }
    }
}