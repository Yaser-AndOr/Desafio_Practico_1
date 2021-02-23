using System;

namespace Ejercicio1_EP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se mejora la apariencia de la consola*/
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            /*Se declaran las variables a utilizar*/
            Double Valor = 0, Cantidad = 0, Monto = 0;
            /*Se escribe el texto inicial y se piden al usuario los datos a utilizar*/
            Console.Write("" +
                "===============================================\n" +
                "*            Calculadora de precios           *\n" +
                "*    Ingrese primero el valor del artículo    *\n" +
                "*    Ingrese luego la cantidad de artículos   *\n" +
                "*  El programa retornará el monto a pagar por *\n" +
                "*                 el cliente                  *\n" +
                "===============================================\n" +
                "          Ingrese el valor del artículo        \n" +
                "$");
            Valor = Double.Parse(Console.ReadLine());
            Console.WriteLine("" +
                "         Ingrese la cantidad de artículos      ");
            Cantidad = Double.Parse(Console.ReadLine());
            /*Se hacen los debidos cálculos para posteriormente imprimirlos en pantalla*/
            Monto = Valor * Cantidad;
            Console.WriteLine("El monto a pagar es: $" + Monto);
            Console.ReadKey();
        }
    }
}
