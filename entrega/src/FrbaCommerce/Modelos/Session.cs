using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace FrbaCommerce.Modelos
{
    static class Session
    {
        public static Usuario usuario;
        
        public static DateTime fechaAhora()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../../app.config");
            XmlNodeList fecha = xDoc.GetElementsByTagName("FechaAhora");
            return DateTime.ParseExact(fecha[0].InnerXml.ToString(), "dd/MM/yyyy HH:mm", null);
        }

        public static String ConnectionString()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../../app.config");
            XmlNodeList ConnectionString = xDoc.GetElementsByTagName("ConnectionString");
            return ConnectionString[0].InnerXml.ToString();
        }
    }
}
