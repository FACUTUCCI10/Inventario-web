using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negcio;
using dom;

namespace TP2final_Tucci
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            trainee trainee = new trainee();
            TraineeNegocio negocio = new TraineeNegocio();
            try
            {
               
              trainee.email = txtEmail.Text;
              trainee.pass  = txtpassword.Text;
              if (negocio.Login(trainee))
                {
                    Session.Add("trainee",trainee);
                    Response.Redirect("default.aspx",false);
                }
               
                else
                {
                    Session.Add("Error","user o password incorrectos".ToString());
                    Response.Redirect("error.aspx",false);
                }

               
            }
            catch (Exception ex) 
            {
                Session.Add("error", ex.ToString());
                //Response.Redirect("error.aspx");
            }
            
        }
    }
}