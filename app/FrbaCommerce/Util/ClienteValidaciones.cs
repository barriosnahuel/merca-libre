using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Servicios;
using System.Windows.Forms;
using FrbaCommerce.Modelos;

namespace FrbaCommerce.Util
{
    class ClienteValidaciones
    {
        public static Boolean validate(Cliente cliente, Boolean hacerValidacionExistenciaTelefonoYDni)
        {
            if (!validateEmptyFields(cliente))
            {
                return false;
            }

            /** Solamente valido esto si es una creacion. En caso de que sea una modificacion es por parte de la administracion y no se chequea
             * la existencia de estos datos */
            if (hacerValidacionExistenciaTelefonoYDni)
            {
                if (Clientes.buscarClientePorTelefono(cliente.telefono) != null)
                {
                    MessageBox.Show("Existe un cliente con el telefono: " + cliente.telefono, "Error de validacion.");
                    return false;
                }

                if (Clientes.buscarClientePorDNITipoYDNI(cliente.dni_tipo, cliente.dni) != null)
                {
                    MessageBox.Show("Existe un cliente con el Tipo y Nº de Documento: " + cliente.dni_tipo + " - " + cliente.dni, "Error de validación.");
                    return false;
                }
            }
            return true;
        }

        private static Boolean validateEmptyFields(Cliente cliente)
        {

            if (!FormValidate.StringIsNullOrEmpty(cliente.nombre, "nombre"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.apellido, "apellido"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.dni_tipo, "tipo de documento"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.dni, "documento"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.mail, "mail"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.telefono, "telefono"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.codigo_postal, "codigopPostal"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.direccion, "direccion"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.localidad, "localidad"))
            {
                return false;
            }

            if (!FormValidate.StringIsNullOrEmpty(cliente.apellido, "apellido"))
            {
                return false;
            }

            return true;
        }
    }
}
