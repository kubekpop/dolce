using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolce
{
    public class Rozliczenie
    {
        public Rozliczenie(int id, decimal ile, Osoba kto, Osoba komu, string komentarz, bool rozliczone)
        {
            this.Id = id;
            this.Ile = ile;
            this.Id_kto = kto.Id;
            this.Id_komu = komu.Id;
            this.Komentarz = komentarz;
            this.Rozliczone = rozliczone;
            this.KtoOsoba = kto;
            this.KomuOsoba = komu;
        }
        //pseudo rozliczenie used by recents chart
        public Rozliczenie(int id, decimal ile, string kto, string komu, string komentarz, bool rozliczone)
        {
            this.Id = id;
            this.Ile = ile;
            this.Kto = kto;
            this.Komu = komu;
            this.Komentarz = komentarz;
            this.Rozliczone = rozliczone;
        }
        public Osoba KtoOsoba;
        public Osoba KomuOsoba;

        int id;
        decimal ile;
        int id_kto;
        int id_komu;
        string data;
        string dataRozliczenia;
        string komentarz;
        bool rozliczone;
        // variables used by recent selector:
        string kto;
        string komu;

        public int Id { get => id; set => id = value; }
        public decimal Ile { get => ile; set => ile = value; }
        public int Id_kto { get => id_kto; set => id_kto = value; }
        public int Id_komu { get => id_komu; set => id_komu = value; }
        public string Data { get => data; set => data = value; }
        public string DataRozliczenia { get => dataRozliczenia; set => dataRozliczenia = value; }
        public string Komentarz { get => komentarz; set => komentarz = value; }
        public bool Rozliczone { get => rozliczone; set => rozliczone = value; }
        public string Kto { get => kto; set => kto = value; }
        public string Komu { get => komu; set => komu = value; }
    }
}
