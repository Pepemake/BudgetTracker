using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Budget_Tracker
{
    public class Tapahtuma
    {
        public int ID { get; set; }
        public string TapahtumaNimi { get; set; } 
        public decimal Summa { get; set; }
        public DateTime Paivamaara { get; set; }
        public string Kuvaus { get; set; }
        public string Tyyppi { get; set; } 

        public static Tapahtuma Create(SqlDataReader rdr)
        {
            return new Tapahtuma
            {
                ID = (int)rdr["ID"],
                TapahtumaNimi = rdr["TapahtumaNimi"].ToString(),
                Summa = (decimal)rdr["Summa"],
                Paivamaara = (DateTime)rdr["Paivamaara"],
                Kuvaus = rdr["Kuvaus"]?.ToString() ?? "",
                Tyyppi = rdr["Tyyppi"]?.ToString() ?? "Määrittämätön"
            };
        }
    }
}
