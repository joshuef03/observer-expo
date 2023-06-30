// Clase principal que contiene el escenario y las condiciones mencionadas
using Observer;

public class Program
{
    public static void Main(string[] args)
    {
        // Creación de los cursos
        Curso baseDatos = new Curso { Nombre = "Base de Datos" };
        Curso inteligenciaArtificial = new Curso { Nombre = "Inteligencia Artificial" };
        Curso ecuacionesDiferenciales = new Curso { Nombre = "Ecuaciones Diferenciales" };
        Curso interfazHumanoMaquina = new Curso { Nombre = "Interfaz Humano-Máquina" };
        Curso ciberseguridad = new Curso { Nombre = "Ciberseguridad" };

        // Creación de los observadores
        Observador julian = new Observador { Nombre = "Julian" };
        Observador rodrigo = new Observador { Nombre = "Rodrigo" };
        Observador jinx = new Observador { Nombre = "Jinx" };
        Observador rey = new Observador { Nombre = "Rey" };
        Observador carmen = new Observador { Nombre = "Carmen" };
        Observador hotaru = new Observador { Nombre = "Hotaru" };
        Observador andres = new Observador { Nombre = "Andres" };
        Observador ryan = new Observador { Nombre = "Ryan" };

        // Suscripción de los observadores a los cursos correspondientes
        ecuacionesDiferenciales.AgregarObservador(julian);
        ecuacionesDiferenciales.AgregarObservador(andres);
        ecuacionesDiferenciales.AgregarObservador(rodrigo);
        ecuacionesDiferenciales.AgregarObservador(rodrigo);
        inteligenciaArtificial.AgregarObservador(jinx);
        interfazHumanoMaquina.AgregarObservador(jinx);
        ciberseguridad.AgregarObservador(jinx);
        inteligenciaArtificial.AgregarObservador(rey);
        interfazHumanoMaquina.AgregarObservador(rey);
        baseDatos.AgregarObservador(carmen);
        ciberseguridad.AgregarObservador(carmen);
        interfazHumanoMaquina.AgregarObservador(hotaru);
        baseDatos.AgregarObservador(andres);
        inteligenciaArtificial.AgregarObservador(andres);
        inteligenciaArtificial.AgregarObservador(ryan);
        ecuacionesDiferenciales.AgregarObservador(ryan);
        interfazHumanoMaquina.AgregarObservador(ryan);
        ciberseguridad.AgregarObservador(ryan);

        // Simulación de las condiciones a través del tiempo
        Console.WriteLine("Semana 1:");
        interfazHumanoMaquina.AgregarObservador(hotaru);
        interfazHumanoMaquina.NotificarNuevaSuscripcion(hotaru);

        Console.WriteLine("");
        Console.WriteLine("Semana 2:");
        baseDatos.Notificar("Se han agregado trabajos");
        inteligenciaArtificial.Notificar("Se han agregado trabajos");
        ecuacionesDiferenciales.Notificar("Se han agregado trabajos");

        Console.WriteLine("");
        Console.WriteLine("Semana 2:");
        ecuacionesDiferenciales.Notificar("Entrega de trabajos");

        Console.WriteLine("");
        Console.WriteLine("Semana 3:");
        interfazHumanoMaquina.Notificar("Invitación a seminario");
        ciberseguridad.Notificar("Invitación a seminario");

        Console.WriteLine("");
        Console.WriteLine("Semana 4:");
        baseDatos.Notificar("Entrega de trabajos");
        inteligenciaArtificial.Notificar("Entrega de trabajos");

        Console.WriteLine("");
        Console.WriteLine("Semana 5:");
        ecuacionesDiferenciales.EliminarObservador(julian);
        ecuacionesDiferenciales.NotificarRetiroSuscripcion(julian);
        ecuacionesDiferenciales.EliminarObservador(rodrigo);
        ecuacionesDiferenciales.NotificarRetiroSuscripcion(rodrigo);

        Console.WriteLine("");
        Console.WriteLine("Semana 6:");
        interfazHumanoMaquina.Notificar("Se ha agregado una prueba");
        ciberseguridad.Notificar("Se ha agregado una prueba");
        baseDatos.Notificar("Se han agregado trabajos");
        interfazHumanoMaquina.Notificar("Se han agregado trabajos");

        Console.WriteLine("");
        Console.WriteLine("Semana 8:");
        inteligenciaArtificial.Notificar("Invitación a seminario");

        Console.WriteLine("");
        Console.WriteLine("Semana 9:");
        baseDatos.Notificar("Entrega de trabajos");
        interfazHumanoMaquina.Notificar("Entrega de trabajos");

        Console.WriteLine("");
        Console.WriteLine("Semana 11:");
        ciberseguridad.Notificar("Invitación a seminario");

        Console.WriteLine("");
        Console.WriteLine("Semana 12:");
        baseDatos.Notificar("Notificación por feriado");
        inteligenciaArtificial.Notificar("Notificación por feriado");
        ecuacionesDiferenciales.Notificar("Notificación por feriado");
        interfazHumanoMaquina.Notificar("Notificación por feriado");
        ciberseguridad.Notificar("Notificación por feriado");

        Console.WriteLine("");
        Console.WriteLine("Semana 13:");
        baseDatos.Notificar("Se ha agregado un trabajo final");
        inteligenciaArtificial.Notificar("Se ha agregado un trabajo final");
        ecuacionesDiferenciales.Notificar("Se ha agregado un trabajo final");
        interfazHumanoMaquina.Notificar("Se ha agregado un trabajo final");
        ciberseguridad.Notificar("Se ha agregado un trabajo final");

        Console.WriteLine("");
        Console.WriteLine("Semana 14:");
        baseDatos.Notificar("Entrega de trabajo final");
        inteligenciaArtificial.Notificar("Entrega de trabajo final");
        ecuacionesDiferenciales.Notificar("Entrega de trabajo final");
        interfazHumanoMaquina.Notificar("Entrega de trabajo final");
        ciberseguridad.Notificar("Entrega de trabajo final");

        Console.WriteLine("");
        Console.WriteLine("Fin del semestre");

    }
}