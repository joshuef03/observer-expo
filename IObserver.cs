using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Definición de la interfaz IObserver que representa un observador
    public interface IObserver
    {
        void Actualizar(Curso curso, string mensaje);
    }
}
