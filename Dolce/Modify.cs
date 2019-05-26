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
    public partial class Modify : Form
    {
        public Modify(int id)
        {
            InitializeComponent();
            IdLabelEdytujDb.Text = id.ToString();
            rozliczenie = main.GetRozlicznie(id);
            this.KtoLabelEdytujDb.Text = rozliczenie.KtoOsoba.FullName;
            this.KomuLabelEdytujDb.Text = rozliczenie.KomuOsoba.FullName;
            this.ileEdytujDb.Value = rozliczenie.Ile;
        }
        Rozliczenie rozliczenie = null;
        DBHandler main = new DBHandler("MSSQL");
        private void SaveButton_Click(object sender, EventArgs e)
        {
            rozliczenie.Ile = this.ileEdytujDb.Value;
            main.UpdateRozliczenie(rozliczenie);
        }
    }
}
