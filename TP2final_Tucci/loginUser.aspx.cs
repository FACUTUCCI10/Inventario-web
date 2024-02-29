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
    public partial class loginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegresarUser_Click(object sender, EventArgs e)
        {
            //Response.Redirect("login.aspx");
        }

        protected void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                trainee user = new trainee();
                TraineeNegocio traineeNegocio = new TraineeNegocio();  
                EmailService emailService = new EmailService();

                user.email=TxtEmail.Text;
                user.pass=TxtPassword.Text;
                user.id =traineeNegocio.insertarNuevo(user);
                Session.Add("Trainee",user);

                emailService.armarCorreo(user.email,"Bienvenida","Hola,te agradecemos por registrarte");
                emailService.enviarEmail();
                Response.Redirect("default.aspx",false);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
            }
        }
    }
}