using Adaptador.Interfaces;
using System;

namespace Adaptador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("************** PATRÓN ADAPTADOR **************");
            Console.Write("\n");
            client.BuscarListaSucursales();
            Console.ReadLine();
        }
    }
}
