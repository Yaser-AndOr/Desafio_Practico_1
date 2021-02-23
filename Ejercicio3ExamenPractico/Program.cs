using System;

namespace Ejercicio3ExamenPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convertir el Diagrama de flujos a código C#

            double nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese el valor de la primera nota");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la segunda nota");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la tercera nota");
            nota3 = double.Parse(Console.ReadLine());
            //Se realiza la suma de las 3 notas y luego se divide entre 3 para obtener el promedio
            promedio = (nota1 + nota2 + nota3) / 3;
            //Si la nota promedio es mayor o igual que 7, significa que ha sido promocionado
            if (promedio >= 7) 
            {
                Console.WriteLine("Felicidades, has sido promocionado con una nota de " + promedio);
            }
            //Si la nota promedio es mayor o igual que 4, significa que obtuvo nota regular pero ha sido reprobado
            else if (promedio >= 4) 
            {
                Console.WriteLine("Ánimo, tú puedes lograrlo, tu promedio ha sido de " + promedio + " , nota regular pero has reprobado la materia");
            }
            //Si la nota promedio es menor que 4, significa que obtuvo una nota muy baja e igualmente ha sido reprobado
            else if (promedio < 4) 
            {
                Console.WriteLine("Vamos tú puedes hacerlo, debes esforzarte más, tu promedio ha sido de " + promedio + ", has sido reprobado");
            }
            Console.ReadKey();
        }
    }
}
