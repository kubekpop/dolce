//using Dolce.DaneBazaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolce
{
    public partial class Main : Form
    {
        /*
         * Set DB method and create object
         */
        DBHandler main = new DBHandler("MSSQL");
        private void GetRecents()
        {
            List<Rozliczenie> recents = main.RecentSelector();
            for (int i = 0; i < recents.Count(); i++)
            {
                AppendMainForm(recents[i].Id, recents[i].Ile, recents[i].Komentarz, recents[i].Kto, recents[i].Komu, recents[i].Rozliczone);
            }
        }

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }
        
        private void AddNew_Click(object sender, EventArgs e)
        {
            var addNew = new AddNew(Recent);
            addNew.Show();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void Recent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        /*
         * Append data to main form, used by GetRecents()
         */
        public void AppendMainForm(int a, decimal b, string c, string d, string e, bool f)
        {
            Recent.Rows.Add(a, b, c, d, e, f);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Recent.Rows.Clear();
            //var Loading = new Loading();
            //Loading.Show();
            GetRecents();
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Recent.SelectedRows.Count == 1)
            {
                int idd = Convert.ToInt32(Recent.SelectedRows[0].Cells[0].Value);
                var edit = new Modify(idd);
                edit.Show();
            }
        }

        private void People_Click(object sender, EventArgs e)
        {
            var people = new People();
            people.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //List<int> ids = new List<int>();
            if (Recent.SelectedRows.Count == 1)
            {
                int idd = Convert.ToInt32(Recent.SelectedRows[0].Cells[0].Value);
                main.DeleteRozliczenie(idd);
                Recent.Rows.Clear();
                GetRecents();
            }
        }

       
    }
}
    