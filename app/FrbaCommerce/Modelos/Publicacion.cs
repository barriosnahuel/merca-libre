using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    class Publicacion
    {
        public Int64 id { get; set; }
        public Int64 usuario_id { get; set; }
        public String descripcion { get; set; }
        public float precio { get; set; }
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        public TipoPublicacion tipo { get; set; }
        public EstadoPublicacion estado { get; set; }
        public Visibilidad visibilidad { get; set; }
        public Boolean admitePregunta { get; set; }
        public List<Rubro> rubros { get; set; }

    }
}
