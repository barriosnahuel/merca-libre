using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelos;
using System.Data.SqlClient;
using Utiles;

namespace FrbaCommerce.Servicios
{
    class Visibilidades
    {

        public static List<Visibilidad> listar()
        {
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.ListarVisibilidadPublicacion", BasesDeDatos.Tipos.StoreProcedure, new List<SqlParameter>());
            List<Visibilidad> listaVisibilidades = new List<Visibilidad>();

            if (lector.HasRows)
            {
                
                while (lector.Read())
                {
                    listaVisibilidades.Add(getVisibilidad(lector));
                }
                
            }
            lector.Close();
            return listaVisibilidades;
        }


        public static Visibilidad buscar(Int64 id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ID", id));

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarVisibilidad", BasesDeDatos.Tipos.StoreProcedure, parametros);
           
            Visibilidad visibilidad = null;

            

            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    visibilidad = getVisibilidad(lector);
                }

            }
            lector.Close();
            return visibilidad;
        }

        public static void crearOModificar(Visibilidad visibilidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("CODIGO", visibilidad.id));
            parametros.Add(new SqlParameter("DESCRIPCION", visibilidad.descripcion));
            parametros.Add(new SqlParameter("PORCENTAJE", visibilidad.porcentaje));
            parametros.Add(new SqlParameter("PRECIO", visibilidad.precio));

            BasesDeDatos.EscribirEnBase("GoodTimes.CrearOModificarVisibilidad", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

        public static void borrar(Int64 id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("CODIGO", id));

            BasesDeDatos.EscribirEnBase("GoodTimes.BorrarVisibilidad", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }


        private static Visibilidad getVisibilidad(SqlDataReader lector)
        {
            Visibilidad visibilidad = new Visibilidad();
            visibilidad.id = Int64.Parse(lector.GetDecimal(lector.GetOrdinal("ID")).ToString());
            visibilidad.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION")) ;
            visibilidad.precio = Double.Parse(lector.GetDecimal(lector.GetOrdinal("PRECIO")).ToString());
            visibilidad.porcentaje = Double.Parse(lector.GetDecimal(lector.GetOrdinal("PORC_GANANCIA")).ToString()) ;

            return visibilidad;
            
        }
     
    }
}
 

