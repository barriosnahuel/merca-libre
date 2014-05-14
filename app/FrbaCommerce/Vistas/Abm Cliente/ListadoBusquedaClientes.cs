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
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                MessageBox.Show(listadoClientes.SelectedRows[0].Index.ToString(), "Selected Rows");
            }
            else
            {
                MessageBox.Show("Debes elegir una fila de cliente para modificarlo.", "Error");
            }
        }

    }
}
