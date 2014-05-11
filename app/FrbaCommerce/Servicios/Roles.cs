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

    }
}
