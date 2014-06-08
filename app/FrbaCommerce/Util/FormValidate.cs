using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Vistas.Registro_de_Usuario;
using System.Windows.Forms;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Util
{
    static class FormValidate
    {
        public static Boolean StringIsNullOrEmpty(String parameter, String parameterName)
        {
            if (String.IsNullOrEmpty(parameter))
            {
                MessageBox.Show("El campo " + parameterName + " no puede ser vacio.", "Error al validar el campo.");
                return false;
            }
            return true;
        }

        public static Boolean isUserLoggedIn()
        {
            Int64 usuario_id = Session.usuario.id;
            if (usuario_id == null)
            {
                MessageBox.Show("El usuario no está logueado");
                return false;
            }
            return true;
        }
    }
}
