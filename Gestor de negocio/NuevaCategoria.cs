using dom;
using negcio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_negocio
{
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio datos = new CategoriaNegocio();
            if (txtCategoria.Text != "")
            {
                categoria.descripcion = txtCategoria.Text;
                datos.agregarCategoria(categoria);
                MessageBox.Show("Categoría agregada exitosamente!");

                Close();

            }
            else
            {
                MessageBox.Show("Agregue Una Categoría nueva");
            }
        }

        private void btnCancelarCateogoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
