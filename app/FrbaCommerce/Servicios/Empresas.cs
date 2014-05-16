using System.Collections.Generic;
using System.Data.SqlClient;
using Utiles;
using System.Data;
using FrbaCommerce.Modelos;
using System;

namespace FrbaCommerce.Servicios
{
    class Empresas
    {
        public static List<Empresa> buscar(String razon_social, String cuit, String contacto)
        {
            List<Empresa> empresas = new List<Empresa>();
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@RAZON_SOCIAL", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(razon_social))
            {
                parametro.Value = razon_social;
            }
            parametros.Add(parametro);

            parametro = new SqlParameter("@CUIT", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(cuit))
            {
                parametro.Value = cuit;
            }
            parametros.Add(parametro);

            parametro = new SqlParameter("@CONTACTO", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(contacto))
            {
                parametro.Value = contacto;
            }
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarEmpresas", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Empresa empresa = getEmpresaFromSqlReader(lector);
                    empresas.Add(empresa);
                }
            }

            lector.Close();

            return empresas;
        }

        public static void crearEmpresa(Empresa empresa)
        {
            List<SqlParameter> parametros = obtenerParametros(empresa);

            SqlParameter parametro = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 100);
            parametro.Value = empresa.password;
            parametros.Add(parametro);

            BasesDeDatos.EscribirEnBase("GoodTimes.CrearEmpresa", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

        public static void actualizarEmpresa(Empresa empresa)
        {
            List<SqlParameter> parametros = obtenerParametros(empresa);

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.VarChar, 100);
            parametro.Value = empresa.id;
            parametros.Add(parametro);

            BasesDeDatos.EscribirEnBase("GoodTimes.ModificarEmpresa", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

        public static void eliminarEmpresa(long id)
        {
            Usuarios.eliminar(id);
        }

        public static Empresa buscarEmpresaPorCuit(long cuit)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@CUIT", SqlDbType.BigInt, 100);
            parametro.Value = cuit;
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarEmpresaPorCuit", BasesDeDatos.Tipos.StoreProcedure, parametros);

            Empresa empresa = null;
            if (lector.HasRows)
            {
                lector.Read();
                empresa = getEmpresaFromSqlReader(lector);
            }

            lector.Close();

            return empresa;
        }

        public static Empresa buscarEmpresaPorRazonSocial(string razonSocial)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@RAZON_SOCIAL", SqlDbType.VarChar, 100);
            parametro.Value = razonSocial;
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarEmpresaPorRazonSocial", BasesDeDatos.Tipos.StoreProcedure, parametros);

            Empresa empresa = null;
            if (lector.HasRows)
            {
                lector.Read();
                empresa = getEmpresaFromSqlReader(lector);
            }

            lector.Close();

            return empresa;
        }

        private static Empresa getEmpresaFromSqlReader(SqlDataReader lector)
        {
            Empresa empresa = new Empresa();
            empresa.id = lector.GetInt64(lector.GetOrdinal("ID"));
            empresa.cuit = lector.GetInt64(lector.GetOrdinal("CUIT"));
            empresa.razon_social = lector.GetString(lector.GetOrdinal("RAZON_SOCIAL"));
            empresa.username = lector.GetString(lector.GetOrdinal("USERNAME"));
            empresa.mail = lector.GetString(lector.GetOrdinal("MAIL"));
            empresa.habilitado = lector.GetBoolean(lector.GetOrdinal("HABILITADO"));
            empresa.eliminado = lector.GetBoolean(lector.GetOrdinal("ELIMINADO"));
            empresa.localidad = lector.GetString(lector.GetOrdinal("LOCALIDAD"));
            empresa.direccion = lector.GetString(lector.GetOrdinal("DIRECCION"));
            empresa.telefono = lector.GetString(lector.GetOrdinal("TELEFONO"));
            empresa.codigo_postal = lector.GetString(lector.GetOrdinal("CODIGO_POSTAL"));
            empresa.nombreContacto = lector.GetString(lector.GetOrdinal("CONTACTO"));
            empresa.fecha_creacion = lector.GetDateTime(lector.GetOrdinal("FECHA_CREACION"));
            empresa.empresa_id = lector.GetInt64(lector.GetOrdinal("empresa_id"));

            return empresa;
        }

        private static List<SqlParameter>  obtenerParametros(Empresa empresa)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@CUIT", SqlDbType.BigInt, 100);
            parametro.Value = empresa.cuit;
            parametros.Add(parametro);
            parametro = new SqlParameter("@RAZON_SOCIAL", SqlDbType.VarChar, 100);
            parametro.Value = empresa.razon_social;
            parametros.Add(parametro);
            parametro = new SqlParameter("@CONTACTO", SqlDbType.VarChar, 100);
            parametro.Value = empresa.nombreContacto;
            parametros.Add(parametro);
            parametro = new SqlParameter("@FECHA_CREACION", SqlDbType.DateTime, 100);
            parametro.Value = empresa.fecha_creacion;
            parametros.Add(parametro);
            parametro = new SqlParameter("@EMPRESA_ID", SqlDbType.BigInt, 100);
            parametro.Value = empresa.empresa_id;
            parametros.Add(parametro);

            parametro = new SqlParameter("@USERNAME", SqlDbType.VarChar, 100);
            parametro.Value = empresa.username;
            parametros.Add(parametro);
            parametro = new SqlParameter("@LOGIN_FALLIDOS", SqlDbType.Int, 100);
            parametro.Value = 0;
            parametros.Add(parametro);
            parametro = new SqlParameter("@HABILITADO", SqlDbType.Bit, 100);
            parametro.Value = true;
            parametros.Add(parametro);
            parametro = new SqlParameter("@ELIMINADO", SqlDbType.Bit, 100);
            parametro.Value = false;
            parametros.Add(parametro);
            parametro = new SqlParameter("@MAIL", SqlDbType.VarChar, 100);
            parametro.Value = empresa.mail;
            parametros.Add(parametro);
            parametro = new SqlParameter("@TELEFONO", SqlDbType.VarChar, 100);
            parametro.Value = empresa.telefono;
            parametros.Add(parametro);
            parametro = new SqlParameter("@DIRECCION", SqlDbType.VarChar, 100);
            parametro.Value = empresa.direccion;
            parametros.Add(parametro);
            parametro = new SqlParameter("@CODIGO_POSTAL", SqlDbType.VarChar, 100);
            parametro.Value = empresa.codigo_postal;
            parametros.Add(parametro);
            parametro = new SqlParameter("@LOCALIDAD", SqlDbType.VarChar, 100);
            parametro.Value = empresa.localidad;
            parametros.Add(parametro);

            return parametros;
        }
    }
}
