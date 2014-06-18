using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class CompraSinCalificar
    {
        
        DateTime _fecha;
        String _username;
        String _descripcion;
        long _id;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public String username
        {
            get { return _username; }
            set { _username = value; }
        }

        public String descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public long id
        {
            get { return _id; }
            set { _id = value; }
        }       

    }
}
