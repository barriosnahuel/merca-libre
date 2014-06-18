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
    class Tarjetas
    {

        public static void Guardar(long idFactura, String numero, String titular, String codigo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("FACTURA_ID", idFactura);
            SqlParameter p2 = new SqlParameter("NUMERO", numero);
            SqlParameter p3 = new SqlParameter("TITULAR", titular);
            SqlParameter p4 = new SqlParameter("CODIGO_SEGURIDAD", codigo);
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);

            BasesDeDatos.EscribirEnBase("GOODTIMES.GuardarTarjeta", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }
    
    }
}
