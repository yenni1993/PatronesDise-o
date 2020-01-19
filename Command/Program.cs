using System;

namespace Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            Personaje oPersonaje = new Personaje();
            Cliente oCliente = new Cliente();
            Console.WriteLine("****************************** PATRÓN: COMANDO ******************************");
            Console.Write("\n");
            Console.WriteLine("PERSONAJE:");
            Console.WriteLine("1. Guerrero de Clase Baja");
            Console.WriteLine("2. Guerrero de Clase Media");
            Console.WriteLine("3. Guerrero de Clase Alta");
            Console.Write("Escribe una opción: ");
            oPersonaje.cTipo = Console.ReadLine();
            Console.Write("Escribe el nombre del personaje: ");
            oPersonaje.cNombre = Console.ReadLine();
            Console.Write("\n");

            do
            {
                Console.Write("\n");
                Console.WriteLine("ACCIONES:");
                Console.WriteLine("1. Caminar");
                Console.WriteLine("2. Saltar");
                Console.WriteLine("3. Golpear");
                Console.WriteLine("4. Disparar Pistola");

                if (!oPersonaje.lEsObtenidoLanzaGranada)
                {
                    Console.WriteLine("5. Conseguir Lanza Granadas");
                }
                else
                {
                    Console.WriteLine("5. Utilizar Lanza Granadas");                    
                }

                if (!oPersonaje.lEsObtenidoRiflePlasma)
                {
                    Console.WriteLine("6. Conseguir Rifle de Plasma");
                }
                else
                {
                    Console.WriteLine("6. Utilizar Rifle de Plasma");
                }

                Console.Write("Escribe una opción: ");
                oPersonaje.cAccion = Console.ReadLine();

                switch (oPersonaje.cTipo)
                {
                    case "1":
                        oPersonaje.iPotencia = 10;
                        break;
                    case "2":
                        oPersonaje.iPotencia = 20;
                        break;
                    case "3":
                        oPersonaje.iPotencia = 30;
                        break;
                }
                oCliente.IniciarJuego(oPersonaje);

                switch (oPersonaje.cAccion)
                {
                    case "5":
                        oPersonaje.lEsObtenidoLanzaGranada = true;
                        break;
                    case "6":
                        oPersonaje.lEsObtenidoRiflePlasma = true;
                        break;
                }

                Console.ReadLine();
            }
            while (!oPersonaje.cAccion.Equals("7"));
        }
    }
}
