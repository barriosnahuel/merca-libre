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
    class ComprasSinCalificar
    {

        private static CompraSinCalificar getCompra(SqlDataReader lector)
        {
            CompraSinCalificar unaCompra = new CompraSinCalificar();
            unaCompra.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));
            unaCompra.fecha = lector.GetDateTime(lector.GetOrdinal("FECHA"));
            unaCompra.id = lector.GetInt64(lector.GetOrdinal("ID"));
            unaCompra.username = lector.GetString(lector.GetOrdinal("USERNAME"));

            return unaCompra;
        }

        public static List<CompraSinCalificar> BuscarPorUsuario(long IdUsuario)
        {
            List<CompraSinCalificar> listaCompras = new List<CompraSinCalificar>();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID", IdUsuario);
            parametros.Add(p1);
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarComprasSinCalificarPorUsuario", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    CompraSinCalificar unaCompra = getCompra(lector);
                    listaCompras.Add(unaCompra);
                }
            }

            lector.Close();

            return listaCompras;
        }

    }
}
