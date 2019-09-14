using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrezentacionaLogika;
using System.Configuration;
using KlasePodataka;

namespace KorisnickiInterfejs
{
    public partial class ModelIzmena : System.Web.UI.Page
    {
        private ModelTabelarniPrikaz pObjForma;
        private string pStringKonekcije;
        private string pSifra;

        protected void Page_Load(object sender, EventArgs e)
        {
            pStringKonekcije = ConfigurationManager.ConnectionStrings["NasaKonekcija"].ConnectionString;
            pObjForma = new ModelTabelarniPrikaz(pStringKonekcije);

            pSifra = Request.QueryString["Sifra"].ToString();
        }

        protected void btnIzmeni_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.NazivModela = txbNazivModela.Text;
            //model.SifraBoje = txbBoja.Text;
            model.Motor = txbMotor.Text;
            model.Godina = txbGodina.Text;
          

            pObjForma.IzmeniModel(pSifra, model);
        }

        
    }
}