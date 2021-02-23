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
            String NmbEmp1 = "", NmbEmp2 = "", NmbEmp3 = "", CrgEmp1 = "", CrgEmp2 = "", CrgEmp3 = "";
            Double SLEmp1 = 0, SLEmp2 = 0, SLEmp3 = 0, HrsTbj1 = 0, HrsTbj2 = 0, HrsTbj3 = 0, SBEmp1 = 0, SBEmp2 = 0,
                SBEmp3 = 0, ISSSEMP1 = 0, ISSSEMP2 = 0, ISSSEMP3 = 0, AFPEMP1 = 0, AFPEMP2 = 0, AFPEMP3 = 0, RENTAEmp1 = 0,
                RENTAEmp2 = 0, RENTAEmp3 = 0, BnEmp1 = 0, BnEmp2 = 0, BnEmp3 = 0;
            int Bono = 0, GP300 = 0, Valid1 = 0, Valid2 = 0, Valid3 = 0;
            /*Se escribe el texto inicial e indicaciones.*/
            Console.WriteLine("" +
                "===============================================\n" +
                "*  Calculadora de salario de tres empleados   *\n" +
                "*                                             *\n" +
                "*  Ingrese primero el nombre de un empleado   *\n" +
                "*        (Ambos nombres y apellidos)          *\n" +
                "*                                             *\n" +
                "*    Ingrese luego el cargo del empleado      *\n" +
                "*  Este mismo puede ser: Gerente, Asistente o *\n" +
                "*                 Secretaria                  *\n" +
                "*                                             *\n" +
                "*Ingrese luego la cantidad de horas trabajadas*\n" +
                "*              por el empleado                *\n" +
                "*                                             *\n" +
                "*  El programa retornará el sueldo líquido de *\n" +
                "*               cada empleado                 *\n" +
                "===============================================\n" +
            /*Se recolectan los datos del primer empleado*/
                "  Ingrese nombre completo del primer empleado  ");
            NmbEmp1 = Console.ReadLine();
            Console.WriteLine("" +
                "          Ingrese cargo del empleado           ");
            CrgEmp1 = Console.ReadLine();
            for (Valid1 = 0; Valid1 < 1; Valid1 = Valid1)
            {
                Console.WriteLine("" +
                        " Ingrese las horas trabajadas por el empleado  ");
                HrsTbj1 = Double.Parse(Console.ReadLine());
                if (HrsTbj1 < 1)
                {
                    Console.WriteLine("Ingrese una cantidad válida de horas");
                }
                else
                {
                    Valid1 = 1;
                }
            }
            /*Se recolectan los datos del segundo empleado*/
            Console.WriteLine("" +
                " Ingrese nombre completo del segundo empleado  ");
            NmbEmp2 = Console.ReadLine();
            Console.WriteLine("" +
                "          Ingrese cargo del empleado           ");
            CrgEmp2 = Console.ReadLine();
            for (Valid2 = 0; Valid2 < 1; Valid2 = Valid2)
            {
                Console.WriteLine("" +
                        " Ingrese las horas trabajadas por el empleado  ");
                HrsTbj2 = Double.Parse(Console.ReadLine());
                if (HrsTbj2 < 1)
                {
                    Console.WriteLine("Ingrese una cantidad válida de horas");
                }
                else
                {
                    Valid2 = 1;
                }
            }
            /*Se recolectan los datos del tercer empleado*/
            Console.WriteLine("" +
                "  Ingrese nombre completo del tercer empleado  ");
            NmbEmp3 = Console.ReadLine();
            Console.WriteLine("" +
                "          Ingrese cargo del empleado           ");
            CrgEmp3 = Console.ReadLine();
            for (Valid3 = 0; Valid3 < 1; Valid3 = Valid3)
            {
                Console.WriteLine("" +
                        " Ingrese las horas trabajadas por el empleado  ");
                HrsTbj3 = Double.Parse(Console.ReadLine());
                if (HrsTbj3 < 1)
                {
                    Console.WriteLine("Ingrese una cantidad válida de horas");
                }
                else
                {
                    Valid3 = 1;
                }
            }
            /*Se hacen los debidos cálculos sobre el salario del primer empleado*/
            if (HrsTbj1 > 160)
            {
                SBEmp1 = ((160 * 9.75) + ((HrsTbj1 - 160) * 11.5));
            }
            else
            {
                SBEmp1 = HrsTbj1 * 9.75;
            }
            ISSSEMP1 = Math.Round(SBEmp1 * 0.0525, 2);
            AFPEMP1 = Math.Round(SBEmp1 * 0.0688, 2);
            RENTAEmp1 = Math.Round(SBEmp1 * 0.1, 2);
            SLEmp1 = Math.Round(SBEmp1 - (ISSSEMP1 + AFPEMP1 + RENTAEmp1), 2);
            /*Se hacen los debidos cálculos sobre el salario del segundo empleado*/
            if (HrsTbj2 > 160)
            {
                SBEmp2 = (160 * 9.75) + ((HrsTbj2 - 160) * 11.5);
            }
            else
            {
                SBEmp2 = HrsTbj2 * 9.75;
            }
            ISSSEMP2 = Math.Round(SBEmp2 * 0.0525, 2);
            AFPEMP2 = Math.Round(SBEmp2 * 0.0688, 2);
            RENTAEmp2 = Math.Round(SBEmp2 * 0.1, 2);
            SLEmp2 = Math.Round(SBEmp2 - (ISSSEMP2 + AFPEMP2 + RENTAEmp2), 2);
            /*Se hacen los debidos cálculos sobre el salario del tercer empleado*/
            if (HrsTbj3 > 160)
            {
                SBEmp3 = (160 * 9.75) + ((HrsTbj3 - 160) * 11.5);
            }
            else
            {
                SBEmp3 = HrsTbj3 * 9.75;
            }
            ISSSEMP3 = Math.Round(SBEmp3 * 0.0525, 2);
            AFPEMP3 = Math.Round(SBEmp3 * 0.0688, 2);
            RENTAEmp3 = Math.Round(SBEmp3 * 0.1, 2);
            SLEmp3 = Math.Round(SBEmp3 - (ISSSEMP3 + AFPEMP3 + RENTAEmp3), 2);
            /*Se evalúa si los empleados tendrán bono o no.*/
            if ((CrgEmp1 == "Gerente" && CrgEmp2 == "Asistente" && CrgEmp3 == "Secretaria") == false)
                Bono = 1;
            /*Se aplican los bonos.*/
            if (Bono == 1)
            {
                /*Se calcula el bono que tendrá el empleado 1*/
                if (CrgEmp1 == "Gerente") { BnEmp1 = SLEmp1 * 0.1; }
                else if (CrgEmp1 == "Asistente") { BnEmp1 = SLEmp1 * 0.05; }
                else if (CrgEmp1 == "Secretaria") { BnEmp1 = SLEmp1 * 0.03; }
                else
                { BnEmp1 = Math.Round(SLEmp1 * 0.02, 2); }
                /*Se calcula el bono que tendrá el empleado 2*/
                if (CrgEmp2 == "Gerente") { BnEmp2 = SLEmp2 * 0.1; }
                else if (CrgEmp2 == "Asistente") { BnEmp2 = SLEmp2 * 0.05; }
                else if (CrgEmp2 == "Secretaria") { BnEmp2 = SLEmp2 * 0.03; }
                else
                { BnEmp2 = Math.Round(SLEmp2 * 0.02, 2); }
                /*Se calcula el bono que tendrá el empleado 3*/
                if (CrgEmp3 == "Gerente") { BnEmp3 = SLEmp3 * 0.1; }
                else if (CrgEmp3 == "Asistente") { BnEmp3 = SLEmp3 * 0.05; }
                else if (CrgEmp3 == "Secretaria") { BnEmp3 = SLEmp3 * 0.03; }
                else
                { BnEmp3 = Math.Round(SLEmp3 * 0.02, 2); }
            }
            /*Calculados los debidos bonos, se aplican sobre el sueldo líquido.*/
            SLEmp1 = Math.Round(SLEmp1 + BnEmp1, 2);
            SLEmp2 = Math.Round(SLEmp2 + BnEmp2, 2);
            SLEmp3 = Math.Round(SLEmp3 + BnEmp3, 2);
            /*Se imprime la información del primer empleado*/
            Console.Write("" +
                "\nEl empleado \"" + NmbEmp1 + "\"\n" +
                "Cuyo cargo es: \"" + CrgEmp1 + "\" ha trabajado por " + HrsTbj1 + " horas\n" +
                "Lo cual le otorga un sueldo base de: $" + SBEmp1 + ", del cuál se descuentan:\n$" +
                ISSSEMP1 + " correspondientes a ISSS, $" + AFPEMP1 + " correspondientes a AFP y\n$" +
                RENTAEmp1 + " correspondientes a RENTA; quedando un sueldo líquido de " + SLEmp1);
            if (Bono == 1) { Console.Write("\nCantidad que incluye un bono por $" + BnEmp1); }
            Console.Write(".\n");
            /*Se imprime la información del segundo empleado*/
            Console.Write("" +
                "\nEl empleado \"" + NmbEmp2 + "\"\n" +
                "Cuyo cargo es: \"" + CrgEmp2 + "\" ha trabajado por " + HrsTbj2 + " horas\n" +
                "Lo cual le otorga un sueldo base de: $" + SBEmp2 + ", del cuál se descuentan:\n$" +
                ISSSEMP2 + " correspondientes a ISSS, $" + AFPEMP2 + " correspondientes a AFP y\n$" +
                RENTAEmp2 + " correspondientes a RENTA; quedando un sueldo líquido de " + SLEmp2);
            if (Bono == 1) { Console.Write("\nCantidad que incluye un bono por $" + BnEmp2); }
            Console.Write(".\n");
            /*Se imprime la información del tercer empleado*/
            Console.Write("" +
                "\nEl empleado \"" + NmbEmp3 + "\"\n" +
                "Cuyo cargo es: \"" + CrgEmp3 + "\" ha trabajado por " + HrsTbj3 + " horas\n" +
                "Lo cual le otorga un sueldo base de: $" + SBEmp3 + ", del cuál se descuentan:\n$" +
                ISSSEMP3 + " correspondientes a ISSS, $" + AFPEMP3 + " correspondientes a AFP y\n$" +
                RENTAEmp3 + " correspondientes a RENTA; quedando un sueldo líquido de " + SLEmp3);
            if (Bono == 1) { Console.Write("\nCantidad que incluye un bono por $" + BnEmp3); }
            Console.Write(".\n");
            /*Se evalúa cuál empleado gana más*/
            if (SLEmp1 > SLEmp2 && SLEmp2 > SLEmp3)
            {
                Console.WriteLine("\nEl empleado \"" + NmbEmp1 + "\" gana más.");
            }
            else if (SLEmp2 > SLEmp3)
            {
                Console.WriteLine("\nEl empleado \"" + NmbEmp2 + "\" gana más.");
            }
            else
            {
                Console.WriteLine("\nEl empleado \"" + NmbEmp3 + "\" gana más.");
            }
            /*Se evalúa cuál empleado gana menos*/
            if (SLEmp1 < SLEmp2 && SLEmp2 < SLEmp3)
            {
                Console.WriteLine("\nEl empleado \"" + NmbEmp1 + "\" gana menos.");
            }
            else if (SLEmp2 < SLEmp3)
            {
                Console.WriteLine("\nEl empleado \"" + NmbEmp2 + "\" gana menos.");
            }
            else
            {
                Console.WriteLine("\nEl empleado \"" + NmbEmp3 + "\" gana menos.");
            }
            if (SLEmp1 > 300)
                GP300++;
            if (SLEmp2 > 300)
                GP300++;
            if (SLEmp3 > 300)
                GP300++;
            Console.WriteLine("\nHay " + GP300 + " empleado(s) que gana(n) más de $300.");
            if (Bono == 0)
                Console.WriteLine("\n¡NO HAY BONOS!");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}