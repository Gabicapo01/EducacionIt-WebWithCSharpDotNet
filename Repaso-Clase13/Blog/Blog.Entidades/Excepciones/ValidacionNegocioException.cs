using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entidades.Excepciones
{
    public class ValidacionNegocioException:Exception
    {
        public ValidacionNegocioException(string mensaje) : base(mensaje)
        {

        }
    }
}
