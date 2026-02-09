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


namespace Budget_Tracker
{
    public partial class Kirjautuminen : Form
    {
        DatabaseHallinta db = new DatabaseHallinta();
        public Kirjautuminen()
        {
            InitializeComponent();
            LataaProfiilitListaan();
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän ohjelman on luonut Perttu Airio 2026 osana Ammattikoulun kurssia");
            MessageBoxButtons buttons = MessageBoxButtons.OK;

        }


        private void tbProfiilisalasana_Enter(object sender, EventArgs e)
        {
            tbProfiilisalasana.Clear();
        }

        private void btnLuoProfiili_Click(object sender, EventArgs e)
        {
            string uusiNimi = cbKayttajat.Text.Trim();
            string uusiSalasana = tbProfiilisalasana.Text.Trim();
            decimal budjetti = 0;
            string syote = tbBudjetti.Text.Trim();

            if (!string.IsNullOrWhiteSpace(syote))
            {
                try
                {
                    string siivottuSyote = syote.Replace(',', '.').Replace(" ", "");
                    budjetti = decimal.Parse(siivottuSyote, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Budjetin muuntaminen epäonnistui. Tarkista, että kirjoitit vain numeroita.");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(uusiNimi) || string.IsNullOrWhiteSpace(uusiSalasana))
            {
                MessageBox.Show("Kirjoita haluamasi nimi valikkoon ja salasana tekstikenttään!");
                return;
            }
            if (db.LuoUusiProfiili(uusiNimi, uusiSalasana, budjetti))
            {
                MessageBox.Show($"Profiili '{uusiNimi}' luotu budjetilla {budjetti}€!");
                LataaProfiilitListaan();
                cbKayttajat.Text = uusiNimi;
                tbBudjetti.Clear();
                tbProfiilisalasana.Clear();
            }
            else
            {
                MessageBox.Show("Nimi on jo käytössä tai tapahtui virhe.");
            }
        }
        private void btnKirjaudu_Click(object sender, EventArgs e)
        {
            string nimi = cbKayttajat.Text.Trim();
            string salasana = tbProfiilisalasana.Text.Trim();
            if (string.IsNullOrWhiteSpace(nimi) || string.IsNullOrWhiteSpace(salasana))
            {
                MessageBox.Show("Syötä sekä käyttäjänimi että salasana.");
                return;
            }
            int id = db.TarkistaKirjautuminen(nimi, salasana);

            if (id > 0)
            {
                DatabaseHallinta.KirjautunutID = id;
                Form1 paaikkuna = new Form1();
                paaikkuna.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Väärä käyttäjänimi tai salasana!");
                tbProfiilisalasana.Clear();
                tbProfiilisalasana.Focus();
            }
        }
        private void LataaProfiilitListaan()
        {
            string sql = "SELECT ID, Nimi FROM Profiili";
            List<Profiili> lista = new List<Profiili>();

            using (SqlConnection conn = new SqlConnection(db.BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lista.Add(new Profiili { ID = (int)rdr["ID"], Nimi = rdr["Nimi"].ToString() });
                }
            }

            cbKayttajat.DataSource = lista;
            cbKayttajat.DisplayMember = "Nimi";
            cbKayttajat.ValueMember = "ID";
        }

        private void btnNayta_Click(object sender, EventArgs e)
        {
            tbProfiilisalasana.UseSystemPasswordChar = !tbProfiilisalasana.UseSystemPasswordChar;
            if (tbProfiilisalasana.UseSystemPasswordChar)
            {
                btnNayta.Text = "Näytä";
            }
            else
            {
                btnNayta.Text = "Piilota";
            }
        }

        private void btnPoistaprofiili_Click(object sender, EventArgs e)
        {
            string nimi = cbKayttajat.Text.Trim();
            string salasana = tbProfiilisalasana.Text.Trim();
            int id = db.TarkistaKirjautuminen(nimi, salasana);
            if (id > 0)
            {
                DialogResult vastaus = MessageBox.Show(
                    $"Haluatko varmasti poistaa profiilin '{nimi}' ja KAIKKI sen budjettitiedot?",
                    "Vahvista poisto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (vastaus == DialogResult.Yes)
                {
                    if (db.PoistaProfiili(id))
                    {
                        MessageBox.Show("Profiili poistettu.");
                        tbProfiilisalasana.Clear();
                        LataaProfiilitListaan();
                    }
                    else
                    {
                        MessageBox.Show("Poisto epäonnistui tietokantavirheen vuoksi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Väärä salasana! Profiilia ei voi poistaa ilman oikeaa salasanaa.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
