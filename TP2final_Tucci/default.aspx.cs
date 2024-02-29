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
    public partial class _default : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlNegocio negocio = new ControlNegocio();
            listaArticulos = negocio.listar();
            if (!IsPostBack)
            {
                repRepetidor.DataSource = listaArticulos;
                repRepetidor.DataBind();
            }
        }
    }
}