using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;
using FrbaCommerce.Servicios;

namespace FrbaCommerce.Vistas.Calificar_Vendedor
{
    public partial class frmCalificar : Form
    {
        private CompraSinCalificar compraCalificada;

        public frmCalificar(CompraSinCalificar unaCompra)
        {
            InitializeComponent();

            compraCalificada = unaCompra;

            lblDescripcion.Text = unaCompra.descripcion;
            lblFecha.Text = unaCompra.fecha.ToShortTimeString();
            lblNroCompra.Text = unaCompra.id.ToString();
            lblVendedor.Text = unaCompra.username;
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (cmbCalificar.Text == "")
            {
                MessageBox.Show("Debe seleccionar la cantidad de estrellas.");
            }else {
                String comentario = "";
                if (txtComentario.Visible)
                {
                    comentario = txtComentario.Text;
                }
                else
                {
                    comentario = cmbComentarioFijo.Text;
                }
                Calificaciones.GuardarCalificacion(Session.usuario.id, compraCalificada.id, (int)(double.Parse(cmbCalificar.Text) * 2), comentario);
                MessageBox.Show("Calificaste con éxito.");
                this.Close();
            }            
        }

        private void cmbComentarioFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbComentarioFijo.Text == "Otro")
            {
                txtComentario.Visible = true;
            }
            else
            {
                txtComentario.Visible = false;
            }
        }
    }
}
