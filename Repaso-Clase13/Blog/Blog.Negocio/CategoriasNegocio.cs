using Blog.Datos;
using Blog.Entidades;
using Blog.Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Negocio
{
    public class CategoriasNegocio
    {
        private readonly CategoriasDatos categoriasDatos = new CategoriasDatos();
        private readonly CategoriasDatosEntityFramework categoriasDatosEntityFramework = new CategoriasDatosEntityFramework();

        public List<Categoria> TodasLasCategorias()
        {
            return categoriasDatos.TodasLasCategorias();
        }

        public List<Categoria> TodasLasCategoriasStoredProcedure()
        {
            return categoriasDatos.TodasLasCategoriasStoredProcedure();
        }

        public Categoria ObtenerUnaCategoria(int id)
        {
            return categoriasDatos.ObtenerCategoria(id);
        }

        public Categoria ObtenerCategoriaEF(int idCategoria)
        {
            return categoriasDatosEntityFramework.ObtenerCategoriaPorIdEf(idCategoria);
        }

        //public Categoria ObtenerCategoriaPorNombreEfNegocio(string nombre)
        //{
        //    return categoriasDatosEntityFramework.ObtenerCategoriaPorEntityFramework(nombre);

        //}

        public void ActualizarCategoria(int id, string nombre)
        {
            // Esto esta en video CLASE 11 - 1 hora 13 minutos//
            if (!string.IsNullOrWhiteSpace(nombre))  // VALIDACION DE NEGOCIO
            {
                categoriasDatos.ActualizarCategoria(id, nombre);
            }
            else
            {
                throw new ValidacionNegocioException("Debe Ingresar el nombre");
            }   
        }

        public void InsertarCategoria(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                categoriasDatos.InsertarCategoria(nombre);
            }
            else
            {
                throw new ValidacionNegocioException("Debe ingresar el nombre");
            } 
        }

        public bool BorrarCategoria(int id)
        {
            bool resultado = false;

            if (id!=0)  // VALIDACION DE NEGOCIO
            {
                categoriasDatos.BorrarCategoria(id);
                resultado = true;
            }

            return resultado;
        }
    }
}
