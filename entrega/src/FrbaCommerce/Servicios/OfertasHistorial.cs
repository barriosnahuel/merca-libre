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
    class OfertasHistorial
    {

        private static OfertaHistorial getOferta(SqlDataReader lector)
        {
            OfertaHistorial unaOferta = new OfertaHistorial();
            unaOferta.gano = lector.GetString(lector.GetOrdinal("GANO"));
            unaOferta.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));
            unaOferta.fecha = lector.GetDateTime(lector.GetOrdinal("FECHA"));
            unaOferta.monto = double.Parse(lector.GetDecimal(lector.GetOrdinal("MONTO")).ToString());

            return unaOferta;
        }

        public static List<OfertaHistorial> BuscarPorUsuario(long IdUsuario)
        {
            List<OfertaHistorial> listaOfertas = new List<OfertaHistorial>();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID", IdUsuario);
            parametros.Add(p1);
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarOfertasPorUsuario", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    OfertaHistorial unaOferta = getOferta(lector);
                    listaOfertas.Add(unaOferta);
                }
            }

            lector.Close();

            return listaOfertas;
        }

    }
}
