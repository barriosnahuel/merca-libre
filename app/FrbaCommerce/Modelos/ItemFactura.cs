using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class ItemFactura
    {
        public long idPublicacion { get; set; }
        public String descripcion { get; set; }
        public double monto { get; set; }
        public int cantidad { get; set; }
        public String detalle { get; set; }
    }
}
