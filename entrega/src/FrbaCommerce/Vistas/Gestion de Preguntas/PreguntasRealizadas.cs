using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;
using FrbaCommerce.Servicios;
using FrbaCommerce.Util;

namespace FrbaCommerce.Vistas.Gestion_de_Preguntas
{
    public partial class PreguntasRealizadas : Form
    {
        public PreguntasRealizadas()
        {
            if (FormValidate.isUserLoggedIn())
            {
                List<Pregunta> preguntas = Preguntas.buscarPorIdUsuario(Session.usuario.id);
                if (preguntas.Count() == 0)
                {
                    MessageBox.Show("No hay preguntas realizadas");
                    this.Close();
                }
                else
                {
                    InitializeComponent();
                    listadoPreguntas.DataSource = preguntas;
                    this.Show();
                }
            }
        }
    }
}
