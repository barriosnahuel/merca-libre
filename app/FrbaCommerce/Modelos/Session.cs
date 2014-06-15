using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    static class Session
    {
        public static Usuario usuario;

        public static DateTime fechaAhora()
        {
            return DateTime.Now ;
        }
    }
}
