using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelos;
using System.Windows.Forms;
using FrbaCommerce.Servicios;

namespace FrbaCommerce.Util
{
    class EmpresaValidaciones
    {
        public static Boolean validate(Empresa empresa, Boolean hacerValidacionExistenciaTelefonoYDni)
        {
            if (!validateEmptyFields(empresa))
            {
                return false;
            }

            /** Solamente valido esto si es una creacion. En caso de que sea una modificacion es por parte de la administracion y no se chequea
             * la existencia de estos datos */
            if (hacerValidacionExistenciaTelefonoYDni)
            {
                if (Empresas.buscarEmpresaPorCuit(empresa.cuit) != null)
                {
                    MessageBox.Show("Existe una empresa con el cuit: " + empresa.cuit, "Error de validacion.");
                    return false;
                }

                if (Empresas.buscarEmpresaPorRazonSocial(empresa.razon_social) != null)
                {
                    MessageBox.Show("Existe una empresa con la razon social: " + empresa.razon_social, "Error de validación.");
                    return false;
                }
            }
            return true;
        }

        private static Boolean validateEmptyFields(Empresa empresa)
        {

            if (!FormValidate.StringIsNullOrEmpty(empresa.razon_social, "razon social"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(empresa.nombreContacto, "nombreContacto"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(empresa.mail, "mail"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(empresa.telefono, "telefono"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(empresa.codigo_postal, "codigoPostal"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(empresa.direccion, "direccion"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(empresa.localidad, "localidad"))
            {
                return false;
            }

            return true;
        }
    }
}
