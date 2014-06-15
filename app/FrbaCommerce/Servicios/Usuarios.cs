using System;
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

        public static void eliminar(long id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.VarChar, 100);
            parametro.Value = id;
            parametros.Add(parametro);

            BasesDeDatos.EscribirEnBase("GoodTimes.EliminarUsuario", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

        public static Usuario buscarUsuarioPorID(Int64 id){
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@ID", SqlDbType.BigInt, 100);
            parametro.Value = id;
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarUsuarioPorId", BasesDeDatos.Tipos.StoreProcedure, parametros);

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
            Rol rol = new Rol();
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
            rol.id = lector.GetInt32(lector.GetOrdinal("ROL_ID"));
            usuario.rol = rol;

            return usuario;
        }

        internal static int logearse(string usuario, string contrasenia)
        {
            string contraseniaEncriptada = Utiles.Password.encriptarPassword(contrasenia);

            List<SqlParameter> parametros = new List<SqlParameter>();

            
            parametros.Add(new SqlParameter("@USUARIO", usuario));
            parametros.Add(new SqlParameter("@CONTRASENIA", contraseniaEncriptada)); 

            
            return BasesDeDatos.queryForInt("GoodTimes.login", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }
    }
}
