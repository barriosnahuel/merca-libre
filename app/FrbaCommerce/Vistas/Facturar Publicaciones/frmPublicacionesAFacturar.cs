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
    public partial class frmPublicacionesAFacturar : Form
    {
        public frmPublicacionesAFacturar()
        {
            InitializeComponent();

            buscarComprasVisibilidad();
            obtenerFormasPago();
        }

        private void obtenerFormasPago()
        {
            cmbFormaPago.DisplayMember = "descripcion";
            cmbFormaPago.DataSource = FormasPago.ObtenerTodas();
        }

        private void buscarComprasVisibilidad()
        {
            List<ItemFactura> listaItems = ItemsFactura.ObtenerItemsSinFacturar(Session.usuario.id);

            if (listaItems.Count > 0)
            {
                dgvPublicaciones.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
                colFecha.DataPropertyName = "fecha";
                colFecha.HeaderText = "Fecha";

                DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
                colCantidad.DataPropertyName = "cantidad";
                colCantidad.HeaderText = "Cantidad";

                DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
                colMonto.DataPropertyName = "monto";
                colMonto.HeaderText = "Monto";

                DataGridViewTextBoxColumn colDetalle = new DataGridViewTextBoxColumn();
                colDetalle.DataPropertyName = "detalle";
                colDetalle.HeaderText = "Detalle";

                dgvPublicaciones.Columns.Add(colFecha);
                dgvPublicaciones.Columns.Add(colDetalle);
                dgvPublicaciones.Columns.Add(colCantidad);
                dgvPublicaciones.Columns.Add(colMonto);

                dgvPublicaciones.DataSource = listaItems;

                for (int i = 0; i < listaItems.Count; i++)
                {
                    cmbCantPub.Items.Insert(i, i + 1);
                }
                cmbCantPub.SelectedIndex = 0;
            }
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaPago fp = (FormaPago)cmbFormaPago.Items[cmbFormaPago.SelectedIndex];
            if (fp.id == 2) // 2 es el id de tarjeta de credito
            {
                groupFormaPago.Visible = true;
            }
            else
            {
                groupFormaPago.Visible = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (formularioValido()) {
                FormaPago fp = (FormaPago)cmbFormaPago.Items[cmbFormaPago.SelectedIndex];
                long idFactura = Facturas.guardar(Session.usuario.id, Session.fechaAhora(), int.Parse(fp.id.ToString()));
                for (int i = 0; i < int.Parse(cmbCantPub.Text); i++)
                {
                    ItemFactura unItem = (ItemFactura)dgvPublicaciones.Rows[i].DataBoundItem;
                    unItem.idFactura = idFactura;
                    ItemsFactura.Guardar(unItem);
                }
                if (fp.id == 2)
                {
                    Tarjetas.Guardar(idFactura, txtNroTarjeta.Text, txtTitular.Text, txtCodigo.Text);
                }
                MessageBox.Show("Items pagados!");
                this.Close();
            }
        }

        private bool formularioValido() {
            FormaPago fp = (FormaPago)cmbFormaPago.Items[cmbFormaPago.SelectedIndex];
            if (fp.id != 2) // 1 es el id de tarjeta de credito
            {
                return true;
            }
            else
            {
                String errores = "";
                if (txtTitular.Text == "")
                {
                    errores += "Complete el titular. ";
                }
                if (txtNroTarjeta.Text == "")
                {
                    errores += "Complete la tarjeta de credito. ";
                }
                if (txtCodigo.Text == "")
                {
                    errores += "Complete el codigo de seguridad. ";
                }

                if (errores != "")
                {
                    MessageBox.Show(errores);
                    return false;                   
                }
                else
                {
                    return true;
                }
            }
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
