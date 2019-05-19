using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolce
{
    public class DBHandler
    {
        public DBHandler (string method)
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
    }
}
