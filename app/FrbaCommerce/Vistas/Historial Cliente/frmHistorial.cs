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

namespace FrbaCommerce.Vistas.Historial_Cliente
{
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();

            buscarCompras();
            buscarOfertas();

        }

        private void buscarCompras()
        {
            List<CompraHistorial> listaCompras = ComprasHistorial.BuscarPorUsuario(Session.usuario.id);

            dgvCompras.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.HeaderText = "Descripcion";

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "precio";
            colPrecio.HeaderText = "Precio unidad";

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.DataPropertyName = "cantidad";
            colCantidad.HeaderText = "Cantidad";

            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
            colTotal.DataPropertyName = "total";
            colTotal.HeaderText = "Total";

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fecha";
            colFecha.HeaderText = "Fecha de compra";

            dgvCompras.Columns.Add(colDescripcion);
            dgvCompras.Columns.Add(colPrecio);
            dgvCompras.Columns.Add(colCantidad);
            dgvCompras.Columns.Add(colTotal);
            dgvCompras.Columns.Add(colFecha);

            dgvCompras.DataSource = listaCompras; 
        }

        private void buscarOfertas()
        {
            List<OfertaHistorial> listaOfertas = OfertasHistorial.BuscarPorUsuario(Session.usuario.id);

            dgvOfertas.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.HeaderText = "Descripcion";

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.DataPropertyName = "monto";
            colMonto.HeaderText = "Monto";

            DataGridViewTextBoxColumn colGano = new DataGridViewTextBoxColumn();
            colGano.DataPropertyName = "gano";
            colGano.HeaderText = "Oferta ganadora";

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fecha";
            colFecha.HeaderText = "Fecha de oferta";

            dgvOfertas.Columns.Add(colDescripcion);
            dgvOfertas.Columns.Add(colMonto);
            dgvOfertas.Columns.Add(colGano);
            dgvOfertas.Columns.Add(colFecha);

            dgvOfertas.DataSource = listaOfertas; 
        }

    }
}
