using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class ItemFactura
    {
        public long idPublicacion { get; set; }
        public long idCompra { get; set; }
        public long idFactura { get; set; }
        public DateTime fecha { get; set; }
        public double monto { get; set; }
        public int cantidad { get; set; }
        public String detalle { get; set; }
    }
}
