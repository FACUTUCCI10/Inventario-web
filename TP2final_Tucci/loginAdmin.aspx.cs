using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2final_Tucci
{
    public partial class loginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["usuario"] != null && ((dom.usuario)Session["usuario"]).tipoUsuario == dom.TipoUsuario.ADMIN))
            {
                Session.Add("error","No tienes permiso para ingresar a esta pantalla,necesitas ser admin.");
                Response.Redirect("../error.aspx", false);
            }
        }

        protected void btnRegresarAdmin_Click(object sender, EventArgs e)
        {
            //Response.Redirect("login.aspx");
        }
    }
}