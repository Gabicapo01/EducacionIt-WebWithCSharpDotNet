using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Objetos Anonimos
            var anonimo = new { Cantidad = 10, Mensaje="Hola" };
            var otroAnonimo = new { Cantidad = 10, Mensaje = "Chau", otroMensaje = "Hola" };
            var tercero = new { otraCosa = 1000 };

        }
    }
}
