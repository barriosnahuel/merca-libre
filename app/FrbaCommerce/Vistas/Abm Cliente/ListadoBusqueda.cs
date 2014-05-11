using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ListadoBusqueda : Form
    {
        public ListadoBusqueda()
        {
            InitializeComponent();
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            mail.Text = "";
            tipoDoc.Text = "";
            documento.Text = "";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //TODO invocar servicio de busqueda
        }

    }
}
