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

namespace FrbaCommerce.Vistas.Calificar_Vendedor
{
    public partial class frmListadoCalificacionesPendientes : Form
    {
        public frmListadoCalificacionesPendientes()
        {
            InitializeComponent();

            List<CompraSinCalificar> listaCompras = ComprasSinCalificar.BuscarPorUsuario(Session.usuario.id);

            dgvCalificacionesPendientes.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.HeaderText = "Descripcion";

            DataGridViewTextBoxColumn colUsername = new DataGridViewTextBoxColumn();
            colUsername.DataPropertyName = "username";
            colUsername.HeaderText = "Vendedor";

            DataGridViewTextBoxColumn colNroCompra = new DataGridViewTextBoxColumn();
            colNroCompra.HeaderText = "Nro Compra";
            colNroCompra.DataPropertyName = "id";

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fecha";
            colFecha.HeaderText = "Fecha de compra";

            DataGridViewButtonColumn colCalificar = new DataGridViewButtonColumn();
            colCalificar.Name = "Calificar";
            colCalificar.HeaderText = "";
            colCalificar.Text = "Calificar";
            colCalificar.UseColumnTextForButtonValue = true;

            dgvCalificacionesPendientes.Columns.Add(colNroCompra);
            dgvCalificacionesPendientes.Columns.Add(colDescripcion);
            dgvCalificacionesPendientes.Columns.Add(colUsername);
            dgvCalificacionesPendientes.Columns.Add(colFecha);
            dgvCalificacionesPendientes.Columns.Add(colCalificar);            

            dgvCalificacionesPendientes.DataSource = listaCompras; 
        }

        private void dgvCalificacionesPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCalificacionesPendientes.Columns.Contains("Calificar") && e.ColumnIndex == dgvCalificacionesPendientes.Columns["Calificar"].Index)
                {
                    CompraSinCalificar compraSeleccionada = (CompraSinCalificar)dgvCalificacionesPendientes.CurrentRow.DataBoundItem;
                    frmCalificar calificarCompraForm = new frmCalificar(compraSeleccionada);
                    this.Hide();
                    calificarCompraForm.Show();
                }
            }
        }
    }
}
