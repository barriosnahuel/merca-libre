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


namespace FrbaCommerce.Vistas.ABM_Rol
{
    public partial class frmAltaRol : Form
    {
        public frmAltaRol()
        {
            InitializeComponent();
        }

        private Rol rol;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rol = new Rol();
            rol.nombre = txtNombre.Text;
            rol.habilitado = chkHabilitado.Checked;
            Roles.crearRol(rol);

            this.Close();
        }
    }
}
