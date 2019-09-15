using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KlasePodataka
{
    public class ModelDB
    {
         // atributi

        private string pStringKonekcije;

        public ModelDB(string NoviStringKonekcije)
        
        {
            pStringKonekcije = NoviStringKonekcije; 
        }

     
        public DataSet DajSveModele()
        {

            DataSet dsPodaci = new DataSet();

            SQLConnectionString konekcija = new SQLConnectionString();

            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());
            if (Veza == null)
            {
                 return new DataSet();
            }

            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajSveModeleINazivProizv", Veza);

            if (Komanda == null)
            {
                return new DataSet();
            }

            Komanda.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }
    
        public DataSet DajModelPoNazivu(string Naziv)
        {
            DataSet dsPodaci = new DataSet();

            SQLConnectionString konekcija = new SQLConnectionString();
            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());
            if (Veza == null)
            {
                return new DataSet();
            }

            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajModelPoNazivu", Veza);

            if (Komanda == null)
            {
                return new DataSet();
            }

            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@NazivModela", SqlDbType.NVarChar).Value = Naziv;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }

        public bool SnimiNoviModel(Model objNoviModel)
        {
            // LOKALNE PROMENLJIVE UVEK NA VRHU
            int brojSlogova = 0;

            SQLConnectionString konekcija = new SQLConnectionString();
            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());
            if (Veza == null)
            {
                return false;
            }

            Veza.Open();

            SqlCommand Komanda = new SqlCommand("DodajNoviModel", Veza);
            if (Komanda == null)
            {
                return false;
            }

            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@IDModela", SqlDbType.NVarChar).Value = objNoviModel.IDModela;
            Komanda.Parameters.Add("@NazivModela", SqlDbType.NVarChar).Value = objNoviModel.NazivModela;
            Komanda.Parameters.Add("@Motor", SqlDbType.NVarChar).Value = objNoviModel.Motor;
            Komanda.Parameters.Add("@Godina", SqlDbType.NVarChar).Value = objNoviModel.Godina;
            Komanda.Parameters.Add("@SifraBoje", SqlDbType.NVarChar).Value = objNoviModel.SifraBoje;
            Komanda.Parameters.Add("@SifraProizvodjaca", SqlDbType.NVarChar).Value = objNoviModel.SifraProizvodjaca;


            brojSlogova = Komanda.ExecuteNonQuery();
            Veza.Close();
            Veza.Dispose();

            // 2. varijanta
            return (brojSlogova > 0);

        }

        public bool ObrisiModel(string IDModelaZaBrisanje)
        {
         
            int brojSlogova = 0;
           
            SQLConnectionString konekcija = new SQLConnectionString();
            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());
           // SqlConnection Veza = new SqlConnection(pStringKonekcije);

            if (Veza == null)
            {
                return false;
            }

            Veza.Open();

            SqlCommand Komanda = new SqlCommand("ObrisiModel", Veza);
            if (Komanda == null)
            {
                return false;
            }

            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@IDModela", SqlDbType.NVarChar).Value = IDModelaZaBrisanje;
            brojSlogova = Komanda.ExecuteNonQuery();
            Veza.Close();
            Veza.Dispose();

            return (brojSlogova > 0);

        }

        public DataSet DajSveModelePoID(string SifraModelaFilter)
        {
            // MOGU biti jos neke procedure, mogu SE VRATITI VREDNOSTI I U LISTU, DATA TABLE...
            DataSet dsPodaci = new DataSet();

            //SqlConnection Veza = new SqlConnection(pStringKonekcije);
            SQLConnectionString konekcija = new SQLConnectionString();
            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());

            if (Veza == null)
            {
                return new DataSet();
            }

            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajModeleIProizvodjacaPoSifriModela", Veza);

            if (Komanda == null)
            {
                return new DataSet();
            }

            Komanda.Parameters.Add("@IDModela", SqlDbType.NVarChar).Value = SifraModelaFilter;
            Komanda.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }

        public bool IzmeniModel(string idModela, Model objNoviModel)
        {
            // LOKALNE PROMENLJIVE UVEK NA VRHU
            int brojSlogova = 0;
           
           // SqlConnection Veza = new SqlConnection(pStringKonekcije);
            SQLConnectionString konekcija = new SQLConnectionString();
            SqlConnection Veza = new SqlConnection(konekcija.DajMiKonekcioniString());

            if (Veza == null)
            {
                return false;
            }

            Veza.Open();

            SqlCommand Komanda = new SqlCommand("IzmeniModel", Veza);

            if (Komanda == null)
            {
                return false;
            }

            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@StariIDModela", SqlDbType.NVarChar).Value = idModela;
            Komanda.Parameters.Add("@IDModela", SqlDbType.NVarChar).Value = idModela;
            Komanda.Parameters.Add("@NazivModela", SqlDbType.NVarChar).Value = objNoviModel.NazivModela;
            Komanda.Parameters.Add("@Motor", SqlDbType.NVarChar).Value = objNoviModel.Motor;
            Komanda.Parameters.Add("@Godina", SqlDbType.NVarChar).Value = objNoviModel.Godina;

            brojSlogova = Komanda.ExecuteNonQuery();
            Veza.Close();
            Veza.Dispose(); 

            return (brojSlogova > 0);

        }
    }
}
