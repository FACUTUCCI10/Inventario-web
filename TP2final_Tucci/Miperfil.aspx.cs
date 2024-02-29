using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dom;
using negcio;

namespace TP2final_Tucci
{
    public partial class Miperfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (!Seguridad.sessionActiva(Session["trainee"]))
            {
                Response.Redirect("login.aspx",false);
            }
        }

        protected void Btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                TraineeNegocio negocio = new TraineeNegocio();
                trainee user = (trainee)Session["trainee"];
                if (txtimagen.PostedFile.FileName!="")
                {
                    string ruta = Server.MapPath("./imagenes/");
                    txtimagen.PostedFile.SaveAs(ruta + "perfil-" + user.id + ".jpg");
                    user.imagenPerfil = "perfil-" + user.id + ".jpg";
                }

                negocio.actualizar(user);
                Image img = (Image)Master.FindControl("imgAvatar");
                img.ImageUrl = "~/imagenes/" + user.imagenPerfil;

                user.nombre = Txtnombre.Text;
                user.apellido = Txtapellido.Text;


            }
            catch (Exception ex)
            {

                Session.Add("error",ex.ToString());
            }
        }
    }
}