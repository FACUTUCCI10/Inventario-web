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

namespace Gestor_de_negocio
{
    public partial class NuevaMarca : Form
    {
        public NuevaMarca()
        {
            InitializeComponent();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
           
            Marca marca = new Marca();
            MarcaNegocio datos = new MarcaNegocio();
            if (txtMarca.Text!="")
            {
                marca.descripcion = txtMarca.Text;
                datos.agregarMarca(marca);
                MessageBox.Show("Marca agregada exitosamente!");
                
                Close();

            }
            else
            {
                MessageBox.Show("Agregue Una Marca nueva");
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
