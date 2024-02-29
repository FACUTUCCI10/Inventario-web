using dom;
using negcio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2final_Tucci
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page is login||Page is loginUser||Page is error))
            {

                if (!Seguridad.sessionActiva(Session["trainee"]))
                    Response.Redirect("login.aspx", false);

            }
            if (Seguridad.sessionActiva(Session["trainee"]))
            {
                ImgAvatar.ImageUrl =  "~/imagenes/" + ((trainee)Session["trainee"]).imagenPerfil;
                
            }
            else
            {
                ImgAvatar.ImageUrl = "https://st3.depositphotos.com/6672868/13701/v/450/depositphotos_137014128-stock-illustration-user-profile-icon.jpg";
            }
        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginUser.aspx");
        }

        protected void Btnsalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx");
        }
    }
}