﻿using System;
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
using FrbaCommerce.Vistas.Abm_Cliente;
using FrbaCommerce.Vistas.Login;

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
            List<Cliente> clientes = Clientes.Buscar(nombre_search.Text, apellido_search.Text, 
                mail_search.Text, tipoDoc_search.Text, documento_search.Text);
            listadoClientes.DataSource = clientes;
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
                if (!confirmacionPorMensaje()) return;

                Cliente cliente = (Cliente)listadoClientes.CurrentRow.DataBoundItem;
                if (ClienteValidaciones.validate(cliente, false))
                {
                    Clientes.actualizarCliente(cliente);
                    listadoClientes.DataSource = Clientes.Buscar(nombre_search.Text, apellido_search.Text, 
                        mail_search.Text, tipoDoc_search.Text, documento_search.Text);
                    MessageBox.Show("Actualizaste el cliente con exito", "Exito");
                }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
                if (!confirmacionPorMensaje()) return;
                Cliente cliente = (Cliente)listadoClientes.CurrentRow.DataBoundItem;
                Clientes.eliminarCliente(cliente.id);
                listadoClientes.DataSource = Clientes.Buscar(nombre_search.Text, apellido_search.Text, 
                    mail_search.Text, tipoDoc_search.Text, documento_search.Text);
                MessageBox.Show("Eliminaste el cliente con exito", "Exito");

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
            PreRegistroCliente form = new PreRegistroCliente();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listadoClientes.CurrentRow.DataBoundItem;
            CambiarPassword form = new CambiarPassword(cliente.id);
            form.Show();
        }

    }
}
