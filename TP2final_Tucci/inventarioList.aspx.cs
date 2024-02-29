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
    public partial class inventarioList : System.Web.UI.Page
    {
        public bool FiltroAvanzado { get; set; }
        public List<Articulo> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Seguridad.esAdmin(Session["trainee"]))
            {
                Session.Add("Error","se requieren permisos de admin para ingresar en esta ventana");
                Response.Redirect("default.aspx");
            }
                FiltroAvanzado = chkAvanzado.Checked;
            
                ControlNegocio negocio = new ControlNegocio();
                Session.Add("inventarioList", negocio.listar());
                DGVinventario.DataSource = Session["inventarioList"];
                DGVinventario.DataBind();
        }

        protected void DGVinventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id=DGVinventario.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioInventario.aspx?id="+id);
        }

        protected void DGVinventario_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void DGVinventario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DGVinventario.PageIndex = e.NewPageIndex;
            DGVinventario.DataBind();
        }

        protected void Filtro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = (List<Articulo>)Session["inventarioList"];
            List<Articulo> listaFiltrada = lista.FindAll(x => x.nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            DGVinventario.DataSource = listaFiltrada;
            DGVinventario.DataBind();
        }

        protected void chkAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            FiltroAvanzado = chkAvanzado.Checked;
            txtFiltro.Enabled = !FiltroAvanzado;
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterio.Items.Clear();
            if (ddlCampo.SelectedItem.ToString() == "Precio")
            {
                ddlCriterio.Items.Add("Igual a"); 
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("Menor  a"); 
                
            }
            else
            {
                ddlCriterio.Items.Add("Empieza con");
                ddlCriterio.Items.Add("Termina con");
                ddlCriterio.Items.Add("Contiene");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlNegocio negocio = new ControlNegocio();
                DGVinventario.DataSource = negocio.filtrar(ddlCampo.SelectedItem.ToString(),
                ddlCriterio.SelectedItem.ToString(), txtFiltroAvanzado.Text);
                DGVinventario.DataBind();
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}