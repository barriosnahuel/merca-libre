using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Servicios;
using FrbaCommerce.Modelos;
using FrbaCommerce.Vistas.Gestion_de_Preguntas;

namespace FrbaCommerce.Vistas.Ver_publicaciones
{
    public partial class ListadoDePublicaciones : Form
    {
        public ListadoDePublicaciones()
        {
            //TODO HARDCODEADO el ID DE USUARIO A BUSCAR.
            InitializeComponent();
            listadoPublicaciones.DataSource = Publicaciones.buscar(-1, Session.usuario.id);
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            //TODO modificar
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
