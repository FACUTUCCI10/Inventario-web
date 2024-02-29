using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
      public class Articulo
    {
        [DisplayName("Número")]
     
        public int id { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Descripción")]
        public string descripcion { get; set;}
        public string imagenUrl {get; set;}
        [DisplayName("Marca")]
        public  Marca marca{ get; set;}
        [DisplayName("Categoría")]
        public  Categoria categoria{ get; set;}
        [DisplayName("Precio")]
        public SqlMoney precio { get; set;}
        [DisplayName("Código")]
        public string codigo { get; set;}

    }
}
