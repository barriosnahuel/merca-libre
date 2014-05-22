using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FrbaCommerce.Servicios;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Vistas.Generar_Publicacion
{
    public partial class frmGenerarPublicacion : Form
    {
        List<TipoPublicacion> tiposPublicacion;
        List<EstadoPublicacion> estados;

        public frmGenerarPublicacion()
        {
            tiposPublicacion = TipoPublicaciones.listar();
            estados = EstadosPublicacion.listar();
            InitializeComponent();


            fechaDesde.Format = DateTimePickerFormat.Custom;
            fechaDesde.CustomFormat = "dd/MM/yyyy hh:mm";

            fechaHasta.Format = DateTimePickerFormat.Custom;
            fechaHasta.CustomFormat = "dd/MM/yyyy hh:mm";
            tipoPublicacion.Items.Clear();
            

            int i = 0;
            foreach (TipoPublicacion tipo in tiposPublicacion)
            {
                tipoPublicacion.Items.Insert(i,tipo.descripcion);

                i = i + 1;
            }
            tipoPublicacion.SelectedIndex = 0;

            i = 0;

            foreach (EstadoPublicacion _estado in estados)
            {
                estado.Items.Insert(i, _estado.descripcion);

                i = i + 1;
            }
            estado.SelectedIndex = 0;

            



        }

    }
}
