using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class OfertaHistorial
    {
        String _descripcion;
        double _monto;
        DateTime _fecha;
        String _gano;

        public String descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public double monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public String gano
        {
            get { return _gano; }
            set { _gano = value; }
        }

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

    }
}
