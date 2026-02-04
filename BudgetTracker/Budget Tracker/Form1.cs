namespace Budget_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PaivitaNaytto();
            LataaKategoriat();
        }
        DatabaseHallinta db = new DatabaseHallinta();
        private int muokattavaID = 0;
        private int klikkausLaskuri = 0;



        public void PaivitaNaytto()
        {
            dataGridView1.DataSource = null;
            var lista = db.HaeKaikkiTapahtumat();

            if (lista.Count > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = lista;
                dataGridView1.DataSource = bs;

                if (dataGridView1.Columns["ID"] != null) dataGridView1.Columns["ID"].Visible = false;
                if (dataGridView1.Columns["KategoriaID"] != null) dataGridView1.Columns["KategoriaID"].Visible = false;
                if (dataGridView1.Columns["TapahtumaNimi"] != null)
                {
                    dataGridView1.Columns["TapahtumaNimi"].HeaderText = "Tapahtuma";
                }
            }
            else
            {
                MessageBox.Show("Lista on tyhjä koodin mielestä, vaikka kannassa on dataa. Tarkista SQL-kysely!");
            }
        }
        private void LataaKategoriat()
        {
            var kategoriat = db.HaeKategoriat();

            cbKategoria.DataSource = kategoriat;
            cbKategoria.DisplayMember = "Nimi";
            cbKategoria.ValueMember = "ID";
        }
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTapahtuma.Text))
            {
                MessageBox.Show("Anna tapahtumalle nimi!");
                return;
            }
            if (!decimal.TryParse(tbMaara.Text, out decimal summa))
            {
                MessageBox.Show("Syötä summa numerona (esim. 10,50)!");
                return;
            }

            try
            {
                DateTime pvm = dateTimePicker1.Value;
                string kuvaus = tbKuvaus.Text;
                int kategoriaID = (int)cbKategoria.SelectedValue;
                db.LisaaTapahtuma(tbTapahtuma.Text, pvm, summa, kategoriaID, kuvaus);
                TyhjennaKentat();
                PaivitaNaytto();
                MessageBox.Show("Tallennettu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe tallennuksessa: " + ex.Message);
            }
        }
        private void TyhjennaKentat()
        {
            tbTapahtuma.Clear();
            tbMaara.Clear();
            tbKuvaus.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                muokattavaID = (int)row.Cells["ID"].Value;
                tbTapahtuma.Text = row.Cells["TapahtumaNimi"].Value.ToString();
                tbMaara.Text = row.Cells["Summa"].Value.ToString();
                tbKuvaus.Text = row.Cells["Kuvaus"].Value.ToString();
                dateTimePicker1.Value = (DateTime)row.Cells["Paivamaara"].Value;
                cbKategoria.Text = row.Cells["Tyyppi"].Value.ToString();
            }
        }
        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            if (muokattavaID == 0)
            {
                MessageBox.Show("Valitse ensin muokattava rivi listasta!");
                return;
            }

            if (decimal.TryParse(tbMaara.Text, out decimal summa))
            {
                try
                {
                    db.MuokkaaTapahtuma(muokattavaID, tbTapahtuma.Text, dateTimePicker1.Value,
                    summa, (int)cbKategoria.SelectedValue, tbKuvaus.Text);
                    MessageBox.Show("Muutokset tallennettu!");
                    muokattavaID = 0;
                    TyhjennaKentat();
                    PaivitaNaytto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe muokkauksessa: " + ex.Message);
                }
            }
        }
        private void btnPoista_Click(object sender, EventArgs e)
        {

            if (muokattavaID == 0)
            {
                MessageBox.Show("Valitse ensin poistettava tapahtuma listasta!");
                return;
            }
            DialogResult vastaus = MessageBox.Show("Haluatko varmasti poistaa valitun tapahtuman? Tätä tapahtumaa ei voi perua.",
                                                  "Vahvista poisto",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (vastaus == DialogResult.Yes)
            {
                try
                {
                    db.PoistaTapahtuma(muokattavaID);
                    muokattavaID = 0;
                    TyhjennaKentat();
                    PaivitaNaytto();
                    MessageBox.Show("Tapahtuma poistettu onnistuneesti.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe poistettaessa: " + ex.Message);
                }
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            PaivitaNaytto();
            
        }
    }


}
