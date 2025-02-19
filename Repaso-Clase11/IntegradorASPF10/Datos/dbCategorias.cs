﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Entidades.Exceptions;

namespace Datos
{
    public class dbCategorias:Conexion
    {
        public List<Categoria> Listar()
        {
            List<Categoria> Lista = new List<Categoria>();
            SQL = "SELECT CategoryId, CategoryName FROM Categories ORDER BY CategoryName";
            objComando.CommandText = SQL;
            try
            {
                objConexion.Open();
                SqlDataReader objReader = objComando.ExecuteReader();
                while (objReader.Read())
                {
                    Categoria Item = new Categoria();
                    Item.Id = (int)objReader["CategoryId"];
                    Item.Nombre = (string)objReader["CategoryName"];
                    Lista.Add(Item);
                }
            }
            catch (SqlException ex)
            {
                throw new CapaDatosException("No se puede conectar a la BD " + ex.ToString());
            }
            finally
            {
                if (objConexion.State == System.Data.ConnectionState.Open)
                {
                    objConexion.Close();
                }
            }
            return Lista;
        }
    }
}
