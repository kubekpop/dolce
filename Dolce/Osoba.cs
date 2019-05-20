namespace Dolce
{
    public class Osoba
    {
        public Osoba(int id, string nazwa)
        {
            this.Id = id;
            this.Fullname = nazwa;
        }

        public override string ToString()
        {
            return Fullname;
        }

        private int id;
        private string imie;
        private string nazwisko;
        private string pesel;
        private string fullname;

        public int Id { get => id; set => id = value; }
        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; set => pesel = value; }
        public string Fullname { get => fullname; set => fullname = value; }
    }
}