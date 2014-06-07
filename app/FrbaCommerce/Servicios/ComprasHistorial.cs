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
    class ComprasHistorial
    {

        private static CompraHistorial getCompra(SqlDataReader lector)
        {
            CompraHistorial unaCompra = new CompraHistorial();
            unaCompra.cantidad = Int64.Parse(lector.GetDecimal(lector.GetOrdinal("CANTIDAD")).ToString());
            unaCompra.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));
            unaCompra.fecha = lector.GetDateTime(lector.GetOrdinal("FECHA"));
            unaCompra.precio = double.Parse(lector.GetDecimal(lector.GetOrdinal("PRECIO")).ToString());
            unaCompra.total = double.Parse(lector.GetDecimal(lector.GetOrdinal("TOTAL")).ToString());

            return unaCompra;
        }

        public static List<CompraHistorial> BuscarPorUsuario(long IdUsuario)
        {
            List<CompraHistorial> listaCompras = new List<CompraHistorial>();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID", IdUsuario);
            parametros.Add(p1);
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarComprasPorUsuario", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    CompraHistorial unaCompra = getCompra(lector);
                    listaCompras.Add(unaCompra);
                }
            }

            lector.Close();

            return listaCompras;
        }

    }
}
