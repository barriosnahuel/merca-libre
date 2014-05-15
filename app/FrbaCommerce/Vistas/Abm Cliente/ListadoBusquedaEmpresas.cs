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
            Int32 selectedRowCount = listadoEmpresas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (!confirmacionPorMensaje()) return;
                Int64 id = (Int64)listadoEmpresas.SelectedRows[0].Cells["id"].Value;
                Empresas.eliminarEmpresa(id);
                listadoEmpresas.DataSource = Empresas.buscar(razon_social_search.Text, cuit_search.Text, contacto_search.Text);
                MessageBox.Show("Eliminaste la empresa con exito", "Exito");
            }
            else
            {
                MessageBox.Show("Debes elegir una fila de empresa para eliminarla.", "Error");
            }
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = listadoEmpresas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (!confirmacionPorMensaje()) return;

                Empresa empresa = new Empresa();
                empresa.id = (Int64)listadoEmpresas.SelectedRows[0].Cells["id"].Value;
                empresa.username = (String)listadoEmpresas.SelectedRows[0].Cells["username"].Value;
                empresa.habilitado = (Boolean)listadoEmpresas.SelectedRows[0].Cells["habilitado"].Value;
                empresa.eliminado = (Boolean)listadoEmpresas.SelectedRows[0].Cells["eliminado"].Value;
                empresa.mail = (String)listadoEmpresas.SelectedRows[0].Cells["mail"].Value;
                empresa.telefono = (String)listadoEmpresas.SelectedRows[0].Cells["telefono"].Value;
                empresa.direccion = (String)listadoEmpresas.SelectedRows[0].Cells["direccion"].Value;
                empresa.codigo_postal = (String)listadoEmpresas.SelectedRows[0].Cells["codigo_postal"].Value;
                empresa.localidad = (String)listadoEmpresas.SelectedRows[0].Cells["localidad"].Value;

                empresa.nombreContacto = (String)listadoEmpresas.SelectedRows[0].Cells["nombreContacto"].Value;
                empresa.razon_social = (String)listadoEmpresas.SelectedRows[0].Cells["razon_social"].Value;
                empresa.cuit = (Int64)listadoEmpresas.SelectedRows[0].Cells["cuit"].Value;
                empresa.fecha_creacion = (DateTime)listadoEmpresas.SelectedRows[0].Cells["fecha_creacion"].Value;

                Empresas.actualizarEmpresa(empresa);
                listadoEmpresas.DataSource = Empresas.buscar(razon_social_search.Text, cuit_search.Text, contacto_search.Text);
                MessageBox.Show("Modificaste la empresa con exito", "Exito");
            }
            else
            {
                MessageBox.Show("Debes elegir una fila de empresa para modificarla..", "Error");
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
