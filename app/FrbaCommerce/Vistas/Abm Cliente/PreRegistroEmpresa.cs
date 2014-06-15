using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Vistas.Registro_de_Usuario;
using FrbaCommerce.Util;
using FrbaCommerce.Servicios;

namespace FrbaCommerce.Vistas.Abm_Cliente
{
    public partial class PreRegistroEmpresa : Form
    {
        public PreRegistroEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!FormValidate.StringIsNullOrEmpty(username.Text, "username"))
            {
                return;
            }
            if (Usuarios.buscarUsuarioPorUsername(username.Text) != null)
            {
                MessageBox.Show("Existe un usuario con el username: " + username.Text, "Error de validación.");
                return;
            }

            String contrasenia = Utiles.Password.encriptarPassword("passwordNuevoACambiar");
            RegistroPasoDosEmpresa siguienteVentana = new RegistroPasoDosEmpresa(username.Text, contrasenia);
            siguienteVentana.Show();
            this.Close();    
        }
    }
}
