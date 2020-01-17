using System;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cOpcionEmpresa = string.Empty;
            string cRespuesta = string.Empty;
            Client client = new Client();
            Menu menu = new Menu();

            Console.WriteLine("************ PATRÓN BRIDGE ************");
            Console.Write("\n");
            cOpcionEmpresa = menu.PrepararMenu();           
            client.RealizarMensajeria(cOpcionEmpresa);
            cRespuesta = menu.PrepararConfirmacion();

            while (true)
            {
                switch (cRespuesta)
                {
                    case "1":
                        cOpcionEmpresa = menu.PrepararMenu();
                        client.RealizarMensajeria(cOpcionEmpresa);
                        cRespuesta = menu.PrepararConfirmacion();
                        break;
                    case "2":
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("La opción es incorrecta.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }

    public class Menu
    {
        public string PrepararMenu()
        {
            string cOpcionEmpresa = string.Empty;
            
            Console.WriteLine("Empresas de Mensajerías");
            Console.WriteLine("1. Empresa DHL");
            Console.WriteLine("2. Empresa Estafeta");
            Console.WriteLine("3. Empresa Fedex");
            Console.Write("Escribe una opción: ");
            cOpcionEmpresa = Console.ReadLine();
            Console.Write("\n");

            return cOpcionEmpresa;
        }

        public string PrepararConfirmacion()
        {
            string cOpcionConfirmacion = string.Empty;

            Console.Write("\n");
            Console.WriteLine("¿Desea continuar con la operación?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            Console.Write("Escribe una opción: ");
            cOpcionConfirmacion = Console.ReadLine();
            Console.Write("\n");

            return cOpcionConfirmacion;
        }
    }
}
