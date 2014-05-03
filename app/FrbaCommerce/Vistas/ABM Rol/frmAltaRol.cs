using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.ABM_Rol
{
    public partial class frmAltaRol : Form
    {
        public frmAltaRol(Rol unRol)
        {
            InitializeComponent();

            //Si el rol que viene tiene id = -1 Entonces es una alta, sino es modificacion

        }

    }
}
