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
using FrbaCommerce.Registro_de_Usuario;
using Utiles;

namespace FrbaCommerce.Vistas.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            BasesDeDatos.connString = Session.ConnectionString();

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (FormValidate.StringIsNullOrEmpty(usuario.Text, "username")
                && FormValidate.StringIsNullOrEmpty(contrasenia.Text, "password"))
            {
                int logeo = Usuarios.logearse(usuario.Text, contrasenia.Text);

                switch (logeo)
                {

                    case 0:
                        Session.usuario = Usuarios.buscarUsuarioPorUsername(usuario.Text);
                        Menu menu = new Menu(this);
                        menu.Show();

                        /** Si el usuario ingresa por primera vez, se asume que tiene esa password **/
                        String contraseniaNuevoUsuario = Utiles.Password.encriptarPassword("passwordNuevoACambiar");
                        String contraseniaNuevoUsuarioIngresada = Utiles.Password.encriptarPassword(contrasenia.Text);
                        if (contraseniaNuevoUsuarioIngresada == contraseniaNuevoUsuario)
                        {
                            CambiarPassword formCambiar = new CambiarPassword(Session.usuario.id);
                            formCambiar.Show();
                        }
                        
                        usuario.Text = "";
                        contrasenia.Text = "";
                        this.Hide();
                        break;
                    case 1:
                        MessageBox.Show("Contraseña incorrecta." ,"Error");
                        break;
                    case 2:
                        MessageBox.Show("Usuario inexistente.", "Error");
                        break;
                    case 3:
                        MessageBox.Show("Usuario alcanzo el límite de intentos.", "Error");
                        break;
                }
            }
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            usuario.Text = "";
            contrasenia.Text = "";
            RegistroPasoUno form = new RegistroPasoUno();
            form.Show();
        }

        private void contrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                aceptar.PerformClick();
        }

    }
}
