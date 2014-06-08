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
using FrbaCommerce.Vistas.Gestion_de_Preguntas;
using FrbaCommerce.Util;

namespace FrbaCommerce.Vistas.Comprar_Ofertar
{
    public partial class VerPublicacionesActivas : Form
    {
        List<Rubro> listaRubros = new List<Rubro>();
        List<Rubro> rubrosSeleccionados = new List<Rubro>();

        public VerPublicacionesActivas()
        {
            InitializeComponent();
            initRubros();
            buscarPublicaciones(getDescripcion(), getNumeroPaginaActual(), getRubros());
        }

        private void anteriorPagina_button_Click(object sender, EventArgs e)
        {
            int pagina = cambiarPagina(-1);
            buscarPublicaciones(getDescripcion(), pagina, getRubros());
        }

        private void siguientePagina_button_Click(object sender, EventArgs e)
        {
            int pagina = cambiarPagina(1);
            buscarPublicaciones(getDescripcion(), pagina, getRubros());
        }

        private void buscarPublicaciones(string descripcion, int numeroPagina, List<Rubro> rubros) 
        {
            listadoPublicaciones.DataSource = Publicaciones.buscarActivas("Activa", descripcion, numeroPagina, rubros);
        }

        private int getNumeroPaginaActual()
        {
            return Convert.ToInt16(numeroPagina.Text);
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            buscarPublicaciones(getDescripcion(), getNumeroPaginaActual(), getRubros());
        }

        private int cambiarPagina(int cambioPagina)
        {
            int pagina = getNumeroPaginaActual();
            pagina = pagina + cambioPagina;
            if (pagina == 0) pagina = 1;
            numeroPagina.Text = Convert.ToString(pagina);
            return pagina;
        }

        private string getDescripcion()
        {
            if (descripcion.Text == "")
            {
                return null;
            }
            else
            {
                return descripcion.Text;
            }
        }

        private List<Rubro> getRubros()
        {
            rubrosSeleccionados.Clear();
            foreach (String _nombreRubro in rubros.CheckedItems)
            {
                rubrosSeleccionados.Add(listaRubros.Find(x => x.descripcion.Equals(_nombreRubro)));
            }
            if (rubrosSeleccionados.Count == 0) return null;
            return rubrosSeleccionados;
        }

        private void initRubros()
        {
            int i = 0;
            listaRubros = Rubros.listar();
            foreach (Rubro _rubro in listaRubros)
            {
                rubros.Items.Insert(i, _rubro.descripcion);

                i = i + 1;
            }
        }

        private void preguntar_button_Click(object sender, EventArgs e)
        {
            if (FormValidate.isUserLoggedIn())
            {
                Publicacion publicacion = (Publicacion)listadoPublicaciones.CurrentRow.DataBoundItem;
                if (Session.usuario.id != publicacion.usuario.id)
                {
                    CuadroPreguntar cuadroPreguntar = new CuadroPreguntar(publicacion.id);
                }
                else
                {
                    MessageBox.Show("No se pueden hacer preguntas a tus propias publicaciones.");
                }
            }
        }
    }
}
