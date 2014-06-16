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
    class FormasPago
    {

        private static FormaPago getFormaPago(SqlDataReader lector)
        {
            FormaPago unaForma = new FormaPago();
            unaForma.id = lector.GetInt16(lector.GetOrdinal("ID"));
            unaForma.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));

            return unaForma;
        }

        public static List<FormaPago> ObtenerTodas()
        {
            List<FormaPago> listaFormas = new List<FormaPago>();
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("SELECT * FROM GOODTIMES.FORMA_PAGO");

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    FormaPago unForma = getFormaPago(lector);
                    listaFormas.Add(unForma);
                }
            }

            lector.Close();

            return listaFormas;
        }

    }
}
