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
    public partial class CuadroPreguntar : Form
    {
        Int64 publicacion_id;

        public CuadroPreguntar(Int64 publicacion_id)
        {
            InitializeComponent();
            this.publicacion_id = publicacion_id;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(pregunta.Text) && pregunta.Text.Length < 255)
            {
                Preguntas.preguntar(publicacion_id, pregunta.Text);
                MessageBox.Show("Hiciste una pregunta con exito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes escribir una pregunta y tiene que ser menor a 255 caracteres.");
            }
        }


    }
}
