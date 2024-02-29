using dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negcio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoAdatos datos = new AccesoAdatos();
           
            try
            {
                datos.SetearConsulta("Select Id, Descripcion From MARCAS");
                // select a.Id,a.Nombre,a.Descripcion,a.Codigo,m.Descripcion as marca,a.Precio,a.ImagenUrl,c.Descripcion as categoria \r\nfrom CATEGORIAS C,ARTICULOS A,MARCAS M where a.IdMarca=m.Id  AND C.Id = A.IdCategoria
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

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
       public void agregarMarca(Marca nueva)
        {
                      
                AccesoAdatos datos = new AccesoAdatos();
                try
                {
                    datos.SetearConsulta("Insert into MARCAS (Descripcion) values (@Descripcion)");
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

