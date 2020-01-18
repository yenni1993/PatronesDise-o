using System;

namespace ChainResponsability
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cResultado = string.Empty;
            string cOpcionConfirmacion = string.Empty;
            Client oCliente = new Client();
            DatosCompra oDatosCompra = new DatosCompra();
            Menu oMenu = new Menu();

            Console.WriteLine("****************************** PATRÓN: CADENA DE RESPONSABILIDAD ******************************");
            Console.Write("\n");
            oMenu.PrepararMenuInformacion();
            oDatosCompra = oMenu.PrepararMenuDatosCompra();
            oCliente.AutorizarSolicitudCompra(oDatosCompra);
            cResultado = oMenu.PrepararMenuConfirmacion();

            while (true)
            {
                switch (cResultado)
                {
                    case "1":
                        oDatosCompra = oMenu.PrepararMenuDatosCompra();
                        oCliente.AutorizarSolicitudCompra(oDatosCompra);
                        cResultado = oMenu.PrepararMenuConfirmacion();
                        break;
                    case "2":
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("La opción es incorrecta.");
                        cResultado = oMenu.PrepararMenuConfirmacion();
                        break;
                }
            }
        }
    }
}

