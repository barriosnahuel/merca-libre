using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Utiles
{
    public class BasesDeDatos
    {

        static SqlConnection Conexion = new SqlConnection();
        public static SqlConnection ObtenerConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = LeerConfiguracion("Provider", @"Server=localhost\SQLSERVER2008;Database=GD1C2014;User Id=gd;Password=gd2014;");
                Conexion.Open();
            }

            return Conexion;
        }

        public static SqlConnection ObtenerConexion(bool ObtenerBaseNueva)
        {
            if (ObtenerBaseNueva == false)
            {
                return ObtenerConexion();
            }
            else
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = LeerConfiguracion("Provider", @"Server=localhost\SQLSERVER2008;Database=GD1C2014;User Id=gd;Password=gd2014;");
                Conexion.Open();
                return Conexion;
            }
        }

        public enum Tipos
        {
            Text,
            StoreProcedure,
            TableDirect
        }
        public static SqlDataReader ObtenerDataReader(String SQL, Tipos Descripcion, List<SqlParameter> Parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = SQL;

            foreach (SqlParameter par in Parametros)
            {
                comando.Parameters.Add(par);
            }

            switch (Descripcion)
            {
                case Tipos.Text:
                    comando.CommandType = CommandType.Text;
                    break;

                case Tipos.StoreProcedure:
                    comando.CommandType = CommandType.StoredProcedure;
                    break;

                case Tipos.TableDirect:
                    comando.CommandType = CommandType.TableDirect;
                    break;

                default:
                    break;

            }

            comando.Connection = ObtenerConexion();

            SqlDataReader DataReader = comando.ExecuteReader();

            return DataReader;
        }

        public static DataSet ObtenerDataSet(String SQL, Tipos Descripcion, List<SqlParameter> Parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = SQL;

            foreach (SqlParameter par in Parametros)
            {
                comando.Parameters.Add(par);
            }

            switch (Descripcion)
            {
                case Tipos.Text:
                    comando.CommandType = CommandType.Text;
                    break;

                case Tipos.StoreProcedure:
                    comando.CommandType = CommandType.StoredProcedure;
                    break;

                case Tipos.TableDirect:
                    comando.CommandType = CommandType.TableDirect;
                    break;

                default:
                    break;

            }

            comando.Connection = ObtenerConexion();

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            adapter.Fill(dataSet);

            return dataSet;
        }


        public static SqlDataReader ObtenerDataReader(String SQL)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            return ObtenerDataReader(SQL, Tipos.Text, ListaParametros);
        }
        public static DataSet ObtenerDataSet(String SQL)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            return ObtenerDataSet(SQL, Tipos.Text, ListaParametros);
        }

        public enum TiposEscritura
        {
            Text,
            StoreProcedure
        }
        public static bool EscribirEnBase(string SQL, TiposEscritura Descripcion, List<SqlParameter> Parametros)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandText = SQL;

            foreach (SqlParameter par in Parametros)
            {
                comando.Parameters.Add(par);
            }

            switch (Descripcion)
            {
                case TiposEscritura.Text:
                    comando.CommandType = CommandType.Text;
                    break;

                case TiposEscritura.StoreProcedure:
                    comando.CommandType = CommandType.StoredProcedure;
                    break;

                default:
                    break;

            }

            comando.Connection = ObtenerConexion();

            try
            {
                comando.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }


        }



        public static bool EscribirEnBase(string SQL)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            return EscribirEnBase(SQL, TiposEscritura.Text, ListaParametros);
        }

        public static string LeerConfiguracion(string nombre)
        {
            string Valor = "";
            bool ValorEncontrado = false;

            if (!File.Exists(Application.StartupPath + @"\Configuracion.txt"))
            {
                StreamWriter escritor = new StreamWriter(Application.StartupPath + @"\Configuracion.txt");
                escritor.Close();

            }

            StreamReader lector = new StreamReader(Application.StartupPath + @"\Configuracion.txt");
            string linea = lector.ReadLine();
            while (linea != null)
            {
                if (linea.Substring(0, linea.IndexOf("_")) == nombre)
                {
                    Valor = linea.Substring(linea.IndexOf("_") + 1);
                    ValorEncontrado = true;
                }
                linea = lector.ReadLine();
            }
            lector.Close();



            if (ValorEncontrado == true)
            {
                return Valor;
            }
            else
            {
                return null;
            }

        }

        public static string LeerConfiguracion(string nombre, string valordefault)
        {
            string Valor = "";
            bool ValorEncontrado = false;

            if (!File.Exists(Application.StartupPath + @"Configuracion.txt"))
            {
                StreamWriter escritor = new StreamWriter(Application.StartupPath + @"Configuracion.txt");
                escritor.Close();

            }

            StreamReader lector = new StreamReader(Application.StartupPath + @"Configuracion.txt");
            string linea = lector.ReadLine();
            while (linea != null)
            {
                if (linea.Substring(0, linea.IndexOf("_")) == nombre)
                {
                    Valor = linea.Substring(linea.IndexOf("_") + 1);
                    ValorEncontrado = true;
                }
                linea = lector.ReadLine();
            }
            lector.Close();



            if (ValorEncontrado == true)
            {
                return Valor;
            }
            else
            {
                GrabarConfiguracion(nombre, valordefault);
                return valordefault;
            }

        }


        public static void GrabarConfiguracion(string nombre, string valor)
        {
            if (!File.Exists(Application.StartupPath + @"\Configuracion.txt"))
            {
                StreamWriter escritor = new StreamWriter(Application.StartupPath + @"\Configuracion.txt");
                escritor.Close();
            }

            StreamReader leer = new StreamReader(Application.StartupPath + @"\Configuracion.txt");
            List<string> Configs = new List<string>();
            string linea = leer.ReadLine();
            while (linea != null)
            {
                Configs.Add(linea);
                linea = leer.ReadLine();
            }
            leer.Close();

            if (LeerConfiguracion(nombre) == null)
            {
                StreamWriter escritor = new StreamWriter(Application.StartupPath + @"\Configuracion.txt");
                escritor.WriteLine(nombre + "_" + valor);
                escritor.Close();

            }
            else
            {
                for (int i = 0; i < Configs.Count; i++)
                {
                    if (Configs[i].Substring(0, Configs[i].IndexOf("_")) == nombre)
                    {
                        Configs[i] = nombre + "_" + valor;
                        i = Configs.Count + 5;
                    }
                }

                StreamWriter escritor = new StreamWriter(Application.StartupPath + @"\Configuracion.txt");
                for (int i = 0; i < Configs.Count; i++)
                {
                    escritor.WriteLine(Configs[i]);

                }

                escritor.Close();

            }
        }


    }

}