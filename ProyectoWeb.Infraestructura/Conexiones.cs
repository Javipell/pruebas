﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ProyectoWeb.Infraestructura
{
    
    public class Conexiones
    {
        private string cadenaConexion = String.Empty;

        public DataSet Ejecutar(string sql)
        {
            if (string.IsNullOrEmpty(cadenaConexion))
            {
                cadenaConexion = "Data Source=localhost;Initial Catalog=BdEntrevistas;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            }
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            DataSet dataSet = new DataSet();
            try
            {
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
                adaptador.Fill(dataSet);
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion.\n" + cadenaConexion + "\n" + ex.Message);
                throw;
            }
            return dataSet;
        }
        public string ConsultasAID(string sql)
        {
            string resultado = "";
            if (string.IsNullOrEmpty(cadenaConexion))
            {
                cadenaConexion = "Data Source=localhost;Initial Catalog=BdEntrevistas;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            }
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(sql, conexion);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                resultado = ""+ ex.Message;
                //throw;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }
    }
}
