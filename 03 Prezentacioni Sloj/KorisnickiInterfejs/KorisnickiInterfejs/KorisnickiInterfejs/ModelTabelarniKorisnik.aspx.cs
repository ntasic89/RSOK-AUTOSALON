using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using PrezentacionaLogika;
using System.Data;

namespace KorisnickiInterfejs
{
    public partial class ModelTabelarniKorisnik : System.Web.UI.Page
    {
   // atributi
        private string pStringKonekcije;
        private ModelTabelarniPrikaz pObjForma;
        private DataSet dsPodaci;

        // metode
        public void PrikaziPodatkeTabelarno(DataSet dsPodaci)
        {
            gvSpisakRacuna.DataSource= dsPodaci.Tables[0];
            gvSpisakRacuna.DataBind();
        }
        

        // dogadjaji
               
        protected void Page_Load(object sender, EventArgs e)
        {
            pStringKonekcije = ConfigurationManager.ConnectionStrings["NasaKonekcija"].ConnectionString;
            pObjForma = new ModelTabelarniPrikaz(pStringKonekcije);
        }

        protected void btnFiltriraj_Click(object sender, EventArgs e)
        {
            dsPodaci = pObjForma.DajPodatkeZaGrid(txbSifraRacunaFilter.Text );
            PrikaziPodatkeTabelarno(dsPodaci);
        }

        protected void btnSvi_Click(object sender, EventArgs e)
        {
            dsPodaci = pObjForma.DajPodatkeZaGrid("");
            PrikaziPodatkeTabelarno(dsPodaci);
        }
    }
}