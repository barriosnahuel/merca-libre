using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Utiles;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Servicios
{
    class Rubros
    {


        public static List<Rubro> listar()
        {
            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.ListarRubros", BasesDeDatos.Tipos.StoreProcedure, new List<SqlParameter>());
            List<Rubro> rubros = new List<Rubro>();

            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    rubros.Add(getRubro(lector));
                }

            }
            lector.Close();
            return rubros;
        }


        private static Rubro getRubro(SqlDataReader lector)
        {
            Rubro rubro = new Rubro();
            rubro.id = lector.GetInt32(lector.GetOrdinal("CODIGO"));
            rubro.descripcion = lector.GetString(lector.GetOrdinal("DESCRIPCION"));

            return rubro;

        }


        public static List<Rubro> buscarPorPublicacion(Int64 id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ID", id));

            SqlDataReader lector = BasesDeDatos.ObtenerDataReader("GOODTIMES.BuscarRubroPorPublicacion", BasesDeDatos.Tipos.StoreProcedure, parametros);
            List<Rubro> rubros = new List<Rubro>();

            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    rubros.Add(getRubro(lector));
                }

            }
            lector.Close();
            return rubros;
        }
    }
}
