using System.Collections.Generic;
using System.Data.SqlClient;
using Utiles;
using System.Data;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Servicios
{
    class Empresas
    {
        public static void crearEmpresa(Empresa empresa)
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

            parametro = new SqlParameter("@USERNAME", SqlDbType.VarChar, 100);
            parametro.Value = empresa.username;
            parametros.Add(parametro);
            parametro = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 100);
            parametro.Value = empresa.password;
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

            BasesDeDatos.EscribirEnBase("GoodTimes.CrearEmpresa", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }
    }
}
