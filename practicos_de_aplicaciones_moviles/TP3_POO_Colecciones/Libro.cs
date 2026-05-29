using System;

namespace TP3_POO_Colecciones
{
    public class Libro
    {
        public Libro(int id, string titulo, string autor, int año, string isbn)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = año;
            ISBN = isbn;
            Disponible = true;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public string ISBN { get; set; }
        public bool Disponible { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"{Id}. {Titulo} - {Autor} ({AñoPublicacion}) ISBN: {ISBN} Estado: {(Disponible ? "Disponible" : "Prestado")}");
        }

        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year - AñoPublicacion;
        }
    }
}
