using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    class Usuario
    {
        public Int64 id { get; set; }
        public Int32 login_fallidos { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String mail { get; set; }
        public String telefono { get; set; }
        public String codigo_postal { get; set; }
        public String direccion { get; set; }
        public String localidad { get; set; }
        public Boolean habilitado { get; set; }
        public Boolean eliminado { get; set; }
    }
}
