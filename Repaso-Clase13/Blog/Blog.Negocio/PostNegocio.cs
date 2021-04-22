using Blog.Datos;
using Blog.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Negocio
{
    public class PostNegocio
    {
        private PostDatos postDatos = new PostDatos();

        public List<BlogPost> TodosLosPosts()
        {
            return postDatos.TodosLosPost();
        }

        public BlogPost ObtenerPost(int id)
        {
            return postDatos.ObtenerPost(id);
        }

        public List<BlogPost> ListarPorCategoria(int id)
        {
            return postDatos.ListarPorCategoria(id);
        }

        public bool InsertarPost(BlogPost blogPost)
        {
            bool resultado = false;
                
            if(blogPost != null)
            {
                postDatos.Insertar(blogPost);
                resultado = true;
            }

            return resultado;
        }

        public bool Actualizar(BlogPost blogPost)
        {
            bool resultado = false;
            if (blogPost!=null)
            {
                postDatos.Actualizar(blogPost);
                resultado = true;
            }
            return resultado;
        }

        public bool Eliminar(int id)
        {
            bool resultado = false;
            if (id != 0)
            {
                postDatos.Eliminar(id);
                resultado = true;
            }
            return resultado;
        }
    }
}
