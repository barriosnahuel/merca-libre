using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class CompraHistorial
    {

        String _descripcion;
        double _precio;
        Int64 _cantidad;
        double _total;
        DateTime _fecha;

        public String descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public double precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Int64 cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public double total
        {
            get { return _total; }
            set { _total = value; }
        }

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

    }
}
