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
        DBHandler main = new DBHandler("MSSQL");
        public AddNew(DataGridView ostatnie)
        {
            this.ostatnie = ostatnie;
            InitializeComponent();
            List<Osoba> ppl = main.PeopleSelector();
            for (int i = 0; i < ppl.Count(); i++)
            {
                KtoCombo.Items.Add(ppl[i]);
            }
        }



        private void Dodaj_Click(object sender, EventArgs e)
        {
            Osoba tmp = (Osoba)KtoCombo.SelectedItem;
            Opis.Text = tmp.Id.ToString();
            //ostatnie.Rows.Add(KtoCombo.SelectedItem.ToString(), KomuCombo.SelectedItem.ToString(), Ile.Value, Opis.Text, Rozliczone.Checked);
        }
    }
}
