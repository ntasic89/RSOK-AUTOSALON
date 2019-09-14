using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrezentacionaLogika;

namespace KorisnickiInterfejs
{
    public partial class Login : System.Web.UI.Page
    {
        // atributi
        RegistracijaKorisnika objLoginForma;

        // konstruktor


        // dogadjaji
        protected void Page_Load(object sender, EventArgs e)
        {
            string PutanjaParametara = HttpContext.Current.Server.MapPath("~") + "bin\\"; //Parametri.XML ";
            objLoginForma = new RegistracijaKorisnika(PutanjaParametara);

        }

        protected void btnPrijava_Click(object sender, EventArgs e)
        {
            objLoginForma.KorisnickoIme = txbKorisnickoIme.Text;
            objLoginForma.Sifra = txbSifra.Text;
            string status = objLoginForma.DajStatusPrijavljenogKorisnika();

            if (status.Equals("NIJE PRONADJEN KORISNIK"))
            {
                //Response.Redirect("Default.aspx");
                lblStatus.Text = status + "-" + txbKorisnickoIme.Text; 
            }
            else
            {
                // POSTAVLJANJE PODATAKA O KORISNIKU U SESIJU
                Session.Add("KorisnikImePrezime", objLoginForma.DajImePrezimePrijavljenogKorisnika());
                Session.Add("StatusKorisnika", status);
                //UCITAVA SE WELCOME STRANICA ZA TAJ PROFIL KORISNIKA
                switch (status)
                {
                    case "admin":
                        Response.Redirect("WelcomeAdmin.aspx");
                        break;
                    case "korisnik":
                        Response.Redirect("WelcomeKorisnik.aspx");
                        break;

                } //kraj switch

            }


        }

        protected void btnOdustani_Click(object sender, EventArgs e)
        {

        }
    }
}