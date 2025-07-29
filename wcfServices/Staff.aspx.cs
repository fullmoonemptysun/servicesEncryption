using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != "Staff")
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                lblWelcome.Text = "Welcome, " + Session["Username"] + "!";
            }
        }
    }
}