using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    public class Publicacion
    {
        public Int64 id { get; set; }
        public Usuario usuario { get; set; }
        public String descripcion { get; set; }
        public Int32 unidades { get; set; }
        public Double precio { get; set; }
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        public TipoPublicacion tipo { get; set; }
        public EstadoPublicacion estado { get; set; }
        public Visibilidad visibilidad { get; set; }
        public Boolean admitePregunta { get; set; }
        public List<Rubro> rubros { get; set; }

        public Publicacion()
        {
            this.rubros = new List<Rubro>();
            this.estado = new EstadoPublicacion();
            this.visibilidad = new Visibilidad();
        }

        public String tipoDescripcion
        {
            get { return tipo.descripcion; }
            set { tipo.descripcion = value; }
        }
    }
}
