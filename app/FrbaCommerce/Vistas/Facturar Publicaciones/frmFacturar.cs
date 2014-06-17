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

namespace FrbaCommerce.Vistas.Facturar_Publicaciones
{
    public partial class frmFacturar : Form
    {
        public frmFacturar(List<long> listaPublicaciones)
        {
            InitializeComponent();
            obtenerDetalle(listaPublicaciones);
            obtenerFormasPago();
        }

        private void obtenerFormasPago() {
            cmbFormaPago.DisplayMember = "descripcion";
            cmbFormaPago.DataSource = FormasPago.ObtenerTodas();            
        }

        private void obtenerDetalle(List<long> listaPublicaciones)
        {
            List<ItemFactura> listaItems = new List<ItemFactura>();
            foreach (long idPublicacion in listaPublicaciones)
            {
                listaItems.AddRange(ItemsFactura.GenerarPorPublicacion(idPublicacion));
            }

            dgvDetalle.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.HeaderText = "Publicacion";

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.DataPropertyName = "monto";
            colMonto.HeaderText = "Monto";

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.DataPropertyName = "cantidad";
            colCantidad.HeaderText = "Cantidad";

            DataGridViewTextBoxColumn colDetalle = new DataGridViewTextBoxColumn();
            colDetalle.DataPropertyName = "detalle";
            colDetalle.HeaderText = "Detalle";

            dgvDetalle.Columns.Add(colDescripcion);
            dgvDetalle.Columns.Add(colDetalle);
            dgvDetalle.Columns.Add(colCantidad);
            dgvDetalle.Columns.Add(colMonto);

            dgvDetalle.DataSource = listaItems;
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaPago fp = (FormaPago)cmbFormaPago.Items[cmbFormaPago.SelectedIndex];
            if (fp.id == 1) // 1 es el id de tarjeta de credito
            {
                txtCodigo.Visible = true;
                txtNroTarjeta.Visible = true;
                txtTitular.Visible = true;
                lblCod.Visible = true;
                lblNroTarjeta.Visible = true;
                lblTitular.Visible = true;
            }
            else
            {
                txtCodigo.Visible = false;
                txtNroTarjeta.Visible = false;
                txtTitular.Visible = false;
                lblCod.Visible = false;
                lblNroTarjeta.Visible = false;
                lblTitular.Visible = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

    }
}
