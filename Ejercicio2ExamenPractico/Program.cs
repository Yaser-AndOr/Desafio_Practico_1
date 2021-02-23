using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2ExamenPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingrese 4 numeros, los dos primeros numeros realizaran una suma, mientras que el tercer y cuarto numero darán como resultado un producto

            int n1, n2, n3, n4, suma, producto;
            Console.WriteLine("Ingrese el valor del primer numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo numero");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del tercer numero");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cuarto numero");
            n4 = int.Parse(Console.ReadLine());
            //Se suman los dos primeros numeros para obtener el resultado de la suma
            suma = n1 + n2;
            //Se multiplican el tercer y cuarto numero para obtener el producto
            producto = n3 * n4;
            Console.WriteLine("La suma de los dos primeros numeros es " + suma + " , y el producto del tercer y cuarto numero es " + producto);
            Console.ReadKey();
        }
    }
}
