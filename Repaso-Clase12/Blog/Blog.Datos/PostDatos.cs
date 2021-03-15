using Blog.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Datos
{
    public class PostDatos
    {
        private Entities entitiesContext = new Entities();
        private CategoriasDatosEntityFramework categoriasDatos = new CategoriasDatosEntityFramework();
        public List<BlogPost> TodosLosPost()
        {
            List<Post> todosLosPost = entitiesContext.Post.OrderBy(x => x.Id).ToList();
            List<BlogPost> resultado = new List<BlogPost>();

            foreach (var item in todosLosPost)
            {
                resultado.Add(new BlogPost()
                {
                    Id = item.Id,
                    Categoria = new Categoria()
                    {
                        Id = item.Categorias.Id,
                        Nombre = item.Categorias.Nombre
                    },
                    Titulo = item.Titulo,
                    Resumen=item.Resumen,
                    Cuerpo=item.Cuerpo
                });

            }
            return resultado;
        }

        public BlogPost ObtenerPost(int id)
        {
            Post unPost = entitiesContext.Post.Where(p => p.Id == id).FirstOrDefault(); //aca esta la interaccion con la BD.

            BlogPost resultado = new BlogPost()
            {
                Id = unPost.Id,
                Categoria = new Categoria()
                {
                    Id = unPost.Categorias.Id,
                    Nombre = unPost.Categorias.Nombre
                },
                Titulo = unPost.Titulo,
                Resumen = unPost.Resumen,
                Cuerpo = unPost.Cuerpo
            };
            return resultado;
        }

        public List<BlogPost>ListarPorCategoria(int idCategoria)
        {
            var consulta = from p in entitiesContext.Post                // consulta LINQ sin expresiones LAMBDA 
                             where p.IdCategoria == idCategoria
                             select p;

            List<BlogPost> resultado = new List<BlogPost>();

            foreach (var item in consulta.ToList())
            {
                resultado.Add(new BlogPost()
                {
                    Id = item.Id,
                    Categoria = new Categoria()
                    {
                        Id = item.Categorias.Id,
                        Nombre = item.Categorias.Nombre
                    },
                    Titulo = item.Titulo,
                    Resumen = item.Resumen,
                    Cuerpo = item.Cuerpo
                });
            }
            return resultado;
        }

        public void Insertar(BlogPost blogPost)
        {
            Categorias categoriaPost = categoriasDatos.ObtenerCategoriaPorEntityFramework(blogPost.Categoria.Id);
            Post post = new Post()
            {
                //Categorias = new Categorias() //Hay un detalle
                //{
                //    Id = categoriaPost.Id,
                //    Nombre = categoriaPost.Nombre
                //},
                Categorias = categoriaPost, //===> durante la clase, el profesor hizo eso -- el metodo ObtenerCategoriaPorEntityFramework,
                // devuelve un objeto de tipo Categorias que se encuentra en la BASE DE DATOS (a traves de EF), para no crear una Categoria nueva
                // cada vez que se inserta un blogPost.
                
                Cuerpo = blogPost.Cuerpo,
                Resumen = blogPost.Resumen,
                Titulo=blogPost.Titulo,
            };
            entitiesContext.Post.Add(post); // esto agrega como un nuevo objeto
            entitiesContext.SaveChanges(); // y esto dice, todos los cambios que estuve haciendo, ahora Guardalos.
        }

        public void Actualizar(BlogPost blogPost)
        {
            Post postAActualizar = entitiesContext.Post.Where(x => x.Id == blogPost.Id).FirstOrDefault();

            postAActualizar.Titulo = blogPost.Titulo;
            postAActualizar.Resumen = blogPost.Resumen;
            postAActualizar.Cuerpo = blogPost.Cuerpo;
            //busco la categoria desde la base de datos para asociarla y para NO crearla.
            Categorias categoriaPost = categoriasDatos.ObtenerCategoriaPorEntityFramework(blogPost.Categoria.Id);
            postAActualizar.Categorias = categoriaPost;
            entitiesContext.SaveChanges();

        }

        public void Eliminar(int id)
        {
            Post postAEliminar = entitiesContext.Post.Where(x => x.Id == id).FirstOrDefault();

            entitiesContext.Post.Remove(postAEliminar);
            entitiesContext.SaveChanges();
        }
    }
}
