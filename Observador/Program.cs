using System;

namespace Observador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client cliente = new Client();
            Console.WriteLine("PATRÓN OBSERVADOR");
            Console.WriteLine("----------------------------------");
            cliente.AgregarCodigo();
            cliente.AlojarCodigo();
            Console.ReadLine();
        }
    }
}
