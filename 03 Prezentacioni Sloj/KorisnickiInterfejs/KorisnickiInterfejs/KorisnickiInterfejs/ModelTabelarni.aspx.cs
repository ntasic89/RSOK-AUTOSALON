using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// 
using PrezentacionaLogika;
using System.Configuration;
using System.Data; 


namespace KorisnickiInterfejs
{
    public partial class RacunTabelarni : System.Web.UI.Page
    {
        // atributi
        private string pStringKonekcije;
        private ModelTabelarniPrikaz pObjForma;
        private DataSet dsPodaci;
        static string index;

        // metode
        public void PrikaziPodatkeTabelarno(DataSet dsPodaci)
        {
            gvModeli.DataSource= dsPodaci.Tables[0];
            gvModeli.DataBind();
        }
        

        // dogadjaji
               
        protected void Page_Load(object sender, EventArgs e)
        {
            pStringKonekcije = ConfigurationManager.ConnectionStrings["NasaKonekcija"].ConnectionString;
            pObjForma = new ModelTabelarniPrikaz(pStringKonekcije);
        }

        protected void brnFiltriraj_Click(object sender, EventArgs e)
        {
            dsPodaci = pObjForma.DajPodatkeZaGrid(txbFilter.Text );
            PrikaziPodatkeTabelarno(dsPodaci);
        }

        protected void btnSvi_Click(object sender, EventArgs e)
        {
            dsPodaci = pObjForma.DajPodatkeZaGrid("");
            PrikaziPodatkeTabelarno(dsPodaci);
        }
   
       

        protected void gvModeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = (gvModeli.SelectedRow.RowIndex + 1).ToString();
            //pObjForma.BrisiModel(index);
           // gvModeli_OnRowDeleted.Visible = false;
            btnDelete.Visible = true;
        }
                
        protected void gvModeli_OnRowDeleted(object sender, EventArgs e)
        {
            if (gvModeli.SelectedIndex == -1)
            {
                return;
            }

            int row = gvModeli.SelectedIndex;
            int column = gvModeli.SelectedIndex;
            TableCell cell = gvModeli.Rows[row].Cells[1];
          
            
            //string index = (gvModeli.SelectedRow.RowIndex + 1).ToString();
            pObjForma.BrisiModel(cell.Text);
        }

        protected void gvModeli_OnRowEdit(object sender, EventArgs e)
        {
            if (gvModeli.SelectedIndex == -1)
            {
                return;
            }

            int row = gvModeli.SelectedIndex;
            int column = gvModeli.SelectedIndex;
            TableCell cell = gvModeli.Rows[row].Cells[1];

            Response.Redirect("ModelIzmena.aspx?Sifra=" + gvModeli.Rows[row].Cells[1].Text); 

           // string idModela = cell.Text;

           // pObjForma.IzmeniModel(idModela, 

            string BrowserSettings = "status=no,toolbar=no,menubar=no,location=no,resizable=no," +
                                        "titlebar=no, addressbar=no, width=600 ,height=750";
            string URL = "http://localhost/ModelIzmena.aspx";
            string scriptText = "window.open('" + URL + "','_blank','" + BrowserSettings + "');";
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "ClientScript1", scriptText, true);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvModeli.SelectedIndex == -1)
            {
                return;
            }

            int row = gvModeli.SelectedIndex;
            int column = gvModeli.SelectedIndex;
            TableCell cell = gvModeli.Rows[row].Cells[1];


            //string index = (gvModeli.SelectedRow.RowIndex + 1).ToString();
            pObjForma.BrisiModel(cell.Text);
        }
    }
}
