using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KlasePodataka
{
    public class BojeDB
    {
        
        // atributi
        private string pStringKonekcije;

       
        
        public BojeDB(string NoviStringKonekcije)
        // OVO JE DOBRO JER OBAVEZUJE DA SE PRILIKOM INSTANCIRANJA OVE KLASE
        // MORA OBEZBEDITI STRING KONEKCIJE
        {
            pStringKonekcije = NoviStringKonekcije; 
        }

        public DataSet DajSveBoje()
        {
           
            DataSet dsPodaci = new DataSet();

            SQLConnectionString konekcija = new SQLConnectionString();

            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());
            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajSveBoje", Veza);
            Komanda.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }


        public DataSet DajBojuPoNazivu(string Naziv)
        {
            // MOGU biti jos neke procedure, mogu SE VRATITI VREDNOSTI I U LISTU, DATA TABLE...
            DataSet dsPodaci = new DataSet();

            SQLConnectionString konekcija = new SQLConnectionString();
            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());
            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajBojuPoNazivu", Veza);
            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@NazivBoje", SqlDbType.NVarChar).Value = Naziv;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }

        public string DajSifruBojePoNazivu(string NazivBoje)
        {
         
            DataSet dsPodaci = new DataSet();

            SQLConnectionString konekcija = new SQLConnectionString();
            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());
            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajBojuPoNazivu", Veza);
            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@NazivBoje", SqlDbType.NVarChar).Value = NazivBoje;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci.Tables[0].Rows[0].ItemArray[0].ToString();
        }
    }
}
