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
        List<Visibilidad> visibilidades;
        List<Rubro> listaRubros;

        public frmGenerarPublicacion()
        {
            tiposPublicacion = TipoPublicaciones.listar();
            estados = EstadosPublicacion.listar();
            visibilidades = Visibilidades.listar();
            listaRubros = Rubros.listar();

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

            //foreach (EstadoPublicacion _estado in estados)
            //{
            //    estado.Items.Insert(i, _estado.descripcion);

            //    i = i + 1;
            //}
            //estado.SelectedIndex = 0;

            i = 0;
            foreach (Visibilidad _visibilidad in visibilidades)
            {
                visibilidad.Items.Insert(i, _visibilidad.descripcion);

                i = i + 1;
            }
            visibilidad.SelectedIndex = 0;

            i = 0;
            foreach (Rubro _rubro in listaRubros)
            {
                rubros.Items.Insert(i, _rubro.descripcion);

                i = i + 1;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //publicar


            Publicacion publicacion = generarPublicacion();
            publicacion.estado = estados.Find(x => x.descripcion.Equals("Publicada"));

            Publicaciones.guardar(publicacion);

            MessageBox.Show("Se publico exitosamente", "Publicacion");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardar como borrador
            Publicacion publicacion = generarPublicacion();
            publicacion.estado = estados.Find(x => x.descripcion.Equals("Borrador"));

            Publicaciones.guardar(publicacion);

            MessageBox.Show("Se guardo publicacion como borrador exitosamente", "Publicacion");
            this.Close();

        }


        private Publicacion generarPublicacion()
        {
            Publicacion publicacion = new Publicacion();
            publicacion.descripcion = descripcion.Text;
            publicacion.admitePregunta = admitePreguntas.Checked;

            publicacion.stock = Int32.Parse(stock.Value.ToString());

            publicacion.desde = Convert.ToDateTime(fechaDesde.Text);
            publicacion.hasta = Convert.ToDateTime(fechaHasta.Text);

            publicacion.precio = Double.Parse(precio.Text);
            publicacion.tipo = tiposPublicacion.Find(x => x.descripcion == tipoPublicacion.Text);
            publicacion.visibilidad = visibilidades.Find(x => x.descripcion.Equals(visibilidad.Text));
            
            foreach (String _nombreRubro in rubros.CheckedItems) {
                publicacion.rubros.Add(listaRubros.Find(x => x.descripcion.Equals(_nombreRubro)));
            }

            publicacion.usuario = Session.usuario;

            return publicacion;
        }


    }
}
