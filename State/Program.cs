using System;

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string cOpcionConfiguracion = string.Empty;
            string cOpcionEdoCambio = string.Empty;
            string cEstadoInicial = string.Empty;
            string cRespuesta = string.Empty;
            Menu menu = new Menu();

            cOpcionConfiguracion = menu.PrepararMenuConfiguracion();
            menu.PrepararMenuCambio(cOpcionConfiguracion);
            cRespuesta = menu.PrepararMenuConfirmacion(cOpcionConfiguracion);

            while (true)
            {
                switch (cRespuesta)
                {
                    case "1":
                        cOpcionEdoCambio = menu.PrepararMenuCambio(cOpcionConfiguracion);
                        cRespuesta = menu.PrepararMenuConfirmacion(cOpcionConfiguracion);
                        break;
                    case "2":
                        cOpcionConfiguracion = menu.PrepararMenuConfiguracion();
                        menu.PrepararMenuCambio(cOpcionConfiguracion);
                        cRespuesta = menu.PrepararMenuConfirmacion(cOpcionConfiguracion);
                        break;
                    case "3":
                        Environment.Exit(-1);
                        break;
                }
            }
        }
    }

    public class Menu
    {
        public string PrepararMenuConfiguracion()
        {
            string cNombreEdoInicial = string.Empty;
            string cOpcionEdoInicial = string.Empty;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("CONFIGURAR EL ESTADO DE LA ALARMA.");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Configure el estado inicial de la alarma:");
            Console.WriteLine("1. Activada.");
            Console.WriteLine("2. Desactivada.");
            Console.Write("Escribe una opción: ");
            cOpcionEdoInicial = Console.ReadLine();
            cNombreEdoInicial = ObtenerNombreEstadoInicial(cOpcionEdoInicial);
            Console.WriteLine($"===> El estado de la alarma se configuró como: {cNombreEdoInicial.ToUpper()}.");
            Console.Write("\n");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"CAMBIAR EL ESTADO INICIAL DE LA ALARMA {cNombreEdoInicial.ToUpper()}.");
            Console.WriteLine("----------------------------------------------------");

            return cOpcionEdoInicial;
        }

        public string PrepararMenuCambio(string _cOpcionEdoInicial)
        {
            string cNombreEdoInicial = string.Empty;
            string cMensaje = string.Empty;
            string cOpcionEdoCambio = string.Empty;
            Client client = new Client();

            cNombreEdoInicial = ObtenerNombreEstadoInicial(_cOpcionEdoInicial);
            Console.WriteLine($"Cambie el estado de la alarma {cNombreEdoInicial.ToUpper()} por:");
            Console.WriteLine("1. Activada");
            Console.WriteLine("2. Desactivada");
            Console.Write("Escribe una opción: ");
            cOpcionEdoCambio = Console.ReadLine();
            cMensaje = client.SolicitarCambioEstadoAlarma(_cOpcionEdoInicial, cOpcionEdoCambio);
            Console.Write($"===> {cMensaje}");
            Console.WriteLine("\n");

            return cOpcionEdoCambio;
        } 

        public string PrepararMenuConfirmacion(string _cOpcionEdoInicial)
        {
            string cNombreEdoInicial = string.Empty;
            string cOpcionConfirmacion = string.Empty;

            cNombreEdoInicial = ObtenerNombreEstadoInicial(_cOpcionEdoInicial);
            Console.WriteLine($"¿Continuar con la misma configuración de la alarma? (Estado inicial: {cNombreEdoInicial.ToUpper()})");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            Console.WriteLine("3. Salir");
            Console.Write("Escribe una opción: ");
            cOpcionConfirmacion = Console.ReadLine();
            Console.Write("\n");

            return cOpcionConfirmacion;
        }

        public string ObtenerNombreEstadoInicial(string _cOpcionEstadoConfiguracion)
        {
            string cEstadoInicial = string.Empty;

            switch (_cOpcionEstadoConfiguracion)
            {
                case "1":
                    cEstadoInicial = "Activada";
                    break;
                case "2":
                    cEstadoInicial = "Desactivada";
                    break;
            }

            return cEstadoInicial;
        }
    }
}

