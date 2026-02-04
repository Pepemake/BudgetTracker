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
        // Be sure to switch Initial Catalog to the Database of your choice, query can be found on the SQLQuery1.SQL
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
        public List<Kategoria> HaeKategoriat()
        {
            List<Kategoria> lista = new List<Kategoria>();
            string sql = "SELECT ID, Nimi FROM Kategoria";

            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lista.Add(new Kategoria
                        {
                            ID = (int)rdr["ID"],
                            Nimi = rdr["Nimi"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
        public void LisaaTapahtuma(string nimi, DateTime pvm, decimal summa, int kategoriaID, string kuvaus)
        {
            string sql = @"INSERT INTO Tapahtuma (TapahtumaNimi, Paivamaara, Summa, KategoriaID, Kuvaus) 
                   VALUES (@nimi, @pvm, @summa, @kid, @kuvaus)";

            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nimi", nimi);
                cmd.Parameters.AddWithValue("@pvm", pvm);
                cmd.Parameters.AddWithValue("@summa", summa);
                cmd.Parameters.AddWithValue("@kid", kategoriaID);
                cmd.Parameters.AddWithValue("@kuvaus", kuvaus);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void MuokkaaTapahtuma(int id, string nimi, DateTime pvm, decimal summa, int kategoriaID, string kuvaus)
        {
            string sql = @"UPDATE Tapahtuma 
            SET TapahtumaNimi = @nimi, Paivamaara = @pvm, Summa = @summa, 
            KategoriaID = @kid, Kuvaus = @kuvaus 
            WHERE ID = @id";
            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nimi", nimi);
                cmd.Parameters.AddWithValue("@pvm", pvm);
                cmd.Parameters.AddWithValue("@summa", summa);
                cmd.Parameters.AddWithValue("@kid", kategoriaID);
                cmd.Parameters.AddWithValue("@kuvaus", kuvaus);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void PoistaTapahtuma(int id)
        {
            string sql = "DELETE FROM Tapahtuma WHERE ID = @id";
            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
