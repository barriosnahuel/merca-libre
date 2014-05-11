using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Vistas.Registro_de_Usuario;

namespace FrbaCommerce.Util
{
    static class FormValidate
    {
        public static Boolean StringIsNullOrEmpty(String parameter, String parameterName)
        {
            if (String.IsNullOrEmpty(parameter))
            {
                VentanaError ventanaError = new VentanaError("El campo " + parameterName + " no puede ser vacio.");
                ventanaError.Show();
                return false;
            }
            return true;
        }
    }
}
