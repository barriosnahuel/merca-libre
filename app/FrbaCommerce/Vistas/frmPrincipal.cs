using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ABM_Rol;
using FrbaCommerce.Modelos;

namespace FrbaCommerce
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoRoles abmRoles = new frmListadoRoles(true);
            abmRoles.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoRoles listadoRoles = new frmListadoRoles(false);
            listadoRoles.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol nuevoRol = new Rol();
            nuevoRol.id = -1;
            frmAltaRol altaRol = new frmAltaRol(nuevoRol);
            altaRol.Show();
        }

    }
}
