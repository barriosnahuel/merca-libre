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
           
                empresa.nombreContacto = nombre.Text;
                empresa.razon_social = razonSocial.Text;
                empresa.mail = mail.Text;
                empresa.telefono = telefono.Text;
                empresa.codigo_postal = codigoPostal.Text;
                empresa.direccion = direccion.Text;
                empresa.localidad = localidad.Text;
                empresa.fecha_creacion = Convert.ToDateTime(fecha.Value.ToString());
                empresa.cuit = Int64.Parse(cuit.Text);
                if (EmpresaValidaciones.validate(empresa, true))
                {
                    Empresas.crearEmpresa(empresa);
                    MessageBox.Show("El usuario empresa se creó con exito", "Exito");
                    this.Close();
                }
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

    }
}
