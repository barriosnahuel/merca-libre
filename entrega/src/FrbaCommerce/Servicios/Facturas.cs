using System;
using System.Collections.Generic;
using FrbaCommerce.Modelos;
using System.Data.SqlClient;
using System.Data;
using Utiles;

namespace FrbaCommerce.Servicios
{
    class Facturas
    {
        public static long guardar(long idUsuario, DateTime fecha, int idFormaPago)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("USUARIO_ID", idUsuario));
            parametros.Add(new SqlParameter("FECHA", fecha));
            parametros.Add(new SqlParameter("FORMA_PAGO_ID", idFormaPago));

            return BasesDeDatos.queryForInt64("GoodTimes.GuardarFactura", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

    }
}
