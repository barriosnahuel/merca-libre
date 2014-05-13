using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;
using FrbaCommerce.Util;
using FrbaCommerce.Servicios;

namespace FrbaCommerce.Vistas.Registro_de_Usuario
{
    public partial class RegistroPasoDosEmpresa : Form
    {
        private Empresa empresa;

        public RegistroPasoDosEmpresa(String username, String password)
        {
            empresa = new Empresa();
            empresa.username = username;
            empresa.password = password;
            InitializeComponent();
        }

        private void crear_button_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                empresa.nombreContacto = nombre.Text;
                empresa.razon_social = razonSocial.Text;
                empresa.mail = mail.Text;
                empresa.telefono = telefono.Text;
                empresa.codigo_postal = codigoPostal.Text;
                empresa.direccion = direccion.Text;
                empresa.localidad = localidad.Text;
                empresa.cuit = Int64.Parse(cuit.Text);
                Empresas.crearEmpresa(empresa);
                VentanaMensaje ventanaMensaje = new VentanaMensaje("El usuario empresa se creó con exito");
                ventanaMensaje.Show();
                this.Close();
            }
        }

        private Boolean validate()
        {
            if (!validateEmptyFields())
            {
                return false;
            }

            //TODO Validar si ya existe una empresa con la razon social.
            //TODO Validar si ya existe una empresa con el cuit.
            return true;
        }

        private void borrar_button_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            razonSocial.Text = "";
            mail.Text = "";
            telefono.Text = "";
            codigoPostal.Text = "";
            direccion.Text = "";
            localidad.Text = "";
            cuit.Text = "";
        }

        private Boolean validateEmptyFields()
        {

            if (!FormValidate.StringIsNullOrEmpty(nombre.Text, "nombre"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(razonSocial.Text, "razon social"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(mail.Text, "e-mail"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(telefono.Text, "telefono"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(codigoPostal.Text, "codigo postal"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(direccion.Text, "direccion"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(localidad.Text, "localidad"))
            {
                return false;
            }
            if (!FormValidate.StringIsNullOrEmpty(cuit.Text, "cuit"))
            {
                return false;
            }

            return true;
        }

    }
}
