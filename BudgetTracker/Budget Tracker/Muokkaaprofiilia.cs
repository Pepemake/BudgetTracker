using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Budget_Tracker
{
    public partial class Muokkaaprofiilia : Form
    {
        DatabaseHallinta db = new DatabaseHallinta();
        public Muokkaaprofiilia()
        {
            InitializeComponent();
            PaivitaCombobox();

        }
        private void PaivitaCombobox()
        {
            List<string> nimet = db.HaeProfiilienNimet();

            cbProfiili.Items.Clear();
            foreach (string nimi in nimet)
            {
                cbProfiili.Items.Add(nimi);
            }

            if (cbProfiili.Items.Count > 0)
            {
                cbProfiili.SelectedIndex = 0;
            }
        }

        private void takaisinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (cbProfiili.SelectedItem == null)
            {
                MessageBox.Show("Valitse muokattava profiili!");
                return;
            }
            string valittuProfiili = cbProfiili.SelectedItem.ToString();
            string vanhaSalasana = tbVsalasana.Text;
            string uusiNimi = tbUnimi.Text;
            string uusiSalasana = tbUsalasana.Text;
            if (!decimal.TryParse(tbBudjetti.Text, out decimal uusiBudjetti))
            {
                MessageBox.Show("Budjetin on oltava numero!");
                return;
            }
            if (string.IsNullOrEmpty(uusiNimi) || string.IsNullOrEmpty(uusiSalasana))
            {
                MessageBox.Show("Täytä uusi nimi ja salasana!");
                return;
            }
            bool onnistui = db.MuokkaaProfiilia(valittuProfiili, vanhaSalasana, uusiNimi, uusiSalasana, uusiBudjetti);

            if (onnistui)
            {
                MessageBox.Show("Tiedot päivitetty onnistuneesti!");
                foreach (Form f in Application.OpenForms)
                {
                    if (f is Kirjautuminen k)
                    {
                        k.LataaProfiilitListaan();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Päivitys epäonnistui. Tarkista, että kirjoitit vanhan salasanan oikein.");
            }
        }
    }
}
