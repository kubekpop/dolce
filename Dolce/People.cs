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
    public partial class People : Form
    {
        DBHandler main = new DBHandler("MSSQL");
        public People()
        {
            InitializeComponent();

            List<Osoba> ppl = main.PeopleSelectorId();
            this.OsobaCombo.Items.Clear();
            this.OsobaCombo.Items.Add("<nowa>");
            this.OsobaCombo.SelectedIndex = 0;
            for (int i = 0; i < ppl.Count(); i++)
            {
                OsobaCombo.Items.Add(ppl[i]);
            }
            this.Imie.Select();
            /*
             * textbox1.Select(textbox1.Text.Length,0);
             * Sets the cursor to the end of the text in yout textbox.
             */
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(OsobaCombo.SelectedItem.ToString() == "<nowa>")
            {
                main.AddOsoba(this.Imie.Text.ToString(), this.Nazwisko.Text.ToString(), this.Pesel.Text.ToString());
            }
            else
            {
                Osoba osoba = (Osoba)this.OsobaCombo.SelectedItem;
                osoba.Imie = this.Imie.Text.ToString();
                osoba.Nazwisko = this.Nazwisko.Text.ToString();
                osoba.Pesel = this.Pesel.Text.ToString();
                main.EditOsoba(osoba);
            }
            this.Close();
        }
        /*
        private void OsobaCombo_TabIndexChanged(object sender, EventArgs e)
        {
            Osoba osoba = (Osoba)this.OsobaCombo.SelectedItem;
            this.Imie.Text = osoba.Imie;
            this.Nazwisko.Text = osoba.Nazwisko;
            this.Pesel.Text = osoba.Pesel;

        }
        */
        private void OsobaCombo_TextChanged(object sender, EventArgs e)
        {
            if (OsobaCombo.SelectedItem.ToString() != "<nowa>")
            {
                Osoba osoba = (Osoba)this.OsobaCombo.SelectedItem;
                this.Imie.Text = osoba.Imie;
                this.Nazwisko.Text = osoba.Nazwisko;
                this.Pesel.Text = osoba.Pesel;
            }
        }
    }
}
