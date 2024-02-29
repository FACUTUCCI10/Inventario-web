using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dom;

namespace negcio
{
    public class UsuarioNegocio
    {
        public bool loguear (usuario usuario)
        {
			AccesoAdatos datos = new AccesoAdatos ();
			try
			{
				datos.SetearConsulta("select id,usuario,pass,tipoUser from usuarios where usuario = @user and pass = @pass");
				datos.SetearParametros("@user",usuario.User);
                datos.SetearParametros("@pass",usuario.Pass);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    usuario.id = (int)datos.Lector["id"];
                    usuario.tipoUsuario= (int)(datos.Lector["tipoUser"])==2 ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
                    return true;
                }
                return false;

            }
			catch (Exception ex)
			{

				throw ex;
			}
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
