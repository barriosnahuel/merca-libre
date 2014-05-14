using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Utiles;
using FrbaCommerce.Modelos;
using System.Data;

namespace FrbaCommerce.Servicios
{
    class Clientes
    {

        public static List<Cliente> Buscar(String nombre, String apellido, String mail, String tipo_documento, String documento)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(nombre))
            {
                parametro.Value = nombre;
            }
            parametros.Add(parametro);

            parametro = new SqlParameter("@APELLIDO", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(apellido))
            {
                parametro.Value = apellido;
            }
            parametros.Add(parametro);

            parametro = new SqlParameter("@MAIL", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(mail))
            {
                parametro.Value = mail;
            }
            parametros.Add(parametro);

            parametro = new SqlParameter("@DNI_TIPO", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(tipo_documento))
            {
                parametro.Value = tipo_documento;                
            }
            parametros.Add(parametro);

            parametro = new SqlParameter("@DNI", SqlDbType.VarChar, 100);
            parametro.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(documento))
            {
                parametro.Value = documento;
            }
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarClientes", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Cliente cliente = getClienteFromSqlReader(lector);
                    clientes.Add(cliente);
                }
            }

            lector.Close();

            return clientes;
        }

        public static void crearCliente(Cliente cliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 100);
            parametro.Value = cliente.nombre;
            parametros.Add(parametro);
            parametro = new SqlParameter("@APELLIDO", SqlDbType.VarChar, 100);
            parametro.Value = cliente.apellido;
            parametros.Add(parametro);
            parametro = new SqlParameter("@DNI", SqlDbType.VarChar, 100);
            parametro.Value = cliente.dni;
            parametros.Add(parametro);
            parametro = new SqlParameter("@DNI_TIPO", SqlDbType.VarChar, 100);
            parametro.Value = cliente.dni_tipo;
            parametros.Add(parametro);
            parametro = new SqlParameter("@FECHA_NAC", SqlDbType.DateTime, 100);
            parametro.Value = cliente.fecha_nacimiento;
            parametros.Add(parametro);
            parametro = new SqlParameter("@USERNAME", SqlDbType.VarChar, 100);
            parametro.Value = cliente.username;
            parametros.Add(parametro);
            parametro = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 100);
            parametro.Value = cliente.password;
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
            parametro.Value = cliente.mail;
            parametros.Add(parametro);
            parametro = new SqlParameter("@TELEFONO", SqlDbType.VarChar, 100);
            parametro.Value = cliente.telefono;
            parametros.Add(parametro);
            parametro = new SqlParameter("@DIRECCION", SqlDbType.VarChar, 100);
            parametro.Value = cliente.direccion;
            parametros.Add(parametro);
            parametro = new SqlParameter("@CODIGO_POSTAL", SqlDbType.VarChar, 100);
            parametro.Value = cliente.codigo_postal;
            parametros.Add(parametro);
            parametro = new SqlParameter("@LOCALIDAD", SqlDbType.VarChar, 100);
            parametro.Value = cliente.localidad;
            parametros.Add(parametro);

            BasesDeDatos.EscribirEnBase("GoodTimes.CrearCliente",BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

        public static Cliente buscarClientePorTelefono(string telefono)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@TELEFONO", SqlDbType.VarChar, 100);
            parametro.Value = telefono;
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarClientePorTelefono", BasesDeDatos.Tipos.StoreProcedure, parametros);

            Cliente cliente = null;
            if (lector.HasRows)
            {
                lector.Read();
                cliente = getClienteFromSqlReader(lector);
            }

            lector.Close();

            return cliente;
        }

        public static Cliente buscarClientePorDNITipoYDNI(string tipo_documento, string documento)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro;
            parametro = new SqlParameter("@DNI_TIPO", SqlDbType.VarChar, 100);
            parametro.Value = tipo_documento;
            parametros.Add(parametro);
            parametro = new SqlParameter("@DNI", SqlDbType.VarChar, 100);
            parametro.Value = documento;
            parametros.Add(parametro);

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.BuscarClientePorDNITipoYDNI", BasesDeDatos.Tipos.StoreProcedure, parametros);

            Cliente cliente = null;
            if (lector.HasRows)
            {
                lector.Read();
                cliente = getClienteFromSqlReader(lector);
            }

            lector.Close();

            return cliente;
        }

        private static Cliente getClienteFromSqlReader(SqlDataReader lector)
        {
            Cliente cliente = new Cliente();
            cliente.id = lector.GetInt64(lector.GetOrdinal("ID"));
            cliente.cliente_id = lector.GetInt64(lector.GetOrdinal("CLIENTE_ID"));
            cliente.nombre = lector.GetString(lector.GetOrdinal("NOMBRE"));
            cliente.username = lector.GetString(lector.GetOrdinal("USERNAME"));
            cliente.mail = lector.GetString(lector.GetOrdinal("MAIL"));
            cliente.apellido = lector.GetString(lector.GetOrdinal("APELLIDO"));
            cliente.habilitado = lector.GetBoolean(lector.GetOrdinal("HABILITADO"));
            cliente.eliminado = lector.GetBoolean(lector.GetOrdinal("ELIMINADO"));
            cliente.localidad = lector.GetString(lector.GetOrdinal("LOCALIDAD"));
            cliente.direccion = lector.GetString(lector.GetOrdinal("DIRECCION"));
            cliente.telefono = lector.GetString(lector.GetOrdinal("TELEFONO"));
            cliente.codigo_postal = lector.GetString(lector.GetOrdinal("CODIGO_POSTAL"));
            cliente.dni_tipo = lector.GetString(lector.GetOrdinal("DNI_TIPO"));
            cliente.dni = lector.GetString(lector.GetOrdinal("DNI"));
            cliente.fecha_nacimiento = lector.GetDateTime(lector.GetOrdinal("FECHA_NAC"));
            cliente.login_fallidos = lector.GetInt32(lector.GetOrdinal("LOGIN_FALLIDOS"));

            return cliente;
        }



        internal static void actualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

    }
}
