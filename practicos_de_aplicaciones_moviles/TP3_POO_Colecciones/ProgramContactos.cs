using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_POO_Colecciones
{
    public class ProgramContactos
    {
        public void UsoContactos()
        {
            var agenda = new AgendaContactos();
            agenda.Agregar(new Contacto
            {
                Nombre = "Juan",
                Telefono =
            "11-2345-6789",
                Email = "juan@email.com"
            });
            agenda.Agregar(new Contacto
            {
                Nombre = "María",
                Telefono =
            "11-9876-5432",
                Email = "maria@email.com"
            });
            agenda.Agregar(new Contacto
            {
                Nombre = "Pedro",
                Telefono =
            "11-5555-1234",
                Email = "pedro@email.com"
            });
            agenda.MostrarTodos();
            var encontrado = agenda.Buscar("María");
            if (encontrado != null)
                Console.WriteLine($"\nEncontrado: {encontrado.Nombre} - { encontrado.Telefono}");
            agenda.Eliminar("Pedro");
            agenda.MostrarTodos();
        }
    }
}
