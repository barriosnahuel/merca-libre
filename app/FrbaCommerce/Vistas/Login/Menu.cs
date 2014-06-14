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
using FrbaCommerce.Vistas.ABM_Rol;
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.Vistas.Abm_Cliente;
using FrbaCommerce.Vistas.Generar_Publicacion;
using FrbaCommerce.Vistas.Ver_publicaciones;
using FrbaCommerce.Vistas.Comprar_Ofertar;
using FrbaCommerce.Vistas.Historial_Cliente;
using FrbaCommerce.Vistas.Gestion_de_Preguntas;
using FrbaCommerce.Vistas.Calificar_Vendedor;
using FrbaCommerce.Vistas.Abm_Visibilidad;
using FrbaCommerce.Vistas.Facturar_Publicaciones;

namespace FrbaCommerce.Vistas.Login
{
    public partial class Menu : Form
    {
        frmLogin formLogin;
        public Menu(frmLogin frmLogin)
        {
            InitializeComponent();
            this.FormClosing += Menu_FormClosing;
            formLogin = frmLogin;
            List<Funcion> funcionalidades = Funciones.ObtenerPorRol(Session.usuario.rol.id);
            var i = 0;
            foreach (Funcion _funcionalidad in funcionalidades)
            {
                listadoFuncionalidades.Items.Insert(i, _funcionalidad.nombre);

                i = i + 1;
            }
            listadoFuncionalidades.SelectedIndex = 0;
        }

        private void ir_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidadElegida = (Funcionalidad)Enum.Parse(typeof(Funcionalidad), listadoFuncionalidades.Text);
            switch(funcionalidadElegida){
                case Funcionalidad.ABM_CLIENTE:
                    ListadoBusquedaClientes listadoBusquedaClientesform = new ListadoBusquedaClientes();
                    listadoBusquedaClientesform.Show();
                    break;
                case Funcionalidad.ABM_EMPRESA:
                    ListadoBusquedaEmpresas listadoBusquedaEmpresasform = new ListadoBusquedaEmpresas();
                    listadoBusquedaEmpresasform.Show();
                    break;
                case Funcionalidad.ABM_ROL:
                    ABMRol abmRolform = new ABMRol();
                    abmRolform.Show();
                    break;
                case Funcionalidad.ABM_VISIBILIDAD:
                    ListarVisibilidades ListarVisibilidadesForm = new ListarVisibilidades();
                    ListarVisibilidadesForm.Show();
                    break;
                case Funcionalidad.COMPRAR_OFERTAR:
                    VerPublicacionesActivas verPublicacionesActivasForm = new VerPublicacionesActivas();
                    verPublicacionesActivasForm.Show();
                    break;
                case Funcionalidad.GENERAR_PUBLICACION:
                    frmGenerarPublicacion frmGenerarPublicacionForm = new frmGenerarPublicacion();
                    frmGenerarPublicacionForm.Show();
                    break;
                case Funcionalidad.HISTORIAL:
                    frmHistorial frmHistorialForm = new frmHistorial();
                    frmHistorialForm.Show();
                    break;
                case Funcionalidad.MIS_PUBLICACIONES:
                    ListadoDePublicaciones listadoDePublicacionesForm = new ListadoDePublicaciones();
                    listadoDePublicacionesForm.Show();
                    break;
                case Funcionalidad.PREGUNTAS_REALIZADAS:
                    PreguntasRealizadas preguntasRealizadas = new PreguntasRealizadas();
                    break;
                case Funcionalidad.CALIFICAR:
                    frmListadoCalificacionesPendientes frmListadoCalificacionesPendientesForm = new frmListadoCalificacionesPendientes();
                    frmListadoCalificacionesPendientesForm.Show();
                    break;
                case Funcionalidad.FACTURAR_PUBLICACIONES:
                    frmPublicacionesAFacturar frmPublicacionesAFacturarForm = new frmPublicacionesAFacturar();
                    frmPublicacionesAFacturarForm.Show();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Close();
        }

        private void Menu_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formLogin.Show();
        }

    }
}
