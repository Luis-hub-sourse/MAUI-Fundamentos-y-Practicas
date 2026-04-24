using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Ejercicios_CSharp
{
    internal class Ejercicio02
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===\n");

            // Pedir temperatura en Celsius
            double celsius;
            while (true)
            {
                Console.Write("Ingresa temperatura en Celsius: ");
                string? input1 = Console.ReadLine();
                if (double.TryParse(input1, out celsius)) break;
                Console.WriteLine("Entrada no válida. Intenta de nuevo.");
            }

            // Conversiones
            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;

            // Mostrar resultados
            Console.WriteLine($"\n{celsius}°C equivale a:");
            Console.WriteLine($"- {fahrenheit:F2}°F (Fahrenheit)");
            Console.WriteLine($"- {kelvin:F2} K (Kelvin)");
        }
    }
}
