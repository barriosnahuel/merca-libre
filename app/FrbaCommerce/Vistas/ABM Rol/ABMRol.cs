using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ABM_Rol;

namespace FrbaCommerce.Vistas.ABM_Rol
{
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaRol altaRol = new frmAltaRol();
            altaRol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListadoRoles abmRoles = new frmListadoRoles(true);
            abmRoles.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListadoRoles listadoRoles = new frmListadoRoles(false);
            listadoRoles.Show();
        }
    }
}
