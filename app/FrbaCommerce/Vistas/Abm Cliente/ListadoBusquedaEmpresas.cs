using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Servicios;
using FrbaCommerce.Vistas.Registro_de_Usuario;
using FrbaCommerce.Modelos;
using FrbaCommerce.Util;

namespace FrbaCommerce.Vistas.Abm_Cliente
{
    public partial class ListadoBusquedaEmpresas : Form
    {
        public ListadoBusquedaEmpresas()
        {
            InitializeComponent();
            listadoEmpresas.DataSource = Empresas.buscar(null, null, null);
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            listadoEmpresas.DataSource = Empresas.buscar(razon_social_search.Text, cuit_search.Text, contacto_search.Text);
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            cuit_search.Text = "";
            contacto_search.Text = "";
            razon_social_search.Text = "";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //TODO Definir como es el nombre de usuario "por defecto".
            RegistroPasoDosEmpresa siguienteVentana = new RegistroPasoDosEmpresa("usernamePorDefecto", "passwordpordefecto");
            siguienteVentana.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
                if (!confirmacionPorMensaje()) return;
                Empresa empresa = (Empresa)listadoEmpresas.CurrentRow.DataBoundItem;
                Empresas.eliminarEmpresa(empresa.id);
                listadoEmpresas.DataSource = Empresas.buscar(razon_social_search.Text, cuit_search.Text, contacto_search.Text);
                MessageBox.Show("Eliminaste la empresa con exito", "Exito");
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            if (!confirmacionPorMensaje()) return;

            Empresa empresa = (Empresa)listadoEmpresas.CurrentRow.DataBoundItem;
            if (EmpresaValidaciones.validate(empresa, false))
            {
                Empresas.actualizarEmpresa(empresa);
                listadoEmpresas.DataSource = Empresas.buscar(razon_social_search.Text, cuit_search.Text, contacto_search.Text);
                MessageBox.Show("Modificaste la empresa con exito", "Exito");
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

    }
}
