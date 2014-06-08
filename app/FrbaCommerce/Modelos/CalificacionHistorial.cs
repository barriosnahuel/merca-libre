using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class CalificacionHistorial
    {
        
        double _puntaje;
        String _detalle;
        String _username;
        String _descripcion;

        public double puntaje
        {
            get { return _puntaje; }
            set { _puntaje = value; }
        }
        
        public String detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
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

    }
}
