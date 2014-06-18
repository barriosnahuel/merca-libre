using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Servicios;

namespace FrbaCommerce.Vistas.Gestion_de_Preguntas
{
    public partial class CuadroResponder : Form
    {
        Int64 idPregunta;

        public CuadroResponder(Int64 pregunta_id)
        {
            InitializeComponent();
            this.idPregunta = pregunta_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(respuesta.Text))
            {
                Preguntas.responder(idPregunta, respuesta.Text);
                MessageBox.Show("Respondiste la pregunta con exito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes escribir una respuesta.");
            }
        }
    }
}
