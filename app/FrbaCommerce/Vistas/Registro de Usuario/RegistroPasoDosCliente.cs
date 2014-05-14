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
            
            cliente.nombre = nombre.Text;
            cliente.apellido = apellido.Text;
            cliente.dni_tipo = tipoDoc.Text;
            cliente.dni = documento.Text;
            cliente.mail = mail.Text;
            cliente.telefono = telefono.Text;
            cliente.codigo_postal = codigoPostal.Text;
            cliente.direccion = direccion.Text;
            cliente.localidad = localidad.Text;
            cliente.fecha_nacimiento = Convert.ToDateTime(fecha.Value.ToString());
            cliente.habilitado = true;
            cliente.eliminado = false;
            cliente.login_fallidos = 0;
            if (ClienteValidaciones.validate(cliente))
            {
                Clientes.crearCliente(cliente);
                MessageBox.Show("El usuario cliente se creó con exito", "Exito");
                this.Close();
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

    }
}
