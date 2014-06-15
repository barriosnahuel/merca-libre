using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utiles;
using FrbaCommerce.Modelos;
using FrbaCommerce.Servicios;


namespace FrbaCommerce.Vistas.Listado_Estadistico
{
    public partial class FrmTop5 : Form
    {
        List<Visibilidad> visibilidades;

        public FrmTop5()
        {
            int i = 0;
            visibilidades = Visibilidades.listar();
            InitializeComponent();

            cboEstadistica.Items.Insert(0, "Usuarios sin calificar");
            cboEstadistica.Items.Insert(1, "Vendedores con mas facturación");
            cboEstadistica.Items.Insert(2, "Vendedores mejor calificación");
            cboEstadistica.Items.Insert(3, "Vendedores articulos sin vender");

            cboEstadistica.SelectedIndex = 0;

            comboBox2.Items.Add(1);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(4);
            comboBox2.SelectedIndex = 0;


            for (i = 2010; i <= Session.fechaAhora().Year; i++)
                comboBox1.Items.Add(i);

            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            
            i = 0;

            foreach (Visibilidad _visibilidad in visibilidades)
            {
                cboVisibilidades.Items.Insert(i, _visibilidad.descripcion);

                i = i + 1;
            }
            cboVisibilidades.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anio = int.Parse(comboBox1.Text);
            int mesDesde = comboBox2.SelectedIndex * 3 + 1;
            int mesHasta = mesDesde + 2;

            DateTime fechaDesde = new DateTime(anio, mesDesde, 1);
            DateTime fechaHasta = new DateTime(anio, mesHasta, 1);


            Visibilidad visibilidad;

            List<SqlParameter> parametros = new List<SqlParameter>();

            String estadisticaSeleccionada = "";
            switch (cboEstadistica.SelectedIndex)
	            {
                case 0:
                    estadisticaSeleccionada =  estadisticaSeleccionada = "GOODTIMES.Top5ClientesSinCalificar";
                    break;
                case 1:
                    estadisticaSeleccionada = estadisticaSeleccionada = "GOODTIMES.Top5Facturacion";
                    break;
                case 2:
                    estadisticaSeleccionada = estadisticaSeleccionada = "GOODTIMES.Top5VendedoresCalificacion";
                    break;
                case 3:
                    estadisticaSeleccionada = estadisticaSeleccionada = "GOODTIMES.Top5VendedoresConStock";
                    visibilidad = visibilidades.Find(x => x.descripcion.Equals(cboVisibilidades.Text));
                    parametros.Add(new SqlParameter("@ID_VISIBILIDAD", visibilidad.id));
                    break;
                }

        
            parametros.Add(new SqlParameter("@DESDE", fechaDesde));
            parametros.Add(new SqlParameter("@HASTA", fechaHasta));


            DataSet dataset = BasesDeDatos.ObtenerDataSet(estadisticaSeleccionada, BasesDeDatos.Tipos.StoreProcedure, parametros);
            dataGridView1.DataSource = dataset.Tables[0].DefaultView;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboEstadistica_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible = cboEstadistica.SelectedIndex == 3;
                lb_visibilidad.Visible = visible;
                cboVisibilidades.Visible = visible;
        }

        
    }
}
