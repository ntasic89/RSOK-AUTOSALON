using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;

namespace ProveraOpsega
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public bool ProveriOpseg(int vrednost)
        {
            DataSet dsOpseg = new DataSet();
            dsOpseg.ReadXml(Server.MapPath("~/") + "XML/Opseg.XML");
            // filtriranje dataset-a

            string result = dsOpseg.Tables[0].Rows[0].ItemArray[0].ToString();

            if (result == null)
            {
                return false;
            }

            int opseg = Int32.Parse(result);

            if (opseg > vrednost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}