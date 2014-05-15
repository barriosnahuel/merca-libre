﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Utiles;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Servicios
{
    class Usuarios
    {

        public static Usuario buscarUsuarioPorUsername(string username)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@USERNAME", SqlDbType.VarChar, 100);
            parametro.Value = username;
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarUsuarioPorUsername", BasesDeDatos.Tipos.StoreProcedure, parametros);

            Usuario usuario = null;
            if (lector.HasRows)
            {
                lector.Read();
                usuario = getClienteFromSqlReader(lector);
            }

            lector.Close();

            return usuario;
        }

        private static Usuario getClienteFromSqlReader(SqlDataReader lector)
        {
            Usuario usuario = new Usuario();
            usuario.id = lector.GetInt64(lector.GetOrdinal("ID"));
            usuario.username = lector.GetString(lector.GetOrdinal("USERNAME"));
            usuario.mail = lector.GetString(lector.GetOrdinal("MAIL"));
            usuario.habilitado = lector.GetBoolean(lector.GetOrdinal("HABILITADO"));
            usuario.eliminado = lector.GetBoolean(lector.GetOrdinal("ELIMINADO"));
            usuario.localidad = lector.GetString(lector.GetOrdinal("LOCALIDAD"));
            usuario.direccion = lector.GetString(lector.GetOrdinal("DIRECCION"));
            usuario.telefono = lector.GetString(lector.GetOrdinal("TELEFONO"));
            usuario.codigo_postal = lector.GetString(lector.GetOrdinal("CODIGO_POSTAL"));
            usuario.login_fallidos = lector.GetInt32(lector.GetOrdinal("LOGIN_FALLIDOS"));

            return usuario;
        }
    }
}