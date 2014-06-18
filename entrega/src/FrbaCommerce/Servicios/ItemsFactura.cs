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
            unItem.idPublicacion = lector.GetInt64(lector.GetOrdinal("PUBLICACION_ID"));
            unItem.detalle = lector.GetString(lector.GetOrdinal("DETALLE"));
            unItem.cantidad = int.Parse(lector.GetDecimal(lector.GetOrdinal("CANTIDAD")).ToString());
            unItem.monto = double.Parse(lector.GetDecimal(lector.GetOrdinal("MONTO")).ToString());
            if (!lector.IsDBNull(lector.GetOrdinal("COMPRA_ID")))
            {
                unItem.idCompra = lector.GetInt64(lector.GetOrdinal("COMPRA_ID"));
            }
            else {
                unItem.idCompra = 0;
            };
            unItem.fecha = lector.GetDateTime(lector.GetOrdinal("FECHA"));

            return unItem;
        }

        public static List<ItemFactura> ObtenerItemsSinFacturar(long idUsuario)
        {
            List<ItemFactura> listaItems = new List<ItemFactura>();
            
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("USUARIO_ID", idUsuario);
            parametros.Add(p1);
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.ObtenerItemsSinFacturar", BasesDeDatos.Tipos.StoreProcedure, parametros);

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

        public static void Guardar(ItemFactura item)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("FACTURA_ID", item.idFactura);
            SqlParameter p2;
            if (item.idCompra > 0)
            {
                 p2 = new SqlParameter("COMPRA_ID", item.idCompra);
            }
            else
            {
                p2 = new SqlParameter("COMPRA_ID", DBNull.Value);
            }
            SqlParameter p3 = new SqlParameter("PUBLICACION_ID", item.idPublicacion);
            SqlParameter p4 = new SqlParameter("CANTIDAD", item.cantidad);
            SqlParameter p5 = new SqlParameter("MONTO", item.monto);
            SqlParameter p6 = new SqlParameter("DETALLE", item.detalle);
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);
            parametros.Add(p5);
            parametros.Add(p6);
            
            BasesDeDatos.EscribirEnBase("GOODTIMES.CrearItemFactura", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
        }
    
    }
}
