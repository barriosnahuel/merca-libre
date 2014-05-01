using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Servicios;

namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataSet ds = Roles.ObtenerRoles();

            gridRoles.AutoGenerateColumns = true;
            gridRoles.DataSource = ds.Tables[0];

        }
    }
}
