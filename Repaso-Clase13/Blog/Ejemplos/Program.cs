using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Objetos Anonimos
            var anonimo = new { Cantidad = 10, Mensaje = "Hola" };
            var otroAnonimo = new { Cantidad = 10, Mensaje = "Chau", otroMensaje = "Hola" };
            var tercero = new { otraCosa = 1000 };

            Matematicas matematica = new Matematicas();

            matematica.Calcular(ancho: 100, alto: 200);
            matematica.Calcular(alto: 300, ancho: 1000);
            matematica.Calcular(400, alto: 200);

            //Luego del primer parametro nombrado, todos los demas tienen que ser nombrados.
            //matematica.Calcular(alto: 200, 400);

            ThreadStart tHiloUno = new ThreadStart(Interna.HiloUno);
            ThreadStart tHiloDos = new ThreadStart(Interna.HiloDos);

            Thread hiloUno = new Thread(tHiloUno);
            Thread hiloDos = new Thread(tHiloDos);

            hiloUno.Start();
            hiloDos.Start();

            Interna.HiloUno();
            //Interna.HiloDos();
            Console.ReadLine();

        }
        private class Interna
        {
            public static void HiloUno()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"Bucle 1, iteracion {i}");
                    Thread.Sleep(500);
                }
            }

            public static void HiloDos()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine($"Bucle 2, iteracion {i}");
                    Thread.Sleep(700);

                }
            }
        }
    }
}
