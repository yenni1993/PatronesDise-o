using System;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cId = string.Empty;
            string cImporte = string.Empty;
            CuentaPagarDTO oCuentaPagar = new CuentaPagarDTO();
            Cliente oCliente = new Cliente();

            Console.WriteLine("******************** PATRÓN: DECORADOR ********************");
            Console.Write("\n");
            Console.WriteLine("DATOS DE LA CUENTA POR PAGAR.");
            Console.Write("Escribe el ID de la cuenta por pagar: ");
            cId = Console.ReadLine();
            oCuentaPagar.iId = int.Parse(cId);
            Console.Write("Escribe el importe de la cuenta por pagar: ");
            cImporte = Console.ReadLine();
            oCuentaPagar.dImporte = decimal.Parse(cImporte);
            Console.Write("Escribe la naturaleza de la cuenta por pagar (Cargo/Abono): ");
            oCuentaPagar.cNaturaleza = Console.ReadLine();
            Console.Write("Escribe el nombre del usuario: ");
            oCuentaPagar.cNombreUsuario = Console.ReadLine();

            oCliente.EjecutarGuardado(oCuentaPagar);
            Console.ReadLine();
        }
    }
}
