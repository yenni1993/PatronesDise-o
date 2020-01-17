using System;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cEmpresa = string.Empty;
            string cTipoEnvio = string.Empty;
            Client client = new Client();
            Console.WriteLine("Empresas de Mensajerías");
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione una empresa de mensajería:");
            Console.WriteLine("1. Empresa DHL");
            Console.WriteLine("2. Empresa Estafeta");
            Console.WriteLine("3. Empresa Fedex");
            cEmpresa = Console.ReadLine();
            //Console.WriteLine("Seleccione el tipo de envío:");
            //Console.WriteLine("1. Avión");
            //Console.WriteLine("2. Barco");
            //Console.WriteLine("3. Tren");
            //cTipoEnvio = Console.ReadLine();
            client.RealizarMensajeria(cEmpresa, cTipoEnvio);
            Console.ReadLine();

        }
    }
}
