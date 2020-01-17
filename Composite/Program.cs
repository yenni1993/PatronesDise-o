using System;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("********** PATRÓN COMPOSITE **********");
            Console.Write("\n");
            client.ObtenerSaldoTotal();
            Console.ReadLine();
        }
    }
}
