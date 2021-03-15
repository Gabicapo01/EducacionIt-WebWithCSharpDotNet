using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErroresCS
{
    public static class Errores
    {
        public static void Generar()
        {
            Random objRandom = new Random();
            switch (objRandom.Next(4))
            {
                case 0:
                    //indice fuera de rango
                    int[] Vector = new int[9];
                    for (int i = 0; i < 10; i++)
                    {
                        Vector[i]= i;
                    }
                    break;
                case 1:
                    //conversion invalida
                    DateTime Fecha = Convert.ToDateTime("Fecha inválida");
                    break;
                case 2:
                    //division por cero
                    int a=0;
                    int b=0;
                    a = a / b;
                    break;
                case 3:
                    //Overflow
                    byte varByte = 0;
                    varByte = Convert.ToByte(257);
                    break;
                default:
                    throw new Exception("Fuera de rango");
            }
        }
    }
}
