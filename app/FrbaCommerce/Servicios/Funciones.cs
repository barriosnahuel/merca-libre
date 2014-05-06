using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelos;
using Utiles;
using System.Data;
using System.Data.SqlClient;

namespace FrbaCommerce.Servicios
{
    class Funciones
    {

        private static Funcion getFuncion(SqlDataReader lector)
        {
            Funcion unaFuncion = new Funcion();
            unaFuncion.id = lector.GetInt32(lector.GetOrdinal("ID"));
            unaFuncion.nombre = lector.GetString(lector.GetOrdinal("NOMBRE"));

            return unaFuncion;
        }

        public static List<Funcion> ObtenerTodas()
        {
            List<Funcion> listaFunciones = new List<Funcion>();

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT * FROM FUNCIONALIDAD");

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcion unRol = getFuncion(lector);
                    listaFunciones.Add(unRol);
                }
            }

            lector.Close();

            return listaFunciones;
        }

        public static List<Funcion> ObtenerPorRol(Int32 idRol)
        {
            List<Funcion> listaFunciones = new List<Funcion>();

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT F.* FROM FUNCIONALIDAD F JOIN FUNCIONALIDAD_X_ROL FR ON F.ID = FR.FUNCIONALIDAD_ID WHERE FR.ROL_ID = " + idRol);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcion unRol = getFuncion(lector);
                    listaFunciones.Add(unRol);
                }
            }

            lector.Close();

            return listaFunciones;
        }

        public static List<Funcion> ObtenerNotRol(Int32 idRol)
        {
            List<Funcion> listaFunciones = new List<Funcion>();

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT F.* FROM FUNCIONALIDAD F LEFT JOIN FUNCIONALIDAD_X_ROL FR ON F.ID = FR.FUNCIONALIDAD_ID WHERE FR.ROL_ID <> "+idRol+" OR FR.ROL_ID IS NULL");

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcion unRol = getFuncion(lector);
                    listaFunciones.Add(unRol);
                }
            }

            lector.Close();

            return listaFunciones;
        }

    }
}
