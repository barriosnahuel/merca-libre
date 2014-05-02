using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ABM_Rol;

namespace FrbaCommerce
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMRoles abmRoles = new frmABMRoles();
            abmRoles.Show();
        }
    }
}
