using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Utiles;

namespace FrbaCommerce.Servicios
{
    class Roles
    {

        public static Int32 ObtenerCantidad()
        {
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT COUNT(*) FROM gd_esquema.Maestra");
            lector.Read();

            Int32 cantidad = 0;
            if (lector.HasRows)
            {
                cantidad = lector.GetInt32(0);
            }

            lector.Close();

            return cantidad;
        }

        public static DataSet ObtenerRoles()
        {
            DataSet ds = BasesDeDatos.ObtenerDataSet("SELECT TOP 5 * FROM gd_esquema.Maestra");
            
            return ds;
        }

    }
}
