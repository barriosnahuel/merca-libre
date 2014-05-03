using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class Funcion
    {
        Int32 _id;
        String _nombre;

        public Int32 id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
