using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Vistas.Registro_de_Usuario
{
    public partial class VentanaError : Form
    {
        public VentanaError(String textoMensaje)
        {
            InitializeComponent();
            mensaje.Text = textoMensaje;
        }

        private void cerrar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
