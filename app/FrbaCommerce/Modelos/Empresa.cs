using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    class Empresa : Usuario
    {
        public Int64 empresa_id { get; set; }
        public String razon_social { get; set; }
        public String nombreContacto { get; set; }
        public Int64 cuit { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
