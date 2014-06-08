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
    class Preguntas
    {
        public static List<Pregunta> buscarPorIdPublicacion(Int64 publicacion_id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Pregunta> preguntas = new List<Pregunta>();

            parametros.Add(new SqlParameter("PUBLICACION_ID", publicacion_id));

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarPreguntas", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Pregunta pregunta = getPreguntaFromSqlReader(lector);
                    preguntas.Add(pregunta);
                }
            }

            lector.Close();

            return preguntas;
            
        }

        public static void responder(Int64 pregunta_id, String respuesta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("ID", pregunta_id));
            parametros.Add(new SqlParameter("RESPUESTA", respuesta));

            BasesDeDatos.EscribirEnBase("GoodTimes.ResponderPregunta", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

        private static Pregunta getPreguntaFromSqlReader(SqlDataReader lector)
        {


            Pregunta pregunta = new Pregunta();

            pregunta.id = lector.GetInt64(lector.GetOrdinal("ID"));
            pregunta.usuario_id = lector.GetInt64(lector.GetOrdinal("USUARIO_ID"));
            pregunta.publicacion_id = lector.GetInt64(lector.GetOrdinal("PUBLICACION_ID"));
            pregunta.fechaPregunta = lector.GetDateTime(lector.GetOrdinal("FEC_PREG"));
            pregunta.fechaRespuesta = lector.GetDateTime(lector.GetOrdinal("FEC_RESP"));
            pregunta.pregunta = lector.GetString(lector.GetOrdinal("PREGUNTA"));
            pregunta.respuesta = lector.GetString(lector.GetOrdinal("RESPUESTA"));

            return pregunta;
        }



        internal static void preguntar(long publicacion_id, string pregunta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("PUBLICACION_ID", publicacion_id));
            parametros.Add(new SqlParameter("PREGUNTA", pregunta));
            parametros.Add(new SqlParameter("USUARIO_ID", Session.usuario.id));

            BasesDeDatos.EscribirEnBase("GoodTimes.HacerPregunta", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }
    }
}
