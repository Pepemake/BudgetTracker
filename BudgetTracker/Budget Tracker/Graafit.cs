using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace Budget_Tracker
{
    public partial class Graafit : Form
    {
        DatabaseHallinta db = new DatabaseHallinta();
        public Graafit()
        {
            InitializeComponent();
            NaytaPiirakka();
            NaytaBudjettiKayra();
        }

        private void Graafit_Load(object sender, EventArgs e)
        {

        }
        private void NaytaPiirakka()
        {
            int pid = DatabaseHallinta.KirjautunutID;
            decimal budjetti = db.HaeKayttajanBudjetti(pid);
            var tapahtumat = db.HaeProfiilinTapahtumat(pid).Where(t => t.Summa < 0).ToList();
            decimal menotYhteensa = Math.Abs(tapahtumat.Sum(t => t.Summa));
            chartPiirakka.Series.Clear();
            chartPiirakka.Titles.Clear();
            chartPiirakka.Titles.Add("Budjetin jakautuminen");
            var sarja = chartPiirakka.Series.Add("Menot");
            sarja.ChartType = SeriesChartType.Pie;
            var ryhmitelty = tapahtumat.GroupBy(t => t.TapahtumaNimi)
                                       .Select(g => new { Nimi = g.Key, Summa = Math.Abs(g.Sum(x => x.Summa)) });
            foreach (var kohde in ryhmitelty)
            {
                sarja.Points.AddXY(kohde.Nimi, (double)kohde.Summa);
            }
            if (budjetti > menotYhteensa)
            {
                int i = sarja.Points.AddXY("Jäljellä", (double)(budjetti - menotYhteensa));
                sarja.Points[i].Color = Color.LightGray;
            }

            sarja["PieLabelStyle"] = "Outside";
        }
        private void NaytaBudjettiKayra()
        {
            int pid = DatabaseHallinta.KirjautunutID;
            decimal budjetti = db.HaeKayttajanBudjetti(pid);
            var tapahtumat = db.HaeProfiilinTapahtumat(pid).OrderBy(t => t.Paivamaara).ToList();
            chartKayra.Series.Clear();
            var sarja = chartKayra.Series.Add("Budjettitaso");
            sarja.ChartType = SeriesChartType.Line;
            sarja.BorderWidth = 3;

            decimal kumulatiivinenSaldo = budjetti;
            int kerron = 0;

            foreach (var t in tapahtumat)
            {
                kumulatiivinenSaldo += t.Summa;
                int n = sarja.Points.AddXY(kerron, (double)(kumulatiivinenSaldo - budjetti));
                sarja.Points[n].AxisLabel = t.Paivamaara.ToShortDateString();

                sarja.Points[n].Color = (kumulatiivinenSaldo >= budjetti) ? Color.Green : Color.Red;
                kerron++;
            }
            chartKayra.ChartAreas[0].AxisY.StripLines.Clear();
            StripLine nollaviiva = new StripLine();
            nollaviiva.IntervalOffset = 0;
            nollaviiva.BorderColor = Color.Black;
            nollaviiva.BorderDashStyle = ChartDashStyle.Dash;
            nollaviiva.BorderWidth = 2;
            chartKayra.ChartAreas[0].AxisY.StripLines.Add(nollaviiva);
        }

        private void takaisinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suljeOhjelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
