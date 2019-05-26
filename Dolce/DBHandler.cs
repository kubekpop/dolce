using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolce
{
    public class DBHandler
    {
        public DBHandler(string method)
        {
            this.Method = method;
        }
        string method;
        public string Method { get => method; set => method = value; }

        public List<Rozliczenie> RecentSelector()
        {
            switch (Method)
            {
                case "MSSQL":
                    //call MSSQL class RecentSelector
                    return MSSQL.RecentSelector();
                default:
                    return new List<Rozliczenie>();
            }
        }

        public List<Osoba> PeopleSelectorId()
        {
            switch (Method)
            {
                case "MSSQL":
                    //call MSSQL class RecentSelector
                    return MSSQL.PeopleSelectorId();
                default:
                    return new List<Osoba>();
            }
        }
        public void AddRozliczenie(Rozliczenie rozliczenie)
        {
            switch (Method)
            {
                case "MSSQL":
                    MSSQL.AddRozliczenie(rozliczenie);
                    //call MSSQL class AddRozliczenie
                    break;
                default:
                    break;
            }
        }
        public Osoba OsobaSelector(int id)
        {
            return MSSQL.OsobaSelector(id);
        }
        public Rozliczenie GetRozlicznie(int id)
        {
            return MSSQL.GetRozliczenie(id);
        }
        public void UpdateRozliczenie(Rozliczenie rozliczenie)
        {
            switch (Method)
            {
                case "MSSQL":
                    MSSQL.UpdateRozliczenie(rozliczenie);
                    break;
            }
        }
    }
}
