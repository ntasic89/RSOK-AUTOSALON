using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using KlasePodataka;

namespace PrezentacionaLogika
{
   public class ModelStampa
    {
       #region
        //ATRIBUTI
        //private string pFilter; // ulaz
        //private DataSet pPodaciZaGrid; // izlaz
        private string pStringKonekcije;
        #endregion;

        // METODE
        // konstruktor
        public ModelStampa(string NoviStringKonekcije)
        {
            //pFilter="";
            //pPodaciZaGrid = new DataSet();
            pStringKonekcije = NoviStringKonekcije;
        }

        public DataSet DajPodatkeZaGrid(string Filter)
        {
            DataSet dsPodaci = new DataSet();
            ModelDB objModelDB = new ModelDB(pStringKonekcije);
            if (Filter.Equals(""))
            {
                dsPodaci = objModelDB.DajSveModele();
            }
            else
            {
                dsPodaci = objModelDB.DajModelPoNazivu(Filter); 
            }
            return dsPodaci;
        }
    }
}
