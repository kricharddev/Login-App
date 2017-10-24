using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ValidationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = Session["FIRST_NAME"] as string;
            lblLastName.Text = Session["LAST_NAME"] as string;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["FIRST_NAME"] = null;
            Session["LAST_NAME"] = null;
            Response.Redirect(this.ResolveUrl("~/Login.aspx"));
        }
    }
}