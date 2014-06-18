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

namespace FrbaCommerce.Vistas.Gestion_de_Preguntas
{
    public partial class ResponderPregunta : Form
    {
        public ResponderPregunta(Int64 publicacion_id)
        {
            List<Pregunta> preguntas = Preguntas.buscarPorIdPublicacion(publicacion_id);
            if (preguntas.Count() == 0)
            {
                MessageBox.Show("No hay preguntas para responder");
                this.Close();
            }
            else
            {
                InitializeComponent();
                listadoPreguntas.DataSource = preguntas;
                this.Show();
            }
        }

        private void responderButton_Click(object sender, EventArgs e)
        {
            Pregunta pregunta = (Pregunta)listadoPreguntas.CurrentRow.DataBoundItem;
            if(String.IsNullOrEmpty(pregunta.respuesta))
            {
                CuadroResponder cuadroResponder = new CuadroResponder(pregunta.id);
                cuadroResponder.Show();
            }
            else 
            {
                MessageBox.Show("Ya respondiste esa pregunta.");
            }
            
        }

    }
}
