using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelos
{
    class Pregunta
    {
        public Int64 id { get; set; }
        public Int64 usuario_id { get; set; }
        public Publicacion publicacion { get; set; }
        public String pregunta { get; set; }
        public DateTime fechaPregunta { get; set; }
        public String respuesta { get; set; }
        public DateTime fechaRespuesta { get; set; }

        public String publicacionDescripcion
        {
            get { return this.publicacion.descripcion; }
            set { publicacion.descripcion = value; }
        }
    }
}
