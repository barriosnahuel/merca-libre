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

namespace FrbaCommerce.ABM_Rol
{
    public partial class frmABMRoles : Form
    {
        public frmABMRoles()
        {
            InitializeComponent();

            List<Rol> listaRoles = Roles.ObtenerTodos();

            gridRoles.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "nombre";
            colNombre.HeaderText = "Nombre";

            DataGridViewCheckBoxColumn colHabilitado = new DataGridViewCheckBoxColumn();
            colHabilitado.DataPropertyName = "habilitado";
            colHabilitado.HeaderText = "Habilitado";

            gridRoles.Columns.Add(colNombre);
            gridRoles.Columns.Add(colHabilitado);            

            gridRoles.DataSource = listaRoles;            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Rol> listaRoles = Roles.Buscar(txtNombre.Text);
            gridRoles.DataSource = listaRoles;
        }

    }
}
