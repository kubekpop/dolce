namespace Dolce
{
    public class Osoba
    {
        public Osoba(int id, string imie, string nazwisko, string pesel)
        {
            this.Id = id;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
        }
        public override string ToString()
        {
            return Imie+" "+Nazwisko;
        }

        private int id;
        private string imie;
        private string nazwisko;
        private string pesel;
        public string FullName { get => Imie + " " + Nazwisko; }
        public int Id { get => id; set => id = value; }
        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; set => pesel = value; }
    }
}