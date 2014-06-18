using System;
using System.Windows.Forms;
using FrbaCommerce.Servicios;
using FrbaCommerce.Modelos;
using FrbaCommerce.Vistas.Gestion_de_Preguntas;
using FrbaCommerce.Vistas.Generar_Publicacion;

namespace FrbaCommerce.Vistas.Ver_publicaciones
{
    public partial class ListadoDePublicaciones : Form
    {
        public ListadoDePublicaciones()
        {
            InitializeComponent();
            listadoPublicaciones.DataSource = Publicaciones.buscar(-1, Session.usuario.id);
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = (Publicacion)listadoPublicaciones.CurrentRow.DataBoundItem;
            frmGenerarPublicacion form = new frmGenerarPublicacion(publicacion.id);
            form.Show();
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            //TODO invocar servicio para dejar como "borrado" a la publicacion.
        }

        private void responder_button_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = (Publicacion)listadoPublicaciones.CurrentRow.DataBoundItem;
            ResponderPregunta siguienteVentana = new ResponderPregunta(publicacion.id);
        }

    }
}
