using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numerador = 10;
            //Console.WriteLine("Numerador es = {0}", numerador);
            //Console.WriteLine("Denominador = ");
            //string strDen = Console.ReadLine();
            //int denominador, cociente;

            //// Trata de hacer un division 
            //try
            //{
            //    Console.WriteLine("--> try");
            //    denominador = Convert.ToInt16(strDen);
            //    cociente = numerador / denominador;
            //    Console.WriteLine("Cociente = {0}", cociente);
            //}
            ////Atrapa excepcion ArithmeticException
            //catch (ArithmeticException e)
            //{
            //    Console.WriteLine("--> Catch");
            //    Console.WriteLine("Excepcion Aritmetica");
            //    Console.WriteLine("ArithmeticException Handler: {0}", e.ToString());
            //}
            //// Atrapa excepcion ArgumentullException
            //catch(ArgumentNullException e)
            //{
            //    Console.WriteLine("--> catch");
            //    Console.WriteLine("Exception de argumento nulo");
            //    Console.WriteLine("ArgumentNullException Handler: {0}", e.ToString());
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("--> CATCH");
            //    Console.WriteLine("Generic Handler: {0}", e.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("--> FINALLY");
            //}


            int numerador = 10;
            Console.WriteLine("Numerador es = {0}", numerador);
            Console.WriteLine("Denominador = ");
            string strDen = Console.ReadLine();
            int denominador, cociente;

            // Trata de hacer un division 
            try
            {
                Console.WriteLine("--> try");
                denominador = Convert.ToInt16(strDen);
                cociente = numerador / denominador;
                Console.WriteLine("Cociente = {0}", cociente);
            }
            catch (Exception e)
            {
                Console.WriteLine("--> Catch");
                Console.WriteLine("Generic Handler: {0}", e.ToString());
                Console.WriteLine();

                StackTrace st = new StackTrace(e, true);

                Console.WriteLine("Traza de la pila:");
                for (int i = 0; i < st.FrameCount; i++)
                {
                    StackFrame sf = st.GetFrame(i);
                    Console.WriteLine(" Pila de llamadas, Método: {0}", sf.GetMethod());
                    Console.WriteLine(" Pila de llamadas, Línea : {0}", sf.GetFileLineNumber());
                }
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("--> finally");
            }


            Console.ReadLine();
        }
    }
}
