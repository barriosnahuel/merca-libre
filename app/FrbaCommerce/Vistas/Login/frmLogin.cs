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
            if ((usuario.Text.Length > 0) && (contrasenia.Text.Length > 0))
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
                        MessageBox.Show("Contraseña incorrecta.", "Ok");
                        break;
                    case 2:
                        MessageBox.Show("Usuario inexistente.", "Ok");
                        break;
                    case 3:
                        MessageBox.Show("Usuario alcanzo el límite de intentos.", "Ok");
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
