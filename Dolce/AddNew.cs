using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dolce
{
    public partial class AddNew : Form
    {
        private DataGridView ostatnie;

        public AddNew(DataGridView ostatnie)
        {
            this.ostatnie = ostatnie;
            InitializeComponent();
        }
        public void DBAddRecordMSSQL()
        {
            string connectionString = "Data Source=abd.wwsi.edu.pl;Initial Catalog=!D4052019;Persist Security Info=True;User ID=d4052019;Password=wwsid405";
            SqlConnection conn = new SqlConnection(connectionString);
            string command = @"INSERT INTO Dolce.Transakcje(Kto, Komu, Ile, Komentarz)";
            SqlCommand sql = new SqlCommand(command, conn);
            conn.Open();
            SqlDataReader r = sql.ExecuteReader();
            while (r.Read())
            {
                //check for error
            }
            conn.Close();

        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            ostatnie.Rows.Add(KtoCombo.SelectedItem.ToString(), KomuCombo.SelectedItem.ToString(), Ile.Value, Opis.Text, Rozliczone.Checked);
        }
    }
}
