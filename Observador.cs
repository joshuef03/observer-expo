using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Implementación de la clase Observador que representa a un observador
    public class Observador : IObserver
    {
        public string? Nombre { get; set; }

        // Método para recibir las notificaciones y mostrar el mensaje
        public void Actualizar(Curso curso, string mensaje)
        {
            Console.WriteLine($"{Nombre} recibió una notificación del curso {curso.Nombre}: {mensaje}");
        }
    }
}
