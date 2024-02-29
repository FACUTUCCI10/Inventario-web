using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dom;
using negcio;
using System.IO;
using System.Configuration;

namespace Gestor_de_negocio
{
    public partial class frmAgregarProducto : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAgregarProducto()
        {
            InitializeComponent();
        }
        public frmAgregarProducto(Articulo articulo)
        {

            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar pokemon";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marca.listar();
                cboMarca.ValueMember = "id";
                cboMarca.DisplayMember = "descripcion";
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "descripcion";
                cboCategoria.DataSource = categoria.listar();
                if (articulo != null)
                {
                    txtcodigo.Text = articulo.codigo.ToString();
                    txtNombre.Text = articulo.nombre;
                    txtDescripcion.Text = articulo.descripcion;
                    txtUrlimagen.Text = articulo.imagenUrl;
                    txtPrecio.Text = articulo.precio.ToString();
                    cargarImagen(articulo.imagenUrl);
                    cboMarca.SelectedValue = articulo.marca.Id;
                    cboCategoria.SelectedValue = articulo.categoria.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void lblimagen_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo articuloNuevo = new Articulo();
            ControlNegocio negocio = new ControlNegocio();
            try
            {
                if (ValidarCarga())
                {
                    return;
                }
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.nombre = txtNombre.Text;
                articulo.descripcion = txtDescripcion.Text;
                articulo.imagenUrl = txtUrlimagen.Text;
                articulo.precio = decimal.Parse(txtPrecio.Text);
                articulo.codigo = txtcodigo.Text;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                articulo.categoria = (Categoria)cboCategoria.SelectedItem;


                if (articulo.id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                    

                }
                //Guardo imagen si la levantó localmente:
                if (archivo != null && !(txtUrlimagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtUrlimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlimagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbxAgregarArticulos.Load("https://theperfectroundgolf.com/wp-content/uploads/2022/04/placeholder.png");
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png|img|*.img";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlimagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen
                
            }
        }
        
         
        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Trim() == "")
            {
                epError.SetError(txtPrecio, "introduzca el precio del producto");
                txtPrecio.Focus();
            }
            else
            {
                epError.Clear();
            }

        }
        private bool ValidarCarga()
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.ToString()) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Complete los campos vacios (*)","",MessageBoxButtons.OK);
               return true;

            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Ingrese sólo números, por favor");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show(" Ingrese un valor para 'Precio' ");
                return true;
            }
            
                return false;
            
            

        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaCategoria ventana = new NuevaCategoria();
            ventana.ShowDialog();
        }

        private void btnNewMarca_Click(object sender, EventArgs e)
        {
            NuevaMarca window = new NuevaMarca();
            window.ShowDialog();
        }
    }
}