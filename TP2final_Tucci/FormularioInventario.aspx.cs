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
    public partial class FormularioInventario : System.Web.UI.Page
    {
        public bool confirmaEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            confirmaEliminacion = false;
            try
            {
                if (!IsPostBack)
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    List<Marca> lista = marcaNegocio.listar();
                    List<Categoria> list = categoriaNegocio.listar();
                    ddlCategoria.DataSource = list;
                    ddlCategoria.DataValueField = "id";
                    ddlCategoria.DataTextField = "descripcion";
                    ddlCategoria.DataBind();

                    ddlMarca.DataSource = lista;
                    ddlMarca.DataValueField = "id";
                    ddlMarca.DataTextField = "descripcion";
                    ddlMarca.DataBind();


                }

                //configuracion si estamos modificando
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                if (id != "" && !IsPostBack)
                {
                    ControlNegocio negocio = new ControlNegocio();

                    Articulo seleccionado = (negocio.listar(id))[0];

                    //guardo pokemon seleccionado en session
                    Session.Add("articuloSeleccionado", seleccionado);

                    //pre cargar todos los campos...
                    txtId.Text = id;
                    txtNombre.Text = seleccionado.nombre;
                    txtDescripcion.Text = seleccionado.descripcion;
                    txtImagenUrl.Text = seleccionado.imagenUrl;
                    txtprecio.Text = seleccionado.precio.ToString();

                    ddlMarca.SelectedValue = seleccionado.marca.Id.ToString();
                    ddlCategoria.SelectedValue = seleccionado.categoria.Id.ToString();
                    txtImagenUrl_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                throw;
            }
          
        }

        protected void btnConfirmaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkConfirmaEliminacion.Checked)
                {
                    ControlNegocio negocio = new ControlNegocio();
                    negocio.eliminar(int.Parse(txtId.Text));
                    Response.Redirect("inventarioList.aspx");
                }
               
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
            }
        }

        protected void btnInactivar_Click(object sender, EventArgs e)
        {

        }

        protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            imgArticulo.ImageUrl = txtImagenUrl.Text;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo nuevo = new Articulo();
                ControlNegocio negocio = new ControlNegocio(); 

                nuevo.nombre = txtNombre.Text;
                nuevo.descripcion = txtDescripcion.Text;
                nuevo.imagenUrl = txtImagenUrl.Text;
                nuevo.codigo =Txtcodigo.Text;
                nuevo.precio= decimal.Parse(txtprecio.Text);

                nuevo.marca = new Marca();
                nuevo.marca.Id = int.Parse(ddlMarca.SelectedValue);

                nuevo.categoria = new Categoria();
                nuevo.categoria.Id= int.Parse(ddlCategoria.SelectedValue);
               
                if (Request.QueryString["id"] != null)
                {
                    nuevo.id = int.Parse(txtId.Text);
                    negocio.modificarconSP(nuevo);
                }
                else
                    negocio.agregarconSP(nuevo);

                Response.Redirect("inventarioList.aspx",false);
            }
            catch (Exception ex)
            {

                Session.Add("error",ex.ToString());
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmaEliminacion = true;
        }
    }
}