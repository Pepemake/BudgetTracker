namespace Budget_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PaivitaNaytto();
        }
        DatabaseHallinta db = new DatabaseHallinta();



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
    }
}
