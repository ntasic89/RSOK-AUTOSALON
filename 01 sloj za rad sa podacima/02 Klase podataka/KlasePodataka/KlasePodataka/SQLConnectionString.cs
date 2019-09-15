using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace KlasePodataka
{
   public class SQLConnectionString
    {

        // javne metode

        public  string DajPutanjuINazivFajlaDLL()
        {
             //OCITAVA PUTANJU I NAZIV FAJLA GDE SE ZAISTA NALAZI DLL U TRENUTKU IZVRSAVANJA
            string putanja = "";
            putanja = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            return putanja;
        }

        public  string DajPutanjuFajla(string CelaPutanja)
        {
            string putanja = "";

            putanja = CelaPutanja.Substring (0, CelaPutanja.LastIndexOf ("/") );  
            return putanja;
        }

        public string DajMiKonekcioniString(){


            string StringKonekcije = "";
            DataSet dsParametri = new DataSet();
            string PutanjaIzvrsavanja = "";

            PutanjaIzvrsavanja = DajPutanjuFajla(DajPutanjuINazivFajlaDLL());
            dsParametri.ReadXml(PutanjaIzvrsavanja + "\\Parametri.XML");
           
             //FORMIRANJE STRINGA KONEKCIJE
            string Host = dsParametri.Tables[0].Rows[0].ItemArray[0].ToString();
            string SQLServerInstanca = dsParametri.Tables[0].Rows[0].ItemArray[1].ToString();  //(local)\\SQLEXPRESS;
            string NazivBazePodataka = dsParametri.Tables[0].Rows[0].ItemArray[2].ToString();  //SALONAUTOMOBILA_IP;

            StringKonekcije = "Data Source=" + Host + "\\" + SQLServerInstanca + "; Initial Catalog=" + NazivBazePodataka + "; Integrated Security=True;"; // providerName='System.Data.SqlClient'";

           // StringKonekcije = "Data Source=" + "(local)\\SQLEXPRESS" + "; Initial Catalog=" + "SALONAUTOMOBILA_IP2" + "; Integrated Security=True;"; // providerName='System.Data.SqlClient'";


            return StringKonekcije;
        }



    }
}
