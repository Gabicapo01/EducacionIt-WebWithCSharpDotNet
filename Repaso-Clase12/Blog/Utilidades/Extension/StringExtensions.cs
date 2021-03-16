using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Extension
{
    public static class StringExtensions
    {
        public static int ToInt32(this string valor)
        {
            int resultado = 0;
            try
            {
                resultado = Convert.ToInt32(valor);
            }
            catch
            {

                resultado = 0;
            }
            return resultado;
        }
        public static string Concatenar(this string valor, string nuevoValor)
        {
            return valor + nuevoValor;
        }
    }
}
