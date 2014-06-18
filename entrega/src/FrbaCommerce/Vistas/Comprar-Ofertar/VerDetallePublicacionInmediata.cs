using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;
using FrbaCommerce.Util;
using FrbaCommerce.Servicios;

namespace FrbaCommerce.Vistas.Comprar_Ofertar
{
    public partial class VerDetallePublicacionInmediata : Form
    {
        private Publicacion publicacion;

        public VerDetallePublicacionInmediata(Publicacion p)
        {
            InitializeComponent();
            publicacion = p;
            descripcion.Text = p.descripcion;
            unidades.Text = Convert.ToString(p.unidades);
            precio.Text = Convert.ToString(p.precio);
            tipo.Text = p.tipoDescripcion;
        }

        private void comprar_Click(object sender, EventArgs e)
        {
            if (!FormValidate.isUserLoggedIn())
            {
                return;
            }
            if (!ClienteValidaciones.tieneCalificacionesAlDia(Session.usuario.id))
            {
                MessageBox.Show("Tenes mas de 5 compras sin calificar y no podes realizar mas compras/ofertas hasta que califiques las mismas.");
                return;
            }
            if (publicacion.usuario.id != Session.usuario.id)
            {
                Int32 cantidadAComprar = Convert.ToInt32(cantidad.Text);
                if (publicacion.unidades < cantidadAComprar)
                {
                    MessageBox.Show("No podes comprar mas de las unidades que hay disponibles.");
                    return;
                }
                Publicaciones.comprar(publicacion.id, cantidadAComprar, publicacion.precio);
                Usuario usuario = Usuarios.buscarUsuarioPorID(publicacion.usuario.id);
                VerDetalleVendedor verDetalleVendedor = new VerDetalleVendedor(usuario);
                verDetalleVendedor.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No podes comprar tus publicaciones");
            }    
            
        }

    }
}
