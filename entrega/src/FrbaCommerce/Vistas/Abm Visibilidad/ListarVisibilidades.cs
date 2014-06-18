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

namespace FrbaCommerce.Vistas.Abm_Visibilidad
{
    public partial class ListarVisibilidades : Form
    {
        public ListarVisibilidades()
        {
            InitializeComponent();
            listadoVisibilidades.DataSource = Visibilidades.listar();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Visibilidad visibilidad = (Visibilidad)listadoVisibilidades.CurrentRow.DataBoundItem;
            ModificarAgregarVisibilidad form = new ModificarAgregarVisibilidad(visibilidad);
            form.Show();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas borrar la visibilidad?", "¿Estás seguro que deseas borrar la visibilidad?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Visibilidad visibilidad = (Visibilidad)listadoVisibilidades.CurrentRow.DataBoundItem;
                Visibilidades.borrar(visibilidad.id);
                listadoVisibilidades.DataSource = Visibilidades.listar();
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            ModificarAgregarVisibilidad form = new ModificarAgregarVisibilidad(null);
            form.Show();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            listadoVisibilidades.DataSource = Visibilidades.listar();
        }
    }
}
