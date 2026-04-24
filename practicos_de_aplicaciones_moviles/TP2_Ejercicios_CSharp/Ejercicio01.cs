using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Ejercicios_CSharp
{
    public class Ejercicio01
    {
        public static void Ejecutar()
        {
            while (true)
            {
                Console.WriteLine("=== CALCULADORA BÁSICA ===\n");

                // Pedir números
                double num1;
                while (true)
                {
                    Console.Write("Ingresa el primer número: ");
                    string? input1 = Console.ReadLine();
                    if (double.TryParse(input1, out num1)) break;
                    Console.WriteLine("Entrada no válida. Intenta de nuevo.");
                }

                double num2;
                while (true)
                {
                    Console.Write("Ingresa el segundo número: ");
                    string? input2 = Console.ReadLine();
                    if (double.TryParse(input2, out num2)) break;
                    Console.WriteLine("Entrada no válida. Intenta de nuevo.");
                }

                // Realizar operaciones
                double suma = num1 + num2;
                double resta = num1 - num2;
                double multiplicacion = num1 * num2;
                double division = num1 / num2;
                double modulo = num1 % num2;

                // Mostrar resultados
                Console.WriteLine("\nResultados:");
                Console.WriteLine($"{num1} + {num2} = {suma}");
                Console.WriteLine($"{num1} - {num2} = {resta}");
                Console.WriteLine($"{num1} × {num2} = {multiplicacion}");
                Console.WriteLine($"{num1} ÷ {num2} = {division:F2}");
                Console.WriteLine($"{num1} % {num2} = {modulo}");

                int num3;
                while (true)
                {
                    Console.Write("Desea salir? (1. Si  2. No): ");
                    string? input3 = Console.ReadLine();
                    if (int.TryParse(input3, out num3)) break;
                    Console.WriteLine("Entrada no válida. Intenta de nuevo.");
                }
                if (num3 == 1) break; 
            }
        }
    }
}
