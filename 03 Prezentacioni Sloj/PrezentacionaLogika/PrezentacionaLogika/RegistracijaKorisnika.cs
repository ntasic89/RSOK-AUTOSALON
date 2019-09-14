using System;
using System.Collections.Generic;
using System.Text;
using KlasePodataka;
using System.Data;
using KlasePodataka.OpsteModelKlase;

namespace PrezentacionaLogika
{
   public class RegistracijaKorisnika
    {
         // atributi
        private string pKorisnickoIme;
        private string pSifra;
        private string pPutanjaParametara;
        private string pStringKonekcije;
                
        // konstruktor
        public RegistracijaKorisnika(string PutanjaParametara)
        {
            pPutanjaParametara = PutanjaParametara;
            SQLConnectionString objStringKonekcije = new SQLConnectionString();
            pStringKonekcije = objStringKonekcije.DajMiKonekcioniString(); 
        }

        // privatne metode

        // javne metode
        public string KorisnickoIme
        {
            get { return pKorisnickoIme; }
            set { pKorisnickoIme = value; }
        }

        public string Sifra
        {
            get { return pSifra; }
            set { pSifra = value; }
        }

        public bool PostojiKorisnik()
        {
            bool PronadjenKorisnik = false;
            DataSet dsPodaci = new DataSet();
            KorisnikDB objKorisnikDB = new KorisnikDB(pStringKonekcije);

            dsPodaci =objKorisnikDB.DajPodatkeKorisnika(this.pKorisnickoIme, this.pSifra);
            PronadjenKorisnik = (dsPodaci.Tables[0].Rows.Count > 0);

            return PronadjenKorisnik;

        }

        public string DajStatusPrijavljenogKorisnika()
        {
            string StatusPrijavljenogKorisnika = "";
            DataSet dsPodaci = new DataSet();
            KorisnikDB objKorisnikDB = new KorisnikDB(pStringKonekcije);
            dsPodaci = objKorisnikDB.DajPodatkeKorisnika(this.pKorisnickoIme, this.pSifra);
            if (dsPodaci.Tables[0].Rows.Count > 0)
            {
                StatusPrijavljenogKorisnika=dsPodaci.Tables[0].Rows[0].ItemArray[4].ToString(); 
            }
            else
            {
                StatusPrijavljenogKorisnika = "NIJE PRONADJEN KORISNIK";
            }

            return StatusPrijavljenogKorisnika;

        }


       
    }
}
