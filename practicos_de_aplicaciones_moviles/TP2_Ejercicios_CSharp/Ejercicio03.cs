using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Ejercicios_CSharp
{
    internal class Ejercicio03
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== CALCULADORA DE IMC ===\n");

            double peso;
            while (true)
            {
                Console.Write("Ingresa tu peso (kg): ");
                string? input1 = Console.ReadLine();
                if (double.TryParse(input1, out peso)) break;
                Console.WriteLine("Entrada no válida. Intenta de nuevo.");
            }

            double altura;
            while (true)
            {
                Console.Write("Ejemplo: 1,75\n");
                Console.Write("Ingresa tu altura (m): ");
                string? input1 = Console.ReadLine();
                if (double.TryParse(input1, out altura)) break;
                Console.WriteLine("Entrada no válida. Intenta de nuevo.");
            }

            // Calcular IMC
            double imc = peso / (altura * altura);

            // Determinar clasificación
            string clasificacion;
            if (imc < 18.5)
                clasificacion = "Bajo peso";
            else if (imc < 25)
                clasificacion = "Normal";
            else if (imc < 30)
                clasificacion = "Sobrepeso";
            else
                clasificacion = "Obesidad";

            // Mostrar resultado
            Console.WriteLine($"\nTu IMC es: {imc:F2}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }
    }
}
