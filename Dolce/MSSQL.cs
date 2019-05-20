using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace Dolce
{
    static class MSSQL
    {
        static string connectionString = "Data Source=abd.wwsi.edu.pl;Initial Catalog=!D4052019;Persist Security Info=True;User ID=d4052019;Password=wwsid405";
        static SqlConnection conn = new SqlConnection(connectionString);
        static public List<Rozliczenie> RecentSelector()
        {
            string command = @"SELECT Dolce.Transakcje.IdTransakcji, 
            Dolce.Transakcje.Ile, 
            Dolce.Transakcje.Opis, 
            Dolce.Transakcje.Data, 
            Dolce.Transakcje.rozliczone, 
            Dolce.Transakcje.DataRozliczenia, 
            KtoOsoby.Imie + ' ' + KtoOsoby.Nazwisko AS KTO, 
            KomuOsoby.Imie + ' ' + KomuOsoby.Nazwisko AS Komu
            FROM Dolce.Transakcje INNER JOIN
            Dolce.Osoby AS KtoOsoby ON Dolce.Transakcje.IdKto = KtoOsoby.IdOsoby INNER JOIN
            Dolce.Osoby AS KomuOsoby ON Dolce.Transakcje.IdKomu = KomuOsoby.IdOsoby";
            SqlCommand sql = new SqlCommand(command, conn);
            conn.Open();
            SqlDataReader r = sql.ExecuteReader();
            List<Rozliczenie> Elements = new List<Rozliczenie>();
            while (r.Read())
            {
                Rozliczenie temp = new Rozliczenie(Convert.ToInt32(r[0].ToString()), Convert.ToDecimal(r[1]), Convert.ToString(r[6]), r[7].ToString(), r[2].ToString(), Convert.ToBoolean(r[4]));
                Elements.Add(temp);
            }
            conn.Close();
            return Elements;
        }
        static public List<Osoba> PeopleSelector()
        {
            List<Osoba> Osoby = new List<Osoba>();
            string command = @"SELECT Dolce.Osoby.IdOsoby,
            Dolce.Osoby.Imie + ' ' + Dolce.Osoby.Nazwisko AS Kto
            FROM Dolce.Osoby";
            SqlCommand sql = new SqlCommand(command, conn);
            conn.Open();
            SqlDataReader r = sql.ExecuteReader();
            while (r.Read())
            {
                Osoba temp = new Osoba(Convert.ToInt32(r[0].ToString()), r[1].ToString());
                Osoby.Add(temp);
            }
            conn.Close();

            return Osoby;
        }
        static public void AddRozliczenie()
        {
            //string command = @"INSERT INTO "
        }
    }
}
