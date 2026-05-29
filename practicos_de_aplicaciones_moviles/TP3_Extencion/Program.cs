using System;
using TP3_POO_Colecciones;

namespace TP3_Extencion
{
    internal class Program
    {
        static void Main()
        {
            var biblioteca = new ProgramBliblioteca();
            var contactos = new ProgramContactos();
            var linq = new LINQ();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=== MENÚ ===");
                Console.WriteLine("1. Acceder a la Biblioteca");
                Console.WriteLine("2. Acceder a Contactos");
                Console.WriteLine("3. Acceder a Estudiantes");
                Console.WriteLine("4. Salir");

                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        biblioteca.UsoBlibioteca();

                        break;
                    case "2":
                        contactos.UsoContactos();

                        break;
                    case "3":
                        linq.UsoLINQ();

                        break;
                    case "4":
                        Console.WriteLine("¡Hasta luego!");
                        continuar = false;

                        break;
                    default:

                        Console.WriteLine("Opción inválida");

                        break;
                }
            }
        }
    }
}