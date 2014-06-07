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
        public static void guardar(Publicacion publicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            
            if (publicacion.id > 0)
            {
                BasesDeDatos.EscribirEnBase("delete from GOODTIMES.RUBROS_X_PUBLICACION where PUBLICACION_ID =" + publicacion.id);
                parametros.Add(new SqlParameter("ID", publicacion.id));
            }
            else
            {
                parametros.Add(new SqlParameter("ID", -1));
            }
            

            parametros.Add(new SqlParameter("USUARIO_ID",publicacion.usuario.id));
            parametros.Add(new SqlParameter("DESCRIPCION", publicacion.descripcion));
            parametros.Add(new SqlParameter("UNIDADES", publicacion.unidades));
            parametros.Add(new SqlParameter("PRECIO", publicacion.precio));
            parametros.Add(new SqlParameter("FEC_INICIO", publicacion.desde));
            parametros.Add(new SqlParameter("FEC_FIN", publicacion.hasta));
            parametros.Add(new SqlParameter("TIPO_PUBLICACION_ID", publicacion.tipo.id));
            parametros.Add(new SqlParameter("ESTADO_ID", publicacion.estado.id));
            parametros.Add(new SqlParameter("VISIBILIDAD_ID", publicacion.visibilidad.id));
            parametros.Add(new SqlParameter("ADMITE_PREGUNTAS", publicacion.admitePregunta?1:0));


            publicacion.id = BasesDeDatos.queryForInt64("GoodTimes.GuardarPublicacion", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);

            
            foreach (Rubro rubro in publicacion.rubros)
            {
                parametros.Clear();
                parametros.Add(new SqlParameter("PUBLICACION_ID", publicacion.id));
                parametros.Add(new SqlParameter("RUBRO_ID", rubro.id));
                BasesDeDatos.EscribirEnBase("GoodTimes.AgregarRubroAPublicacion", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
            }
            
           
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


        public static Publicacion buscar (Int64 id)
        {
            Publicacion publicacion = null;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ID",id));


            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarPublicacion", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    publicacion = getPublicacionFromSqlReader(lector);
                }
            }
            

            lector.Close();

            publicacion.visibilidad = Visibilidades.buscar(publicacion.visibilidad.id);
            publicacion.tipo = TipoPublicaciones.buscar(publicacion.tipo.id);
            publicacion.rubros = Rubros.buscarPorPublicacion(publicacion.id);

            return publicacion;

        }


        public static List<Publicacion> buscarActivas(String estado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Publicacion> publicaciones = new List<Publicacion>();

            SqlParameter parametro = new SqlParameter("@ESTADO", SqlDbType.BigInt, 100);
            parametro.Value = estado;
            parametros.Add(parametro);

            SqlDataReader lector = 
                BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarPublicacionesActivas", BasesDeDatos.Tipos.StoreProcedure, parametros);

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

            publicacion.usuario = new Usuario();

            publicacion.id = lector.GetInt64(lector.GetOrdinal("ID"));
            publicacion.usuario.id = lector.GetInt64(lector.GetOrdinal("USUARIO_ID"));
            publicacion.admitePregunta = lector.GetBoolean(lector.GetOrdinal("ADMITE_PREGUNTAS"));
            publicacion.desde = lector.GetDateTime(lector.GetOrdinal("FEC_INICIO"));
            publicacion.hasta = lector.GetDateTime(lector.GetOrdinal("FEC_FIN"));
            publicacion.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));
            publicacion.precio = (Double)lector.GetDecimal(lector.GetOrdinal("PRECIO"));
            publicacion.unidades = (Int32)lector.GetDecimal(lector.GetOrdinal("UNIDADES"));

            publicacion.visibilidad = new Visibilidad();
            publicacion.visibilidad.id = (Int64)lector.GetDecimal(lector.GetOrdinal("VISIBILIDAD_ID"));

            publicacion.tipo = new TipoPublicacion();
            publicacion.tipo.id = lector.GetInt16(lector.GetOrdinal("TIPO_PUBLICACION_ID")); 

            return publicacion;
        }


    }
}
