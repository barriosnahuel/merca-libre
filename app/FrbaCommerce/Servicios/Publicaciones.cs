﻿using System;
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

            parametros.Add(new SqlParameter("ID", -1));
            parametros.Add(new SqlParameter("USUARIO_ID",publicacion.usuario.id));
            parametros.Add(new SqlParameter("DESCRIPCION", publicacion.descripcion));
            parametros.Add(new SqlParameter("UNIDADES", publicacion.stock));
            parametros.Add(new SqlParameter("PRECIO", publicacion.precio));
            parametros.Add(new SqlParameter("FEC_INICIO", publicacion.desde));
            parametros.Add(new SqlParameter("FEC_FIN", publicacion.hasta));
            parametros.Add(new SqlParameter("TIPO_PUBLICACION_ID", publicacion.tipo.id));
            parametros.Add(new SqlParameter("ESTADO_ID", publicacion.estado.id));
            parametros.Add(new SqlParameter("VISIBILIDAD_ID", publicacion.visibilidad.id));
            parametros.Add(new SqlParameter("ADMITE_PREGUNTAS", publicacion.admitePregunta?1:0));


            publicacion.id = Int64.Parse(BasesDeDatos.queryForDecimal("GoodTimes.GuardarPublicacion", BasesDeDatos.TiposEscritura.StoreProcedure, parametros).ToString());

            
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
            publicacion.precio = lector.GetFloat(lector.GetOrdinal("PRECIO"));

            return publicacion;
        }


    }
}