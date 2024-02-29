using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2final_Tucci
{
    public partial class menuLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"]==null)
            {
                Session.Add("Error", "Debes loguearte para ingresar");
                Response.Redirect("../Error.aspx",false);
            }
        }

        protected void btnpage1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginUser.aspx");
        }

        protected void btnpage2_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginAdmin.aspx");
        }
    }
}