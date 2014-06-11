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
using FrbaCommerce.Util;

namespace FrbaCommerce.Vistas.Abm_Visibilidad
{
    public partial class ModificarAgregarVisibilidad : Form
    {

        public ModificarAgregarVisibilidad(Visibilidad visibilidad)
        {
            InitializeComponent();
            if (visibilidad != null)
            {
                descripcion.Text = visibilidad.descripcion;
                precio.Text = Convert.ToString(visibilidad.precio);
                porcentaje.Text = Convert.ToString(visibilidad.porcentaje * 100);
                codigo.Text = Convert.ToString(visibilidad.id);
                accion.Text = "Editar";
            }
        }

        private void accion_Click(object sender, EventArgs e)
        {
            Visibilidad visibilidad = new Visibilidad();
            if (FormValidate.StringIsNullOrEmpty(codigo.Text, "Codigo"))
            {
                visibilidad.id = Convert.ToInt64(codigo.Text);
            }
            if (FormValidate.StringIsNullOrEmpty(descripcion.Text, "Descripcion"))
            {
                visibilidad.descripcion = descripcion.Text;
            }
            if (FormValidate.StringIsNullOrEmpty(precio.Text, "Precio"))
            {
                visibilidad.precio = Convert.ToDouble(precio.Text);
            }
            if (FormValidate.StringIsNullOrEmpty(porcentaje.Text, "Porcentaje"))
            {
                visibilidad.porcentaje = Convert.ToDouble(porcentaje.Text) / 100;
            }
            
            Visibilidades.crearOModificar(visibilidad);
            MessageBox.Show("Acción realizada con éxito.");
            this.Show();
        }
    }
}
