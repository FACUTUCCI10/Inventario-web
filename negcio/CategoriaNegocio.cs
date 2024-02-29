using dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace negcio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoAdatos datos = new AccesoAdatos();
            try
            {
                datos.SetearConsulta("Select Id, Descripcion From CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.Id = (int)datos.Lector["Id"];
                    lista.Add(aux);

                }
                return lista;
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
        public void agregarCategoria(Categoria nueva)
        {
            AccesoAdatos datos = new AccesoAdatos();
            try
            {
                datos.SetearConsulta("Insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                datos.SetearParametros("@Descripcion", nueva.descripcion);
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
