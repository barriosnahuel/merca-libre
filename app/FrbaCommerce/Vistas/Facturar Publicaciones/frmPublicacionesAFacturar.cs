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

            buscarPublicaciones();
        }

        private void buscarPublicaciones()
        {
            List<Publicacion> listaPublicaciones = Publicaciones.buscarSinFacturar(Session.usuario.id);

            dgvPublicaciones.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colNro = new DataGridViewTextBoxColumn();
            colNro.DataPropertyName = "id";
            colNro.HeaderText = "Nro publicacion";

            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.HeaderText = "Descripcion";

            DataGridViewTextBoxColumn colUnidades = new DataGridViewTextBoxColumn();
            colUnidades.DataPropertyName = "unidades";
            colUnidades.HeaderText = "Unidades";

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "precio";
            colPrecio.HeaderText = "Precio unidad";

            DataGridViewTextBoxColumn colDesde = new DataGridViewTextBoxColumn();
            colDesde.DataPropertyName = "desde";
            colDesde.HeaderText = "Desde";

            DataGridViewTextBoxColumn colHasta = new DataGridViewTextBoxColumn();
            colHasta.DataPropertyName = "hasta";
            colHasta.HeaderText = "Hasta";

            dgvPublicaciones.Columns.Add(colNro);
            dgvPublicaciones.Columns.Add(colDescripcion);
            dgvPublicaciones.Columns.Add(colUnidades);
            dgvPublicaciones.Columns.Add(colPrecio);
            dgvPublicaciones.Columns.Add(colDesde);
            dgvPublicaciones.Columns.Add(colHasta);

            dgvPublicaciones.DataSource = listaPublicaciones; 
        }
    }
}
