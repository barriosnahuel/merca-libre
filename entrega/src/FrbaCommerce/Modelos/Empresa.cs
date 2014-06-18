using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class Empresa : Usuario
    {
        public Int64 empresa_id { get; set; }
        public String razon_social { get; set; }
        public String nombreContacto { get; set; }
        public String cuit { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
