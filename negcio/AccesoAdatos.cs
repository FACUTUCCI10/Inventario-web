using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negcio
{
    public class AccesoAdatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;


        public SqlDataReader Lector
        {
            get { return lector; }
        }


        public AccesoAdatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_WEB_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
        public void SetearParametros(string nombre ,object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }
        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
                conexion.Close();
        }

        public void setearProcedimiento(string sp)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;

        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
           
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int ejecutarAccionScalar()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                return int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
