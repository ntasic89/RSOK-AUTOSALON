﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KorisnickiInterfejs
{
    public partial class ModelParametarStampa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFilterStampa_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModeliStampa.aspx?filter=" + txbFilter.Text);
        }
    }
}