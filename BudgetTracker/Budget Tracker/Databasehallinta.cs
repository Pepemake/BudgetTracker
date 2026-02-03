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

        private string BudgetTracker = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=BudjettiDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        public List<Tapahtuma> HaeKaikkiTapahtumat()
        {
            List<Tapahtuma> lista = new List<Tapahtuma>();
            string sql = @"SELECT t.ID, t.TapahtumaNimi, t.Summa, t.Paivamaara, t.Kuvaus, t.KategoriaID, 
                      k.Nimi AS Tyyppi 
               FROM Tapahtuma t
               LEFT JOIN Kategoria k ON t.KategoriaID = k.ID
               ORDER BY t.Paivamaara DESC";
            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(Tapahtuma.Create(rdr));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ongelma tietokannassa: " + ex.Message);
                }
            } 

            return lista;
        }

    }
}
