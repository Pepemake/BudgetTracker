using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Budget_Tracker
{
    public class DatabaseHallinta
    {
        
        private string BudgetTracker = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=BudgetTracker;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection dbYhteys;

        private bool AvaaYhteys()
        {
            try
            {
                dbYhteys = new SqlConnection(BudgetTracker);
                dbYhteys.Open();
                return true;
            }
            catch { return false; }
        }

        private void SuljeYhteys() => dbYhteys?.Close();

        public List<Tapahtuma> HaeKaikkiTapahtumat()
        {
            List<Tapahtuma> lista = new List<Tapahtuma>();
            string sql = @"SELECT t.*, k.Nimi AS KategoriaNimi 
                           FROM Tapahtuma t
                           INNER JOIN Kategoria k ON t.KategoriaID = k.ID
                           ORDER BY t.Paivamaara DESC";

            if (AvaaYhteys())
            {
                SqlCommand cmd = new SqlCommand(sql, dbYhteys);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lista.Add(Tapahtuma.Create(rdr));
                }
                SuljeYhteys();
            }
            return lista;
        }
    }
}
