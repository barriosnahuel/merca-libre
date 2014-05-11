using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;
using FrbaCommerce.Vistas.Registro_de_Usuario;
using FrbaCommerce.Util;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class RegistroPasoUno : Form
    {
        private static String CLIENTE = "Cliente";
        private static String EMPRESA = "Empresa";

        public RegistroPasoUno()
        {
            InitializeComponent();
        }

        private void borrar_button_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password1.Text = "";
            password2.Text = "";
            rol.SelectedItem = "Cliente";
        }

        private void siguiente_button_Click(object sender, EventArgs e)
        {
            String rolText = rol.Text;
            if (validate())
            {
                if (rolText.Equals(CLIENTE))
                {
                    RegistroPasoDosCliente siguienteVentana = new RegistroPasoDosCliente(username.Text, password2.Text);
                    siguienteVentana.Show();
                }
                else if (rolText.Equals(EMPRESA))
                {
                    RegistroPasoDosEmpresa siguienteVentana = new RegistroPasoDosEmpresa(username.Text, password2.Text);
                    siguienteVentana.Show();
                }
                this.Close();
            }
        }

        private Boolean validate()
        {

            if (!validateEmptyFields())
            {
                return false;
            }

            //TODO Verificar si el usuario existe en la base de datos.

            return true;
        }

        private Boolean validateEmptyFields()
        {
            if (!FormValidate.StringIsNullOrEmpty(username.Text, "username"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(password1.Text, "password"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(password2.Text, "re-password"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(rol.SelectedItem.ToString(), "rol"))
            {
                return false;
            }

            return true;
        }

    }
}
