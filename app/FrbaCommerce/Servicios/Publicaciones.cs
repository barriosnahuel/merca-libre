using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelos;
using System.Data.SqlClient;
using Utiles;

namespace FrbaCommerce.Servicios
{
    class Publicaciones
    {
        public static void guardar(Publicacion publicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("ID", -1));
            parametros.Add(new SqlParameter("USUARIO_ID",publicacion.usuario.id));
            parametros.Add(new SqlParameter("DESCRIPCION", publicacion.descripcion));
            parametros.Add(new SqlParameter("UNIDADES", publicacion.stock));
            parametros.Add(new SqlParameter("PRECIO", publicacion.precio));
            parametros.Add(new SqlParameter("FEC_INICIO", publicacion.desde));
            parametros.Add(new SqlParameter("FEC_FIN", publicacion.hasta));
            parametros.Add(new SqlParameter("TIPO_PUBLICACION_ID", publicacion.tipo.id));
            parametros.Add(new SqlParameter("ESTADO_ID", publicacion.estado.id));
            parametros.Add(new SqlParameter("VISIBILIDAD_ID", publicacion.visibilidad.id));
            parametros.Add(new SqlParameter("ADMITE_PREGUNTAS", publicacion.admitePregunta?1:0));


            publicacion.id = Int64.Parse(BasesDeDatos.queryForDecimal("GoodTimes.GuardarPublicacion", BasesDeDatos.TiposEscritura.StoreProcedure, parametros).ToString());

            
            foreach (Rubro rubro in publicacion.rubros)
            {
                parametros.Clear();
                parametros.Add(new SqlParameter("PUBLICACION_ID", publicacion.id));
                parametros.Add(new SqlParameter("RUBRO_ID", rubro.id));
                BasesDeDatos.EscribirEnBase("GoodTimes.AgregarRubroAPublicacion", BasesDeDatos.TiposEscritura.StoreProcedure, parametros);
            }
            
           
        }
    }
}
