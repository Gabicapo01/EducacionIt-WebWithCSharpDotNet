using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Conversiones
    {
        public static int ToInt32(string valor)
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
         
        public static void PruebasConversiones()
        {
            string valor = null;
            object valorObject = null;

            int valorEnteroValido = 0;
            Nullable<int> valorEntero = null;
            Nullable<decimal> otroValorNullable = null;

            int? valorEnteroQuePuedeSerNull = null;

            bool tieneValor = valorEntero.HasValue; //Si el HasValue es FALSE, es porque no tiene valor.
            int valorSubyacente = valorEntero.Value;

            // si quiero hacer esto tengo que preguntar antes por el HasValue.
            //int noEsValido = valorEntero;

            int variableEnteraPura = valorEntero ?? -1; // este operador ?? pregunta si la variable valorEntero es NULL, y si NO es NULL, uso la variable
            // valorEntero, y si es NULL uso lo que esta a la derecha, -1 en este caso.
            //Este operador es muy util a la hora de comprobar si hay valores NULL en cualquier tipo de objeto.

            // Conversion IMPLICITA
            int numero = 123123123;
            long numeroGrande = numero;

            // pasa igual con la herencia, puedo asignar una clase hija a una variable de tipo padre 
            // sin necesidad de convertir el dato.

            //Conversiones EXPLICITAS

            double valorDouble = 12.75;
            int valorDoubleConvertidoAEntero = (int)valorDouble; //entonces asigna el valor 12, redondea y pierde el .75. CAST se llama.

            long numeroMuyGrande = long.MaxValue;
            // tira excepcion por que no entra en el INT, CAST/conversion.
            // int numeroInt = (int)numeroMuyGrande;

            //BOXING - es el ajuste de un tipo de dato al otro, cuando puedo hacerlo directamente. (meter dentro de una caja)
            int i = 1232123123;
            object boxing = i;

            //Conversion UNBOXING
            int unboxing = (int)boxing;

            //ambos consumen un monton de recursos.

            List<string> listaDeString;
            List<int> listaDeEnteros;
            List<Object> listaDeObject;

            List<List<string>> anidado;

            ListaGenerica<string> listaGenerica = new ListaGenerica<string>();

            listaGenerica.Agregar("Valor 1");
            listaGenerica.Agregar("Valor 2");
            listaGenerica.Agregar("Valor 3");
            listaGenerica.Agregar("Valor 4");

            foreach (var elementoDeListaGenerica in listaGenerica)
            {

            }
        }
    }
}
