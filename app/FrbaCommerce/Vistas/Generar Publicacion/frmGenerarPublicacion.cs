using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FrbaCommerce.Vistas.Generar_Publicacion
{
    public partial class frmGenerarPublicacion : Form
    {
        public frmGenerarPublicacion()
        {
            InitializeComponent();


            fechaDesde.Format = DateTimePickerFormat.Custom;
            fechaDesde.CustomFormat  =  "hh:mm:ss MMMM dd, yyyy";

            fechaHasta.Format = DateTimePickerFormat.Custom;
            fechaHasta.CustomFormat = "hh:mm:ss MMMM dd, yyyy";


        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {          

            if (char.IsNumber(e.KeyChar) || e.KeyChar==',')
             {
              //if (Regex.IsMatch(precio.Text,"^[0-9]+(\\d{2})?$"))
                  e.Handled = true;
             }
             //else e.Handled = e.KeyChar!=(char)Keys.Back;
        }
    }
}
