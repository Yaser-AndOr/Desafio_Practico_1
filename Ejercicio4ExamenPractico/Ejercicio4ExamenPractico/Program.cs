using System;

namespace Ejercicio4_EP
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1 = 0, num2 = 0, num3 = 0;
            Console.WriteLine("Ingrese num1");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese num2");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese num3");
            num3 = Double.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
            Console.ReadKey();
        }
    }
}
