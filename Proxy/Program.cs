using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool lTieneAcceso = false;
            string cRespuesta = string.Empty;
            ICoche ICoche = new ServicioCoche();
            ICoche IProxy = new Proxy(ICoche);
            Cliente oCliente = new Cliente();

            Console.WriteLine("*********************** PATRÓN PROXY ***********************");
            Console.Write("\n");

            while (true)
            {
                Console.WriteLine("¿La llave introducida cuenta con un código correcto? (Si/No)");
                cRespuesta = Console.ReadLine();

                switch (cRespuesta.ToUpper())
                {
                    case "SI":
                        lTieneAcceso = true;
                        break;
                    case "NO":
                        lTieneAcceso = false;
                        break;
                }

                oCliente.ArrancarCoche(IProxy, lTieneAcceso);
                Console.ReadLine();
            }
        }
    }
}
