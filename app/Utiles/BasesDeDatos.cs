using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;

namespace Utiles
{
    public class BasesDeDatos
    {

        static SqlConnection Conexion = new SqlConnection();
        static String connString = @"Server=localhost\SQLEXPRESS;Database=GD1C2014;User Id=gd;Password=gd2014;";

        public static SqlConnection ObtenerConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = connString;
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
                Conexion.ConnectionString = connString;
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

                comando.ExecuteReader().Close();
                return true;
           
        }

        public static bool EscribirEnBase(string SQL)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            return EscribirEnBase(SQL, TiposEscritura.Text, ListaParametros);
        }

        public static int queryForInt(string SQL, TiposEscritura Descripcion, List<SqlParameter> Parametros)
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

           return (int)comando.ExecuteScalar();
            
        }

    }

}