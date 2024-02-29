using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
    public class Categoria
    {
        public int Id { get; set; }
        public string descripcion { get; set; }

       
        public override string ToString()
        {
            return descripcion;
        }
    }
}
