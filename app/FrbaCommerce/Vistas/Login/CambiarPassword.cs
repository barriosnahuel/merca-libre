using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Util;
using FrbaCommerce.Servicios;

namespace FrbaCommerce.Vistas.Login
{
    public partial class CambiarPassword : Form
    {
        Int64 idUsuario;

        public CambiarPassword(Int64 id)
        {
            InitializeComponent();
            idUsuario = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password1.Text != password2.Text)
            {
                MessageBox.Show("El password y el re-password deben ser iguales.", "Error de validación.");
                return;
            }

            if(!FormValidate.StringIsNullOrEmpty(password1.Text, "password") || !FormValidate.StringIsNullOrEmpty(password2.Text, "re-password"))
            {
                return;
            }

            String contrasenia = Utiles.Password.encriptarPassword(password1.Text);
            Usuarios.cambiarPassword(idUsuario, contrasenia);
            MessageBox.Show("Cambiaste el password con éxito", "Ok");
            this.Close();
        }
    }
}
