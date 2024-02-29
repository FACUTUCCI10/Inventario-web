using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
   public enum TipoUsuario
    {
        NORMAL = 1,
        ADMIN= 2

    }
    public class usuario
    {
        public int id { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        public usuario(string user,string pass,bool admin)
        {
            user = User;
            pass = Pass;
            tipoUsuario = admin ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
        }
    }
}
