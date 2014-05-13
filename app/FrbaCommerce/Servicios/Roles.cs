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
    class Roles
    {

        private static Rol getRol(SqlDataReader lector)
        {
            Rol unRol = new Rol();
            unRol.id = lector.GetInt32(lector.GetOrdinal("ID"));
            unRol.nombre = lector.GetString(lector.GetOrdinal("NOMBRE"));
            unRol.habilitado = lector.GetBoolean(lector.GetOrdinal("HABILITADO"));
            unRol.eliminado = lector.GetBoolean(lector.GetOrdinal("ELIMINADO"));

            return unRol;
        }

        public static List<Rol> ObtenerTodos()
        {
            List<Rol> listaRoles = new List<Rol>();
            //GOODTIMES.[ListarRoles]
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT * FROM GOODTIMES.ROL WHERE ELIMINADO = 0");

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = getRol(lector);
                    listaRoles.Add(unRol);
                }
            }

            lector.Close();

            return listaRoles;
        }

        public static List<Rol> Buscar(String nombre)
        {
            List<Rol> listaRoles = new List<Rol>();
            //BuscarRolPorNombre
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT * FROM GOODTIMES.ROL WHERE ELIMINADO = 0 AND NOMBRE like '%" + nombre + "%'");

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = getRol(lector);
                    listaRoles.Add(unRol);
                }
            }

            lector.Close();

            return listaRoles;
        }

        
        internal static void eliminarRol(Rol rol) {

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametro;

            parametro = new SqlParameter("@ID", SqlDbType.Int, 100);
            parametro.Value = rol.id;

            parametros.Add(parametro);
        
            //BajaRol
            BasesDeDatos.EscribirEnBase("GoodTimes.BajaRol", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);

        }

        internal static void guardarRol(Rol rol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametro;

            parametro = new SqlParameter("@ID", SqlDbType.Int, 100);
            parametro.Value = rol.id;

            parametros.Add(parametro);

            parametro = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 100);
            parametro.Value = rol.nombre;
            parametros.Add(parametro);

            parametro = new SqlParameter("@HABILITADO", SqlDbType.Bit);
            parametro.Value = rol.habilitado;
            parametros.Add(parametro);

            parametro = new SqlParameter("@ELIMINADO", SqlDbType.Bit);
            parametro.Value = int.Parse("-1");
            parametros.Add(parametro);

            BasesDeDatos.EscribirEnBase("GoodTimes.CrearRol", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);

        }

        internal static void quitarFuncionalidad(Rol rol, Funcion funcionalidad)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametro;

            parametro = new SqlParameter("@ROL_ID", SqlDbType.Int, 100);
            parametro.Value = rol.id;
            parametros.Add(parametro);

            parametro = new SqlParameter("@FUNCIONALIDAD_ID", SqlDbType.Int, 100);
            parametro.Value = funcionalidad.id;
            parametros.Add(parametro);

            BasesDeDatos.EscribirEnBase("GoodTimes.QuitarFuncionalidadARol", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

        internal static void agregarFuncionalidad(Rol rol, Funcion funcionalidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametro;

            parametro = new SqlParameter("@ROL_ID", SqlDbType.Int, 100);
            parametro.Value = rol.id;
            parametros.Add(parametro);

            parametro = new SqlParameter("@FUNCIONALIDAD_ID", SqlDbType.Int, 100);
            parametro.Value = funcionalidad.id;
            parametros.Add(parametro);

            BasesDeDatos.EscribirEnBase("GoodTimes.AgregarFuncionalidadARol", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }
    }
}
