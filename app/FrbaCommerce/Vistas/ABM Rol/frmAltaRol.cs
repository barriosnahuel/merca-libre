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

namespace FrbaCommerce.ABM_Rol
{
    public partial class frmAltaRol : Form
    {
        private static BindingList<Funcion> funcionesAgregadas = new BindingList<Funcion>();
        private static BindingList<Funcion> funcionesNoAgregadas = new BindingList<Funcion>();

        public frmAltaRol(Rol unRol)
        {
            InitializeComponent();

            //Si el rol que viene tiene id = -1 Entonces es una alta, sino es modificacion
            if (unRol.id != -1)
            {
                txtNombre.Text = unRol.nombre;
                chkHabilitado.Checked = unRol.habilitado;
            }

            List<Funcion> fadd = Funciones.ObtenerPorRol(unRol.id);
            foreach (var item in fadd)
            {
                funcionesAgregadas.Add(item);	 
            }
            lstFuncionesAgregadas.DataSource = funcionesAgregadas;
            lstFuncionesAgregadas.DisplayMember = "nombre";

            List<Funcion> fNotadd = Funciones.ObtenerNotRol(unRol.id);
            foreach (var item in fNotadd)
            {
                funcionesNoAgregadas.Add(item);
            }                
            lstFuncionesNoAgregadas.DataSource = funcionesNoAgregadas;
            lstFuncionesNoAgregadas.DisplayMember = "nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Funcion selectedItem = (Funcion)lstFuncionesNoAgregadas.Items[lstFuncionesNoAgregadas.SelectedIndex];

            funcionesAgregadas.Add(selectedItem);
            funcionesNoAgregadas.Remove(selectedItem);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Funcion selectedItem = (Funcion)lstFuncionesAgregadas.Items[lstFuncionesAgregadas.SelectedIndex];

            funcionesNoAgregadas.Add(selectedItem);
            funcionesAgregadas.Remove(selectedItem);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            chkHabilitado.Checked = true;
            List<Funcion> auxList = funcionesAgregadas.ToList();
            funcionesAgregadas.Clear();
            foreach (var item in auxList)
            {
                funcionesNoAgregadas.Add(item);
            }                
        }

    }
}
