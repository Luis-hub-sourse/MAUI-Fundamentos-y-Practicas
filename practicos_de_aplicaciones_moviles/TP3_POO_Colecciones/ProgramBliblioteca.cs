using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_POO_Colecciones
{
    public class ProgramBliblioteca
    {
        public void UsoBlibioteca()
        {
            Biblioteca miBiblioteca = new Biblioteca("Municipal");
            // Agregar libros de ejemplo
            miBiblioteca.AgregarLibro(new Libro(1, "Cien Años de Soledad", "Gabriel García Márquez", 1967, "978-0307474728"));
            miBiblioteca.AgregarLibro(new Libro(2, "El Principito", "Antoine de Saint - Exupéry", 1943, "978 - 0156012195"));
            miBiblioteca.AgregarLibro(new Libro(3, "1984", "George Orwell", 1949, "978-0451524935"));
            miBiblioteca.AgregarLibro(new Libro(4, "Don Quijote", "Miguel de Cervantes", 1605, "978 - 8420412146"));

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=== MENÚ BIBLIOTECA ===");
                Console.WriteLine("1. Ver todos los libros");
                Console.WriteLine("2. Buscar por autor");
                Console.WriteLine("3. Prestar libro");
                Console.WriteLine("4. Devolver libro");
                Console.WriteLine("5. Ver estadísticas");
                Console.WriteLine("6. Salir");

                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        miBiblioteca.MostrarTodosLosLibros();

                        break;
                    case "2":

                        Console.Write("Autor a buscar: ");
                        string autor = Console.ReadLine();
                        var resultados = miBiblioteca.BuscarPorAutor(autor);
                        Console.WriteLine($"Se encontraron {resultados.Count} libros: ");

                        foreach (var libro in resultados)

                            Console.WriteLine($" - {libro.Titulo}");

                        break;
                    case "3":

                        Console.Write("ID del libro a prestar: ");
                        int idPrestar = int.Parse(Console.ReadLine());
                        miBiblioteca.PrestarLibro(idPrestar);

                        break;
                    case "4":

                        Console.Write("ID del libro a devolver: ");
                        int idDevolver = int.Parse(Console.ReadLine());
                        miBiblioteca.DevolverLibro(idDevolver);

                        break;
                    case "5":

                        miBiblioteca.MostrarEstadisticas();

                        break;
                    case "6":

                        continuar = false;
                        Console.WriteLine("¡Hasta luego!");

                        break;
                    default:

                        Console.WriteLine("Opción inválida");

                        break;
                }
            }
        }
    }
}
