using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Vistas.Calificar_Vendedor
{
    public partial class frmCalificar : Form
    {
        public frmCalificar(CompraSinCalificar unaCompra)
        {
            InitializeComponent();

            lblDescripcion.Text = unaCompra.descripcion;
            lblFecha.Text = unaCompra.fecha.ToShortTimeString();
            lblNroCompra.Text = unaCompra.id.ToString();
            lblVendedor.Text = unaCompra.username;
        }
    }
}
