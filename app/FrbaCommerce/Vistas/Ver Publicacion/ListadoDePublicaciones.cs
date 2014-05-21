using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Vistas.Ver_publicaciones
{
    public partial class ListadoDePublicaciones : Form
    {
        public ListadoDePublicaciones()
        {
            //TODO cargar el listado con las publicaciones.
            InitializeComponent();
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            //TODO ir a pantalla para modificar el articulo seleccionado.
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            //TODO invocar servicio para dejar como "borrado" a la publicacion.
        }

        private void responder_button_Click(object sender, EventArgs e)
        {
            //TODO ir a la pantalla de las preguntas que están sin responder de la publicacion.
        }


    }
}
