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
using FrbaCommerce.Registro_de_Usuario;
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.Vistas.ABM_Rol;
using FrbaCommerce.Vistas.Abm_Cliente;
using FrbaCommerce.Vistas.Login;
using FrbaCommerce.Vistas.Generar_Publicacion;
using FrbaCommerce.Vistas.Ver_publicaciones;
using FrbaCommerce.Vistas.Comprar_Ofertar;
using FrbaCommerce.Vistas.Historial_Cliente;
using FrbaCommerce.Vistas.Gestion_de_Preguntas;
namespace FrbaCommerce
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            if (Session.usuario != null)   label1.Text += " " + Session.usuario.username;

           
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
            frmAltaRol altaRol = new frmAltaRol();
            altaRol.Show();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPasoUno form = new RegistroPasoUno();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoBusquedaClientes form = new ListadoBusquedaClientes();
            form.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoBusquedaEmpresas form = new ListadoBusquedaEmpresas();
            form.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            
        }

        private void generarPublicacion_Click(object sender, EventArgs e)
        {
            frmGenerarPublicacion form = new frmGenerarPublicacion();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoDePublicaciones form = new ListadoDePublicaciones();
            form.Show();
        }

		private void comprar_Click(object sender, EventArgs e)
        {
            VerPublicacionesActivas form = new VerPublicacionesActivas();
            form.Show();
        }
	
		private void miHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial form = new frmHistorial();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGenerarPublicacion form = new frmGenerarPublicacion(12353);
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Session.usuario = new Usuario();
            Session.usuario.username = "lala";
            Session.usuario.id = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Session.usuario = new Usuario();
            Session.usuario.username = "lala2";
            Session.usuario.id = 1;
        }

        private void misPreguntas_Click(object sender, EventArgs e)
        {
            PreguntasRealizadas preguntasRealizadas = new PreguntasRealizadas();
        }

    }
}
