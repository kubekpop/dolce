using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolce
{
    public partial class Summary : Form
    {
        DBHandler main = new DBHandler("MSSQL");
        public Summary()
        {
            InitializeComponent();
            List<Osoba> ppl = main.PeopleSelectorId();
            Osoba1Combo.Items.Clear();
            Osoba2Combo.Items.Clear();

            for (int i = 0; i < ppl.Count(); i++)
            {
                Osoba1Combo.Items.Add(ppl[i]);
                Osoba2Combo.Items.Add(ppl[i]);
            }

        }

        private void LiczButton_Click(object sender, EventArgs e)
        {
            Osoba osoba1 = (Osoba)Osoba1Combo.SelectedItem;
            Osoba osoba2 = (Osoba)Osoba2Combo.SelectedItem;

            this.IleHajsu.Text = main.GetSummary(osoba1, osoba2).ToString();
        }
    }
}
