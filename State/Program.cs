using System;

namespace State
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cEstadoAlarma = string.Empty;
            string cMensaje = string.Empty;

            Client client = new Client();
            Console.WriteLine("ESTADO DE LA ALARMA");
            Console.WriteLine("Estado Inicial: Activada");
            Console.WriteLine("¿Qué desea hacer con el estado de la alarma?");
            Console.WriteLine("1. Activar");
            Console.WriteLine("2. Desactivar");

            while (true)
            {
                cEstadoAlarma = Console.ReadLine();
                cMensaje = client.SolicitarCambioEstadoAlarma(cEstadoAlarma);
                Console.WriteLine(cMensaje);
                Console.ReadLine();
            }
        }
    }
}
