using Blog.Entidades;
using Blog.Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Datos
{
    public class CategoriasDatos
    {
        private readonly string connectionString;
        // CLASE 10 - Esto esta en la clase 10 - en 1 hora 55 minutos de video clase online.
        public CategoriasDatos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["EducacionITBlog"].ConnectionString;
        }
        
        public List<Categoria> TodasLasCategorias()
        {
            List<Categoria> resultado = new List<Categoria>();
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM CATEGORIAS",conexion);
                conexion.Open();
               
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria unaCategoria = new Categoria();
                        unaCategoria.Id = reader.GetInt32(0);
                        unaCategoria.Nombre = reader["Nombre"].ToString();
                        resultado.Add(unaCategoria);
                    }
                }
            }
            return resultado;
        }

        // EJECUTAR STORED PROCEDURE - Lo pongo aca porque es similar a TODAS LAS CATEGORIAS
        public List<Categoria> TodasLasCategoriasStoredProcedure()
        {
            
            List<Categoria> resultado = new List<Categoria>();
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("SP_Categorias", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                

                // Esta es 1 forma
                comando.Parameters.AddWithValue("ParametroNumerico", 1);


                // Esta es la otra FORMA                
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "ParametroTexto";
                parametro.Value = "Cualquier Cosa";
                comando.Parameters.Add(parametro);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria unaCategoria = new Categoria();
                            unaCategoria.Id = reader.GetInt32(0);
                            unaCategoria.Nombre = reader["Nombre"].ToString();
                            resultado.Add(unaCategoria);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new CapaDatosException("No hay conexion a la BD");
                }
            }
            return resultado;
        }

        public Categoria ObtenerCategoria(int id)
        {
            Categoria resultado = null; // al definir el objeto este ponemos NULL porque puede no devolver nada el SELECT que vamos a hacer ahora.

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM CATEGORIAS WHERE ID={id};",conexion);
                conexion.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = new Categoria();
                        resultado.Id = reader.GetInt32(0);
                        resultado.Nombre = reader["Nombre"].ToString();
                    }

                }
            }
            return resultado;
        }

        public void ActualizarCategoria(int id, string nombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consulta = $"UPDATE CATEGORIAS SET Nombre = '{nombre}' WHERE ID={id};";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    conexion.Open();
                    comando.ExecuteNonQuery(); // devuelve el numero de filas afectadas
                }
            }
            catch (SqlException capaDatosEx)
            {
                throw new CapaDatosException("No se pudo conectar a la BD");
            }
        }

        public void InsertarCategoria(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = $"INSERT INTO CATEGORIAS (Nombre) VALUES ('{nombre}');";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                comando.ExecuteNonQuery(); // devuelve el numero de filas afectadas

            }
        }
        // VIDEO 1 hora 35 mins - 14/03  
        public void BorrarCategoria(int id)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = $"DELETE FROM CATEGORIAS WHERE ID={id};";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                comando.ExecuteNonQuery(); // devuelve el numero de filas afectadas

            }
        }

    }
}
