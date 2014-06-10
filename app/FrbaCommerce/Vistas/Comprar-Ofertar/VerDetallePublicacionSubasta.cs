using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Util;
using FrbaCommerce.Servicios;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Vistas.Comprar_Ofertar
{
    public partial class VerDetallePublicacionSubasta : Form
    {
        private Publicacion publicacion;

        public VerDetallePublicacionSubasta(Publicacion p)
        {
            InitializeComponent();
            publicacion = p;
            descripcion.Text = p.descripcion;
            unidades.Text = Convert.ToString(p.unidades);
            precio.Text = Convert.ToString(p.precio);
            tipo.Text = p.tipoDescripcion;
        }

        private void ofertar_Click(object sender, EventArgs e)
        {
            if (FormValidate.isUserLoggedIn())
            {
                if (publicacion.usuario.id != Session.usuario.id)
                {
                    Int32 oferta = Convert.ToInt32(montoOferta.Text);
                    if (publicacion.precio > oferta)
                    {
                        MessageBox.Show("El monto de oferta debe ser superior al precio actual.");
                        return;
                    }
                    Publicaciones.ofertar(publicacion.id, oferta);
                    Usuario usuario = Usuarios.buscarUsuarioPorID(publicacion.usuario.id);
                    MessageBox.Show("Hiciste la oferta con exito de $ " + montoOferta.Text);
                    precio.Text = montoOferta.Text;
                    montoOferta.Text = "";
                }
                else
                {
                    MessageBox.Show("No podes comprar tus publicaciones");
                }
            }
        }

    }
}
