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

namespace FrbaCommerce.Vistas.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
                        frmPrincipal formPrincipal = new frmPrincipal();
                        formPrincipal.Show();
                        this.Close();
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

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
