using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class Rol
    {

        Int32 _id;
        String _nombre;
        Boolean _habilitado;
        Boolean _eliminado;
        List<Funcion> _funciones;

        public Rol()
        {
            _funciones = new List<Funcion>();
        }


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

        public Boolean habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public Boolean eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        public List<Funcion> funciones
        {
            get { return _funciones; }
            set { _funciones = value; }
        }


    }
}
