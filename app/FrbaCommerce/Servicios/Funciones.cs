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

            //ListarFuncionalidad
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT * FROM GOODTIMES.FUNCIONALIDAD");

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
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametro;

            parametro = new SqlParameter("@ID_ROL", SqlDbType.Int, 100);
            parametro.Value = idRol;
            parametros.Add(parametro);


            //ListarFuncionalidadPorRol
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GoodTimes.ListarFuncionalidadPorRol", BasesDeDatos.Tipos.StoreProcedure, parametros);

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
            //BuscarFuncionalidadSinAsignarARol
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT F.*"  
                + " FROM GOODTIMES.FUNCIONALIDAD F"
                + " EXCEPT"
                + " SELECT F.* "
                + " FROM GOODTIMES.FUNCIONALIDAD F "
                + " JOIN GOODTIMES.FUNCIONALIDAD_X_ROL FR ON F.ID = FR.FUNCIONALIDAD_ID "
                + " WHERE FR.ROL_ID =" + idRol + " OR FR.ROL_ID IS NULL");

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
