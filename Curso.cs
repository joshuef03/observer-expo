using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Definición de la clase Curso que representa un curso del semestre
    public class Curso
    {
        public string? Nombre { get; set; }
        public List<IObserver> Observadores { get; } = new List<IObserver>();

        // Método para agregar un observador al curso
        public void AgregarObservador(IObserver observador)
        {
            Observadores.Add(observador);
        }

        // Método para eliminar un observador del curso
        public void EliminarObservador(IObserver observador)
        {
            Observadores.Remove(observador);
        }

        // Método para notificar a los observadores sobre una publicación del curso
        public void Notificar(string mensaje)
        {
            foreach (var observador in Observadores)
            {
                observador.Actualizar(this, mensaje);
            }
        }
        // Método para notificar que un nuevo observador se ha suscrito a un objeto
        public void NotificarNuevaSuscripcion(Observador observador)
        {
            Console.WriteLine($"Nuevo observador {observador.Nombre} se ha suscrito a {Nombre}");
        }

        // Método para notificar que los observadores han retirado su suscripción
        public void NotificarRetiroSuscripcion(Observador observador)
        {
            Console.WriteLine($"Observador {observador.Nombre} ha retirado su suscripción a {Nombre}");
        }

    }
}
