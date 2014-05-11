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

namespace FrbaCommerce.Vistas.Registro_de_Usuario
{
    public partial class RegistroPasoDosCliente : Form
    {

        private Cliente cliente;

        public RegistroPasoDosCliente(String username, String password)
        {
            cliente = new Cliente();
            cliente.username = username;
            cliente.password = password;
            InitializeComponent();
        }

        private void crear_button_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                cliente.nombre = nombre.Text;
                cliente.apellido = apellido.Text;
                cliente.dni_tipo = tipoDoc.Text;
                cliente.dni = documento.Text;
                cliente.mail = mail.Text;
                cliente.telefono = telefono.Text;
                cliente.codigo_postal = codigoPostal.Text;
                cliente.direccion = direccion.Text;
                cliente.localidad = localidad.Text;
                cliente.fecha_nac = Convert.ToDateTime(fecha.Value.ToString());
                cliente.habilitado = true;
                cliente.eliminado = false;
                cliente.login_fallidos = 0;
                // TODO Invocar service para persistir los datos.
            }
        }

        private void borrar_button_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            tipoDoc.Text = "";
            documento.Text = "";
            mail.Text = "";
            telefono.Text = "";
            codigoPostal.Text = "";
            direccion.Text = "";
            localidad.Text = "";
        }

        private Boolean validate()
        {
            if (!validateEmptyFields())
            {
                return false;
            }

            //TODO Validar que el telefono no exista previamente.
            //TODO Validar que el TIPO Y NUMERO de DOCUMENTO no exista previamente.
            return true;
        }

        private Boolean validateEmptyFields()
        {
            
            if(!FormValidate.StringIsNullOrEmpty(nombre.Text, "nombre"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(apellido.Text, "apellido"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(tipoDoc.Text, "tipo de documento"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(documento.Text, "documento"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(mail.Text, "mail"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(telefono.Text, "telefono"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(codigoPostal.Text, "codigopPostal"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(direccion.Text, "direccion"))
            {
                return false;
            }

            if(!FormValidate.StringIsNullOrEmpty(localidad.Text, "localidad"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(apellido.Text, "apellido"))
            {
                return false;
            }

            return true;
        }

    }
}
