using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dom;


namespace negcio
{
    public class TraineeNegocio
    {
        public int insertarNuevo (trainee nuevo)
        { 
            AccesoAdatos datos = new AccesoAdatos ();
            try
            {
                datos.setearProcedimiento("insertarNuevo");
                datos.SetearParametros("@email",nuevo.email);
                datos.SetearParametros("@pass",nuevo.pass);
                return datos.ejecutarAccionScalar();
                
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
       public bool Login (trainee trainee)
        { 
            AccesoAdatos datos = new AccesoAdatos();
            try
            {
                datos.SetearConsulta("select id,email,pass,admin,urlimagenPerfil from USERS where email = @email and pass = @pass");
                datos.SetearParametros("email",trainee.email);
                datos.SetearParametros("pass",trainee.pass);
                datos.EjecutarLectura();
                if (datos.Lector.Read())
                {
                    trainee.id = (int)datos.Lector["id"];
                    trainee.admin = (bool)datos.Lector["admin"];
                    
                    if (!(datos.Lector["urlimagenPerfil"] is DBNull))
                    {
                        trainee.imagenPerfil = (string)datos.Lector["urlimagenPerfil"];
                    }
                    
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
        public void actualizar(trainee user)
        {
            AccesoAdatos datos = new AccesoAdatos();
            try
            {
                
                datos.SetearConsulta("update USERS set urlimagenPerfil = @imagen,nombre =@nombre,apellido=@apellido where id = @id");
                datos.SetearParametros("@imagen",user.imagenPerfil !=null ? user.imagenPerfil : "");
                datos.SetearParametros("@nombre",user.nombre);
                datos.SetearParametros("@apellido", user.apellido);
                datos.SetearParametros("@id", user.id);
                datos.ejecutarAccion();

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
