using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Utiles;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Servicios
{
    class CalificacionesHistorial
    {

        private static CalificacionHistorial getCalificacion(SqlDataReader lector)
        {
            CalificacionHistorial unaCalificacion = new CalificacionHistorial();
            unaCalificacion.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));
            unaCalificacion.detalle = lector.GetString(lector.GetOrdinal("DETALLE"));
            unaCalificacion.puntaje = double.Parse(lector.GetDecimal(lector.GetOrdinal("PUNTAJE")).ToString());
            unaCalificacion.username = lector.GetString(lector.GetOrdinal("USERNAME"));

            return unaCalificacion;
        }

        public static List<CalificacionHistorial> BuscarHechasPorUsuario(long IdUsuario)
        {
            List<CalificacionHistorial> listaCalificaciones = new List<CalificacionHistorial>();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID", IdUsuario);
            parametros.Add(p1);
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarCalificacionesHechasPorUsuario", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    CalificacionHistorial unaCalificacion = getCalificacion(lector);
                    listaCalificaciones.Add(unaCalificacion);
                }
            }

            lector.Close();

            return listaCalificaciones;
        }

        public static List<CalificacionHistorial> BuscarRecibidas(long IdUsuario)
        {
            List<CalificacionHistorial> listaCalificaciones = new List<CalificacionHistorial>();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID", IdUsuario);
            parametros.Add(p1);
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarCalificacionesRecibidas", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    CalificacionHistorial unaCalificacion = getCalificacion(lector);
                    listaCalificaciones.Add(unaCalificacion);
                }
            }

            lector.Close();

            return listaCalificaciones;
        }

    }
}
