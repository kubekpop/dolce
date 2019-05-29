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
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            sql.CommandText = command;
            conn.Open();
            SqlDataReader rs = sql.ExecuteReader();
            List<Rozliczenie> Elements = new List<Rozliczenie>();
            while (rs.Read())
            {
                Rozliczenie temp = new Rozliczenie(Convert.ToInt32(rs[0].ToString()), Convert.ToDecimal(rs[1]), Convert.ToString(rs[6]), rs[7].ToString(), rs[2].ToString(), Convert.ToBoolean(rs[4]));
                Elements.Add(temp);
            }
            conn.Close();
            return Elements;
        }

        static public Rozliczenie GetRozliczenie(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            string command = @"SELECT * FROM Dolce.Transakcje WHERE IdTransakcji = '" + id + "'";
            sql.CommandText = command;
            conn.Open();
            SqlDataReader gr = sql.ExecuteReader();
            Rozliczenie temp = null;
            while (gr.Read())
            {
                DBHandler main = new DBHandler("MSSQL");
                int kto_id = Convert.ToInt32(gr[1]);
                Osoba kto = main.OsobaSelector(kto_id);
                int komu_id = Convert.ToInt32(gr[2]);
                Osoba komu = main.OsobaSelector(komu_id);
                temp = new Rozliczenie(Convert.ToInt32(gr[0]), Convert.ToDecimal(gr[3]), kto, komu, gr[4].ToString(), Convert.ToBoolean(gr[6]));
            }
            conn.Close();
            return temp;
        }
        static public Osoba OsobaSelector(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            string command = @"SELECT Dolce.Osoby.IdOsoby,
            Dolce.Osoby.Imie, Dolce.Osoby.Nazwisko, Dolce.Osoby.Pesel FROM Dolce.Osoby WHERE IdOsoby = '"+id+"'";

           
            conn.Open();
            sql.CommandText = command;
            SqlDataReader os = sql.ExecuteReader();
            Osoba temp = null;
            while (os.Read())
            {
                temp = new Osoba(Convert.ToInt32(os[0].ToString()), os[1].ToString(), os[2].ToString(), os[3].ToString());
            }
            conn.Close();
            return temp;
        }
        static public List<Osoba> PeopleSelectorId()
        {
            List<Osoba> Osoby = new List<Osoba>();
            string command = @"SELECT Dolce.Osoby.IdOsoby,
            Dolce.Osoby.Imie, Dolce.Osoby.Nazwisko, Dolce.Osoby.Pesel FROM Dolce.Osoby";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            sql.CommandText = command;
            conn.Open();
            SqlDataReader psi = sql.ExecuteReader();
            while (psi.Read())
            {
                Osoba temp = new Osoba(Convert.ToInt32(psi[0].ToString()), psi[1].ToString(), psi[2].ToString(), psi[3].ToString());
                Osoby.Add(temp);
            }
            conn.Close();

            return Osoby;
        }
        static public void AddRozliczenie(Rozliczenie rozliczenie)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            string command = @"INSERT INTO Dolce.Transakcje(IdKto,IdKomu,Ile,Opis) VALUES('"+rozliczenie.KtoOsoba.Id+"', '"+rozliczenie.KomuOsoba.Id+"', '"+rozliczenie.Ile+"', '"+rozliczenie.Komentarz+"')";
            sql.CommandText = command;
            conn.Open();
            sql.ExecuteReader();
            conn.Close();
        }

        static public void AddOsoba(string imie, string nazwisko, string pesel)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            string command = @"INSERT INTO Dolce.Osoby(Imie, Nazwisko, Pesel) VALUES('" + imie + "', '" + nazwisko + "', '" + pesel + "')";
            sql.CommandText = command;
            conn.Open();
            sql.ExecuteReader();
            conn.Close();
        }
        static public void EditOsoba(Osoba osoba)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            string command = @"UPDATE Dolce.Osoby " +
            "SET Imie = '" + osoba.Imie + "', Nazwisko = '" + osoba.Nazwisko + "', Pesel = '" + osoba.Pesel + "' " +
            "WHERE IdOsoby = '" + osoba.Id + "'";
            sql.CommandText = command;
            conn.Open();
            sql.ExecuteReader();
            conn.Close();
        }

        static public void UpdateRozliczenie(Rozliczenie rozliczenie)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand(null, conn);
            Console.WriteLine(rozliczenie.Id);
            string command = @"UPDATE Dolce.Transakcje "+
            "SET IdKto = "+rozliczenie.Id_kto+", IdKomu = "+rozliczenie.Id_komu+", Ile = '"+rozliczenie.Ile+"', rozliczone = '" + Convert.ToInt32(rozliczenie.Rozliczone) + 
            "' WHERE IdTransakcji = '"+rozliczenie.Id+"'";
            sql.CommandText = command;
            conn.Open();
            sql.ExecuteReader();
            conn.Close();
        }
    }
}
