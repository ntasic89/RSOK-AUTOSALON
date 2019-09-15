using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KlasePodataka.OpsteModelKlase
{
   public class KorisnikDB
    {
       // atributi
        private string pStringKonekcije;

        // konstruktor
        public KorisnikDB(string StringKonekcije)
        {
            pStringKonekcije = StringKonekcije; 
        }

        // javne metode
        public DataSet DajPodatkeKorisnika(string KorisnickoIme, string Sifra)
        {
            DataSet dsPodaci = new DataSet();
           
            SqlConnection Veza = new SqlConnection(pStringKonekcije);
            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajKorisnikePoKISifri", Veza);
            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar).Value = KorisnickoIme;
            Komanda.Parameters.Add("@Sifra", SqlDbType.NVarChar).Value = Sifra;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }
    }
}
