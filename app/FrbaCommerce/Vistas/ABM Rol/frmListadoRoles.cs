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

namespace FrbaCommerce.ABM_Rol
{
    public partial class frmListadoRoles : Form
    {
        public frmListadoRoles()
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

            DataGridViewButtonColumn colSeleccionar = new DataGridViewButtonColumn();
            colSeleccionar.Name = "Seleccionar";
            colSeleccionar.HeaderText = "Seleccionar";
            colSeleccionar.Text = "Seleccionar";
            colSeleccionar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;

            gridRoles.Columns.Add(colNombre);
            gridRoles.Columns.Add(colHabilitado);
            gridRoles.Columns.Add(colSeleccionar);
            gridRoles.Columns.Add(colEliminar);            

            gridRoles.DataSource = listaRoles;            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Rol> listaRoles = Roles.Buscar(txtNombre.Text);
            gridRoles.DataSource = listaRoles;
        }

        private void gridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridRoles.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Seleccionar");
            }
            if (e.ColumnIndex == gridRoles.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Eliminar");
            }
        }

    }
}
