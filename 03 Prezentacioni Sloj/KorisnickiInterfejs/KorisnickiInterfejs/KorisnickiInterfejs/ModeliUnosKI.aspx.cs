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
    public partial class ModeliUnosKI : System.Web.UI.Page
    {
        // atributi
           UnosModela objModelUnosForma;
        // konkstruktor

           private int opseg = 2000;


        // privatne metode
        private void NapuniCombo()
        {
            // citamo podatke iz prez logike koja poziva web servis

            DataSet dsPodaci = new DataSet();
            dsPodaci = objModelUnosForma.DajPodatkeZaCombo();
            // postavljanje podataka u combo
            for (int i = 0; i < dsPodaci.Tables[0].Rows.Count; i++)
            {
                ddlProizvodjac.Items.Add(dsPodaci.Tables[0].Rows[i].ItemArray[1].ToString());
            }

        }
        private void NapuniComboZaBoju()
        {
            // citamo podatke iz prez logike koja poziva web servis

            DataSet dsPodaciZaBoju = new DataSet();
            dsPodaciZaBoju = objModelUnosForma.DajPodatkeZaBoju();
            // postavljanje podataka u combo
            for (int i = 0; i < dsPodaciZaBoju.Tables[0].Rows.Count; i++)
            {
                ddlBoja.Items.Add(dsPodaciZaBoju.Tables[0].Rows[i].ItemArray[1].ToString());
            }

        }
        

        // javne metode

        protected void Page_Load(object sender, EventArgs e)
        {
            string StringKonekcije = ConfigurationManager.ConnectionStrings["NasaKonekcija"].ConnectionString;
            objModelUnosForma = new UnosModela(StringKonekcije);
            if (!IsPostBack)
            {
                NapuniCombo();
                NapuniComboZaBoju();
            }
        }

        protected void btnSnimi_Click(object sender, EventArgs e)
        {
            
            // preuzimanje vrednosti sa ki
            objModelUnosForma.IDModela = txbSifraModela.Text;
            objModelUnosForma.NazivModela = txbNazivModela.Text;
            objModelUnosForma.Motor = txbMotor.Text;
            objModelUnosForma.Godina = txbGodina.Text;
            objModelUnosForma.NazivBoje = ddlBoja.Text;
            objModelUnosForma.NazivProizvodjaca = ddlProizvodjac.Text;

            // snimanje u bp posredstvom prez logike
            bool UspehSnimanja = objModelUnosForma.SnimiPodatke();
            if (UspehSnimanja)
            {
                lblStatus.Text = "USPESNO SNIMLJENI NOVI PODACI!";
            }
            else
            {
                lblStatus.Text = "NEUSPEH SNIMANJA! Morate popuniti sva polja, voditi racuna o opsegu motora i sifri modela";
            }
        }


        protected void btnOdustani_Click(object sender, EventArgs e)
        {

        }

        protected void ddlRoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NazivProizvodjaca = ddlProizvodjac.Items[ddlProizvodjac.SelectedIndex].Text;
            //string VrednostSifreRobe = objRacunUnosForma.DajSifruRobe(NazivRobe); 
            string VrednostIDProizvodjaca = objModelUnosForma.DajSifruProizvodjaca(NazivProizvodjaca);

            // PRIKAZ VREDNOSTI
          //  lblID.Text = VrednostIDProizvodjaca;

        }

        protected void txbMotor_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlBoja_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NazivBoje = ddlBoja.Items[ddlBoja.SelectedIndex].Text;
            //string VrednostSifreRobe = objRacunUnosForma.DajSifruRobe(NazivRobe); 
            string VrednostIDBoje = objModelUnosForma.DajSifruBoje(NazivBoje);
        }
    }
}