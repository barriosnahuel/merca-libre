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
    class Calificaciones
    {

        public static void GuardarCalificacion(long idUsuario, long idCompra, int puntaje, String comentario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("USUARIO_ID", idUsuario);
            SqlParameter p2 = new SqlParameter("COMPRA_ID", idCompra);
            SqlParameter p3 = new SqlParameter("PUNTAJE", puntaje);
            SqlParameter p4 = new SqlParameter("DETALLE", comentario);
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);
            
            BasesDeDatos.EscribirEnBase("GOODTIMES.GuardarCalificacion", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }

    }
}
