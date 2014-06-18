using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Vistas.Comprar_Ofertar
{
    public partial class VerDetalleVendedor : Form
    {

        public VerDetalleVendedor(Usuario usuario)
        {
            InitializeComponent();
            username.Text = usuario.username;
            mail.Text = usuario.mail;
            telefono.Text = usuario.telefono;
            direccion.Text = usuario.direccion;
            localidad.Text = usuario.localidad;
        }
    }
}
