using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_POO_Colecciones
{
    public class AgendaContactos
    {
        private Dictionary<string, Contacto> contactos = new Dictionary<string, Contacto>();
        public void Agregar(Contacto contacto)
        {
            contactos[contacto.Nombre.ToLower()] = contacto;
            Console.WriteLine($"Contacto '{contacto.Nombre}' agregado");
        }

        public Contacto Buscar(string nombre)
        {
            if (contactos.ContainsKey(nombre.ToLower()))
                return contactos[nombre.ToLower()];
            return null;
        }
        public void Eliminar(string nombre)
        {
            if (contactos.Remove(nombre.ToLower()))
                Console.WriteLine($"Contacto '{nombre}' eliminado");
            else
                Console.WriteLine("Contacto no encontrado");
        }
        public void MostrarTodos()
        {
            Console.WriteLine($"\n=== AGENDA ({contactos.Count} contactos) === ");
        foreach (var c in contactos.Values.OrderBy(c => c.Nombre))
                Console.WriteLine($" {c.Nombre} | {c.Telefono} | {c.Email}");
        }
    }
}
