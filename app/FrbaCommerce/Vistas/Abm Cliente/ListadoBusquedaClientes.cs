using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Servicios;
using FrbaCommerce.Modelos;
using FrbaCommerce.Vistas.Registro_de_Usuario;
using FrbaCommerce.Util;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ListadoBusquedaClientes : Form
    {
        public ListadoBusquedaClientes()
        {
            InitializeComponent();
            List<Cliente> clientes = Clientes.Buscar(null, null, null, null, null);
            listadoClientes.DataSource = clientes;
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            nombre_search.Text = "";
            apellido_search.Text = "";
            mail_search.Text = "";
            tipoDoc_search.Text = "";
            documento_search.Text = "";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = Clientes.Buscar(nombre_search.Text, apellido_search.Text, mail_search.Text, tipoDoc_search.Text, documento_search.Text);
            listadoClientes.DataSource = clientes;
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        listadoClientes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (!confirmacionPorMensaje()) return;
                Cliente cliente = new Cliente();

                cliente.id = (Int64)listadoClientes.SelectedRows[0].Cells["id"].Value;
                cliente.username = (String)listadoClientes.SelectedRows[0].Cells["username"].Value;
                cliente.habilitado = (Boolean)listadoClientes.SelectedRows[0].Cells["habilitado"].Value;
                cliente.eliminado = (Boolean)listadoClientes.SelectedRows[0].Cells["eliminado"].Value;
                cliente.mail = (String)listadoClientes.SelectedRows[0].Cells["mail"].Value;
                cliente.telefono = (String)listadoClientes.SelectedRows[0].Cells["telefono"].Value;
                cliente.direccion = (String)listadoClientes.SelectedRows[0].Cells["direccion"].Value;
                cliente.codigo_postal = (String)listadoClientes.SelectedRows[0].Cells["codigo_postal"].Value;
                cliente.localidad = (String)listadoClientes.SelectedRows[0].Cells["localidad"].Value;

                cliente.cliente_id = (Int64)listadoClientes.SelectedRows[0].Cells["cliente_id"].Value;
                cliente.nombre = (String)listadoClientes.SelectedRows[0].Cells["nombre"].Value;
                cliente.apellido = (String)listadoClientes.SelectedRows[0].Cells["apellido"].Value;
                cliente.dni = (String)listadoClientes.SelectedRows[0].Cells["dni"].Value;
                cliente.dni_tipo = (String)listadoClientes.SelectedRows[0].Cells["dni_tipo"].Value;
                cliente.fecha_nacimiento = (DateTime)listadoClientes.SelectedRows[0].Cells["fecha_nacimiento"].Value;

                cliente.login_fallidos = 0;

                if (ClienteValidaciones.validate(cliente, false))
                {
                    Clientes.actualizarCliente(cliente);
                    listadoClientes.DataSource = Clientes.Buscar(nombre_search.Text, apellido_search.Text, mail_search.Text, tipoDoc_search.Text, documento_search.Text);
                    MessageBox.Show("Actualizaste el cliente con exito", "Exito");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir una fila de cliente para modificarlo.", "Error");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = listadoClientes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (!confirmacionPorMensaje()) return;
                Int64 id = (Int64)listadoClientes.SelectedRows[0].Cells["id"].Value;
                Clientes.eliminarCliente(id);
                listadoClientes.DataSource = Clientes.Buscar(nombre_search.Text, apellido_search.Text, mail_search.Text, tipoDoc_search.Text, documento_search.Text);
                MessageBox.Show("Eliminaste el cliente con exito", "Exito");
            }
            else
            {
                MessageBox.Show("Debes elegir una fila de cliente para eliminarlo.", "Error");
            }
        }

        private Boolean confirmacionPorMensaje()
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //TODO Definir como es el nombre de usuario "por defecto".
            RegistroPasoDosCliente siguienteVentana = new RegistroPasoDosCliente("unUsuario", "contraseniaParaCambiar");
            siguienteVentana.Show();
        }

    }
}
