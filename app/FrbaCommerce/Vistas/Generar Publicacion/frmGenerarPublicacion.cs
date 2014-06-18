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
        Publicacion publicacion;

        public frmGenerarPublicacion()
        {
            InitializeComponent();

            publicacion = new Publicacion();

            inicializarFormulario();
        }

        public frmGenerarPublicacion(Int64 idPublicacion)
        {
            InitializeComponent();
            publicacion = Publicaciones.buscar(idPublicacion);
            inicializarFormulario();
            cargarDatosPublicacion();
            restringirFuncionalidad(publicacion);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            publicacion = generarPublicacion();
            Publicaciones.guardar(publicacion);

            MessageBox.Show("Se guardo la publicacion exitosamente", "Publicacion");
            this.Close();

        }


        private Publicacion generarPublicacion()
        {            
            publicacion.descripcion = descripcion.Text;
            publicacion.admitePregunta = admitePreguntas.Checked;

            publicacion.unidades = Int32.Parse(stock.Value.ToString());

            publicacion.desde = Convert.ToDateTime(fechaDesde.Text);
            publicacion.hasta = Convert.ToDateTime(fechaHasta.Text);

            publicacion.precio = Double.Parse(precio.Text);
            publicacion.tipo = tiposPublicacion.Find(x => x.descripcion == tipoPublicacion.Text);
            publicacion.visibilidad = visibilidades.Find(x => x.descripcion.Equals(visibilidad.Text));
            publicacion.estado = estados.Find(x => x.descripcion.Equals(cb_estados.Text));


            publicacion.rubros.Clear();
            foreach (String _nombreRubro in rubros.CheckedItems)
            {
                publicacion.rubros.Add(listaRubros.Find(x => x.descripcion.Equals(_nombreRubro)));
            }

            publicacion.usuario = Session.usuario;

            return publicacion;
        }

        // carga los datos de la publicacion en el formulario
        private void cargarDatosPublicacion()
        {
            descripcion.Text = publicacion.descripcion;
            precio.Text = publicacion.precio.ToString();
            fechaDesde.Value = publicacion.desde;
            fechaHasta.Value = publicacion.hasta;
            stock.Value = publicacion.unidades;
            admitePreguntas.Checked = publicacion.admitePregunta;
            



            tipoPublicacion.SelectedIndex = tipoPublicacion.FindString(publicacion.tipo.descripcion);
            visibilidad.SelectedIndex = visibilidad.FindString(publicacion.visibilidad.descripcion);
            cb_estados.SelectedIndex = cb_estados.FindString(publicacion.estado.descripcion);


            rubros.Items.Clear();

            foreach (Rubro _rubro in listaRubros)
            {
                rubros.Items.Add(_rubro.descripcion, publicacionTieneRubro(_rubro));
            }
        }

        private bool publicacionTieneRubro(Rubro _rubro)
        {
            return publicacion.rubros.Exists(unRubro => unRubro.descripcion.Equals(_rubro.descripcion));
        }


        private void inicializarFormulario()
        {
            tiposPublicacion = TipoPublicaciones.listar();
            estados = EstadosPublicacion.estadosValidosPublicacion(publicacion);
            visibilidades = Visibilidades.listar();
            listaRubros = Rubros.listar();

            fechaDesde.Format = DateTimePickerFormat.Custom;
            fechaDesde.CustomFormat = "dd/MM/yyyy hh:mm";

            fechaHasta.Format = DateTimePickerFormat.Custom;
            fechaHasta.CustomFormat = "dd/MM/yyyy hh:mm";
            tipoPublicacion.Items.Clear();


            int i = 0;
            foreach (TipoPublicacion tipo in tiposPublicacion)
            {
                tipoPublicacion.Items.Insert(i, tipo.descripcion);

                i = i + 1;
            }
            tipoPublicacion.SelectedIndex = 0;

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


            i = 0;
            foreach (EstadoPublicacion _estado in estados)
            {
                cb_estados.Items.Insert(i, _estado.descripcion);

                i = i + 1;
            }
            cb_estados.SelectedIndex = 0;


        }


        private void restringirFuncionalidad(Publicacion publicacion)
        {
            if (!publicacion.estado.descripcion.Equals("Borrador"))
            {
                visibilidad.Enabled = false;
                tipoPublicacion.Enabled = false;
                fechaDesde.Enabled = false;
                fechaHasta.Enabled = false;
                rubros.Enabled = false;
                precio.Enabled = false;
                descripcion.Enabled = false;
                admitePreguntas.Enabled = false;

            }
         
            if (publicacion.estado.descripcion.Equals("Pausada") || publicacion.estado.descripcion.Equals("Finalizada"))
            {
                stock.Enabled = false;
            }
            
            if (publicacion.tipo.descripcion.Equals("Subasta"))
            {
               stock.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }


}
