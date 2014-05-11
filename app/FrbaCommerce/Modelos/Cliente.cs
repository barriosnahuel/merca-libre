using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    class Cliente : Usuario
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public String dni_tipo { get; set; }
        public DateTime fecha_nac { get; set; }
    }
}
