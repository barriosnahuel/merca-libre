using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelos;
using Utiles;
using System.Data.SqlClient;

namespace FrbaCommerce.Servicios
{
    class EstadosPublicacion
    {

        public static List<EstadoPublicacion> listar () {

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("Select * from GOODTIMES.ESTADO");

            List<EstadoPublicacion> estados = new List<EstadoPublicacion>();

            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    estados.Add(getEstado(lector));
                }

            }
            lector.Close();
            return estados;
        
        }

        private static EstadoPublicacion getEstado(SqlDataReader lector)
        {
            EstadoPublicacion estado = new EstadoPublicacion();
            estado.id = lector.GetInt16(lector.GetOrdinal("ID"));
            estado.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));

            return estado;
        }
    }
}
