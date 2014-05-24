using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelos;
using System.Data.SqlClient;
using System.Data;
using Utiles;

namespace FrbaCommerce.Servicios
{
    class Publicaciones
    {


        public void guardar(Publicacion publicacion)
        {

        }

        public static List<Publicacion> buscar(Int64 id, Int64 usuario_id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Publicacion> publicaciones = new List<Publicacion>();

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.BigInt, 100);
            parametro.Value = id;
            parametros.Add(parametro);
            parametro = new SqlParameter("@USUARIO_ID", SqlDbType.BigInt, 100);
            parametro.Value = usuario_id;
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarPublicaciones", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion publicacion = getPublicacionFromSqlReader(lector);
                    publicaciones.Add(publicacion);
                }
            }

            lector.Close();

            return publicaciones;
            
        }

        private static Publicacion getPublicacionFromSqlReader(SqlDataReader lector)
        {
            Publicacion publicacion = new Publicacion();
            publicacion.id = lector.GetInt64(lector.GetOrdinal("ID"));
            publicacion.usuario_id = lector.GetInt64(lector.GetOrdinal("USUARIO_ID"));
            publicacion.admitePregunta = lector.GetBoolean(lector.GetOrdinal("ADMITE_PREGUNTAS"));
            publicacion.desde = lector.GetDateTime(lector.GetOrdinal("FEC_INICIO"));
            publicacion.hasta = lector.GetDateTime(lector.GetOrdinal("FEC_FIN"));
            publicacion.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));
            publicacion.precio = lector.GetFloat(lector.GetOrdinal("PRECIO"));

            return publicacion;
        }


    }
}
