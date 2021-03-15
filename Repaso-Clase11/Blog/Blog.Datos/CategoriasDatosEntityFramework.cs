using Blog.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Datos
{
    public class CategoriasDatosEntityFramework
    {
        // Esto esta en clase 10 - 2 horas 20 minutos de video. La idea es agregar el resto de las secciones de las categorias. 
        private Entities entidadesContext = new Entities();
        
        public Categorias ObtenerCategoriaPorEntityFramework(int idCategoria)
        {
            Categorias unaCategoria = entidadesContext.Categorias.Where(p => p.Id == idCategoria).FirstOrDefault();

            //var consulta = from p in entidadesContext.Categorias
            //               where p.Id==idCategoria
            //               select p;

            Categorias resultado = new Categorias()
                {
                    Id=unaCategoria.Id,
                    Nombre=unaCategoria.Nombre,
                };
            
            return resultado;
        }

        public Categoria ObtenerCategoriaPorIdEf(int idCategoria)
        {
            Categorias unaCategoria = entidadesContext.Categorias.Where(p => p.Id == idCategoria).FirstOrDefault();

            //var consulta = from p in entidadesContext.Categorias
            //               where p.Id==idCategoria
            //               select p;

            Categoria resultado = new Categoria()
            {
                Id = unaCategoria.Id,
                Nombre = unaCategoria.Nombre,
            };

            return resultado;
        }

        public void InsertarCategoriaPorEf(Categoria categoriaAInsertar) 
        {
            Categorias resultado = new Categorias();

            resultado.Id = categoriaAInsertar.Id;
            resultado.Nombre = categoriaAInsertar.Nombre;
            
            entidadesContext.Categorias.Add(resultado);
            entidadesContext.SaveChanges();
        }

        public void ActualizarCategoriaPorEf(Categoria categoriaAActualizarPorParametro)
        {
            Categorias result = entidadesContext.Categorias.Where(x => x.Id == categoriaAActualizarPorParametro.Id).FirstOrDefault();

            result.Id = categoriaAActualizarPorParametro.Id;
            result.Nombre = categoriaAActualizarPorParametro.Nombre;

            entidadesContext.SaveChanges();
        }

        public void EliminarCategoriaPorEf(Categoria categAEliminarPorParam)
        {
            Categorias catAEliminar = entidadesContext.Categorias.Where(x => x.Id == categAEliminarPorParam.Id).FirstOrDefault();
            entidadesContext.Categorias.Remove(catAEliminar);
            entidadesContext.SaveChanges();
        }

        // CLASE 10 - Video - 2 horas 22 minutos.
    }
}