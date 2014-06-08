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


        public static List<EstadoPublicacion> estadosValidosPublicacion(Publicacion publicacion)
        {
            List<EstadoPublicacion> estados = EstadosPublicacion.listar();
            if (publicacion != null)
            {
                if (publicacion.estado.descripcion.Equals("Finalizada"))
                {
                    estados = new List<EstadoPublicacion>();
                    estados.Add(publicacion.estado);
                }
                else
                {
                    estados = EstadosPublicacion.listar();
                    
                    if (!publicacion.estado.descripcion.Equals("Borrador"))
                        estados.Remove(estados.Find(estado => estado.descripcion.Equals("Borrador")));
                }
            }
            return estados;

        }

        private static EstadoPublicacion getEstado(SqlDataReader lector)
        {
            EstadoPublicacion estado = new EstadoPublicacion();
            estado.id = lector.GetInt16(lector.GetOrdinal("ID"));
            estado.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));

            return estado;
        }

        internal static EstadoPublicacion buscar(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ID", id));

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarEstadoPublicacion", BasesDeDatos.Tipos.StoreProcedure, parametros);

            EstadoPublicacion estado = null;



            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    estado = getEstado(lector);
                }

            }
            lector.Close();
            return estado;
        }
    }
}
