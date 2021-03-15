using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //try
            //{
            //    Console.WriteLine("TRY");
            //    throw new Exception("Mi exception");
            //}
            //catch
            //{
            //    Console.WriteLine("CATCH - Atrapa la exception");
            //}
            //finally
            //{
            //    Console.WriteLine("FINALLY - Se ejecuta siempre");
            //}

            // Ejemplo 2
            try
            {
                Console.WriteLine("TRY");
                throw new Exception("My Excepticon");
            }
            catch (Exception e)
            {
                Console.WriteLine("CATCH 1");
                Console.WriteLine("Excepcion detectada: " + e.Message);
            }
            catch
            {
                Console.WriteLine("CATCH 2");
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }


            Console.ReadKey();
        }
    }
}
