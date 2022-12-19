using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BE_M2_D1
{
    public class Dipendente
    {
        public int IdDipendente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CodiceFiscale { get; set; }
        public bool Coniugato { get; set; }
        public int NumeroFigli { get; set; }
        public string Mansione { get; set; }

        public static List<Dipendente> ListaDipendenti = new List<Dipendente>();

        public static List<Dipendente> GetDipendenti()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Edilizia"].ToString();
            con.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = $"Select * FROM Dipendente";
            command.Connection = con;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Dipendente Dipendente = new Dipendente();
                    Dipendente.IdDipendente = Convert.ToInt32(reader["IdDipendente"]);
                    Dipendente.Nome = reader["Nome"].ToString();
                    Dipendente.Cognome = reader["Cognome"].ToString();
                    Dipendente.CodiceFiscale = reader["CodiceFiscale"].ToString();
                    Dipendente.Coniugato = Convert.ToBoolean(reader["Coniugato"]);
                    Dipendente.NumeroFigli = Convert.ToInt32(reader["NumeroFigli"]);
                    Dipendente.Mansione = reader["Mansione"].ToString();

                    ListaDipendenti.Add(Dipendente);
                }
            }
            con.Close();

            return ListaDipendenti;
        }
    }
}