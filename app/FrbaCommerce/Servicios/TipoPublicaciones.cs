using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utiles;
using System.Data.SqlClient;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Servicios
{
    class TipoPublicaciones
    {
        public static List<TipoPublicacion> listar()
        {
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.ListarTipoPublicacion", BasesDeDatos.Tipos.StoreProcedure, new List<SqlParameter>());
            List<TipoPublicacion> tiposPublicacion = new List<TipoPublicacion>();

            if (lector.HasRows)
            {
                
                while (lector.Read())
                {
                    tiposPublicacion.Add(getTipoPublicacion(lector));
                }
                
            }
            lector.Close();
            return tiposPublicacion;
        }


        private static TipoPublicacion getTipoPublicacion(SqlDataReader lector)
        {
            TipoPublicacion tipoPublicacion = new TipoPublicacion();
            tipoPublicacion.id = lector.GetInt16(lector.GetOrdinal("ID"));
            tipoPublicacion.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));

            return tipoPublicacion;
            
        }


        public static TipoPublicacion buscar(int id)
        {
             
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ID", id));

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarTipoPublicacion", BasesDeDatos.Tipos.StoreProcedure, parametros);

            TipoPublicacion tipoPublicacion = null;

            

            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    tipoPublicacion = getTipoPublicacion(lector);
                }

            }
            lector.Close();
            return tipoPublicacion;
        

        }
    }
}
