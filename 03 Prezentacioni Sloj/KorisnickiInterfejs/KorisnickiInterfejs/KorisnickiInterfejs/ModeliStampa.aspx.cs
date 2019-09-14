using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrezentacionaLogika;
using System.Data;
using System.Configuration;

namespace KorisnickiInterfejs
{
    public partial class ModeliStampa : System.Web.UI.Page
    {
        // atributi
        private string pStringKonekcije;
        private ModelTabelarniPrikaz pObjForma;
        private DataSet dsPodaci;

        // metode
        public void PrikaziPodatkeTabelarno(DataSet dsPodaci)
        {
            gvSpisakRacuna.DataSource = dsPodaci.Tables[0];
            gvSpisakRacuna.DataBind();
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            pStringKonekcije = ConfigurationManager.ConnectionStrings["NasaKonekcija"].ConnectionString;
            pObjForma = new ModelTabelarniPrikaz(pStringKonekcije);

            string filter = "";
            try
            {
                filter = Request.QueryString["filter"].ToString();
            }
            catch (Exception)
            {

            }
            
            dsPodaci = pObjForma.DajPodatkeZaGrid(filter);
            PrikaziPodatkeTabelarno(dsPodaci);
        }

        protected void gvSpisakRacuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}