using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entidades
{
    public class Comentarios
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Comentario { get; set; }
        public int IdPost { get; set; }

    }
}
