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
    class ItemsFactura
    {

        private static ItemFactura getItem(SqlDataReader lector)
        {
            ItemFactura unItem = new ItemFactura();
            unItem.idPublicacion = lector.GetInt64(lector.GetOrdinal("ID"));
            unItem.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));
            unItem.detalle = lector.GetString(lector.GetOrdinal("DETALLE"));
            unItem.cantidad = int.Parse(lector.GetDecimal(lector.GetOrdinal("CANTIDAD")).ToString());
            unItem.monto = double.Parse(lector.GetDecimal(lector.GetOrdinal("MONTO")).ToString()); 

            return unItem;
        }

        public static List<ItemFactura> GenerarPorPublicacion(long idPublicacion)
        {
            List<ItemFactura> listaItems = new List<ItemFactura>();
            
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("PUBLICACION_ID", idPublicacion);
            parametros.Add(p1);
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.GenerarDetalleFactura", BasesDeDatos.Tipos.StoreProcedure, parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ItemFactura unItem = getItem(lector);
                    listaItems.Add(unItem);
                }
            }

            lector.Close();

            return listaItems;
        }
    
    }
}
