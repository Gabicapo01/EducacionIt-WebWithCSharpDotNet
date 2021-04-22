using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entidades
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Cuerpo { get; set; }
        public Categoria Categoria { get; set; }
    }
}
