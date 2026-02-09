using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Budget_Tracker
{
    public class DatabaseHallinta
    {

        public string BudgetTracker = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=BudjettiDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        // Be sure to switch Initial Catalog to the Database of your choice, query can be found on the SQLQuery1.SQL
        public static int KirjautunutID;
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
        public void LisaaTapahtuma(string nimi, DateTime pvm, decimal summa, int kategoriaID, string kuvaus, int profiiliID)
        {
            string sql = @"INSERT INTO Tapahtuma (TapahtumaNimi, Paivamaara, Summa, KategoriaID, Kuvaus, ProfiiliID) 
                   VALUES (@nimi, @pvm, @summa, @kid, @kuvaus, @pid)";

            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nimi", nimi);
                cmd.Parameters.AddWithValue("@pvm", pvm);
                cmd.Parameters.AddWithValue("@summa", summa);
                cmd.Parameters.AddWithValue("@kid", kategoriaID);
                cmd.Parameters.AddWithValue("@kuvaus", kuvaus);
                cmd.Parameters.AddWithValue("@pid", profiiliID);
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

        public bool LuoUusiProfiili(string nimi, string salasana, decimal budjetti)
        {
            string sql = "INSERT INTO Profiili (Nimi, Salasana, Kuukausibudjetti) VALUES (@nimi, @pass, @budjetti)";
            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nimi", nimi);
                    cmd.Parameters.AddWithValue("@pass", salasana);
                    cmd.Parameters.AddWithValue("@budjetti", budjetti); // Uusi parametri
                    conn.Open();
                    int rivit = cmd.ExecuteNonQuery();
                    return rivit > 0;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) return false;
                    throw;
                }
            }
        }
        public List<Tapahtuma> HaeProfiilinTapahtumat(int pid)
        {
            List<Tapahtuma> lista = new List<Tapahtuma>();
            string sql = @"SELECT t.ID, t.TapahtumaNimi, t.Summa, t.Paivamaara, t.Kuvaus, t.KategoriaID,  
                          k.Nimi AS Tyyppi  
                   FROM Tapahtuma t
                   LEFT JOIN Kategoria k ON t.KategoriaID = k.ID
                   WHERE t.ProfiiliID = @pid
                   ORDER BY t.Paivamaara DESC";

            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", pid);
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lista.Add(Tapahtuma.Create(rdr));
                    }
                }
            }
            return lista;
        }
        public int TarkistaKirjautuminen(string nimi, string salasana)
        {
            string sql = "SELECT ID FROM Profiili WHERE Nimi = @nimi AND Salasana = @pass";

            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nimi", nimi);
                cmd.Parameters.AddWithValue("@pass", salasana);

                try
                {
                    conn.Open();
                    object tulos = cmd.ExecuteScalar(); // AI Slop

                    if (tulos != null && tulos != DBNull.Value)
                    {
                        return Convert.ToInt32(tulos); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Virhe kirjautumisessa: " + ex.Message);
                }
            }
            return 0; 
        }
        public bool PaivitaProfiili(int id, string uusiNimi, string uusiSalasana, decimal uusiBudjetti)
        {
            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                string sql = "UPDATE Profiili SET Nimi = @nimi, Salasana = @pass, Kuukausibudjetti = @budjetti WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nimi", uusiNimi);
                cmd.Parameters.AddWithValue("@pass", uusiSalasana);
                cmd.Parameters.AddWithValue("@budjetti", uusiBudjetti);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe päivityksessä: " + ex.Message);
                    return false;
                }
            }
        }
        public bool PoistaProfiili(int profiiliID) // AI Slop
        {
            string sqlTapahtumat = "DELETE FROM Tapahtuma WHERE ProfiiliID = @pid";
            string sqlProfiili = "DELETE FROM Profiili WHERE ID = @pid";

            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction(); 

                try
                {
                    SqlCommand cmd1 = new SqlCommand(sqlTapahtumat, conn, trans);
                    cmd1.Parameters.AddWithValue("@pid", profiiliID);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(sqlProfiili, conn, trans);
                    cmd2.Parameters.AddWithValue("@pid", profiiliID);
                    cmd2.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    Console.WriteLine("Virhe poistossa: " + ex.Message);
                    return false;
                }
            }
        }
        public DataTable HaeTapahtumatAikavalilla(int profiiliID, DateTime alku, DateTime loppu)
        {
            DataTable dt = new DataTable();
            DateTime loppuKlo = loppu.Date.AddDays(1).AddTicks(-1);
            string sql = @"SELECT ID, TapahtumaNimi, Summa, Paivamaara, Kuvaus 
                   FROM Tapahtuma 
                   WHERE ProfiiliID = @pid 
                   AND Paivamaara BETWEEN @alku AND @loppu 
                   ORDER BY Paivamaara DESC";

            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", profiiliID);
                cmd.Parameters.AddWithValue("@alku", alku.Date);
                cmd.Parameters.AddWithValue("@loppu", loppuKlo);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Virhe haussa: " + ex.Message);
                }
            }
            return dt;
        }
        public decimal HaeKayttajanBudjetti(int profiiliID)
        {
            decimal budjetti = 0;
            string sql = "SELECT Kuukausibudjetti FROM Profiili WHERE ID = @pid";
            using (SqlConnection conn = new SqlConnection(BudgetTracker))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", profiiliID);
                try
                {
                    conn.Open();
                    object tulos = cmd.ExecuteScalar();

                    if (tulos != null && tulos != DBNull.Value)
                    {
                        budjetti = Convert.ToDecimal(tulos);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe budjetin haussa: " + ex.Message);
                }
            }
            return budjetti;
        }
    }
}
