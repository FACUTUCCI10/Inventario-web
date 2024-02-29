using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
    public class trainee
    {
        public int id{ get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool admin { get; set; }
        public string imagenPerfil { get; set; }
    }
}
