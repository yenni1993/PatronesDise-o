using System;

namespace Command
{
    public class Cliente
    {
        public void IniciarJuego(Personaje _oPersonaje)
        {
            string cResultado = string.Empty;
            IComandoJuego IComandoJuego;
            Jugador oJugador = new Jugador();

            switch (_oPersonaje.cAccion)
            {
                case "1":                    
                    IComandoJuego = new ComandoCaminar(_oPersonaje);
                    oJugador.AsignarAccionJuego(IComandoJuego);
                    cResultado = IComandoJuego.EjecutarComando();
                    break;
                case "2":
                    IComandoJuego = new ComandoSaltar(_oPersonaje);
                    oJugador.AsignarAccionJuego(IComandoJuego);
                    cResultado = IComandoJuego.EjecutarComando();
                    break;
                case "3":
                    IComandoJuego = new ComandoGolpear(_oPersonaje);
                    oJugador.AsignarAccionJuego(IComandoJuego);
                    cResultado = IComandoJuego.EjecutarComando();
                    break;
                case "4":
                    IComandoJuego = new ComandoDispararPistola(_oPersonaje);
                    oJugador.AsignarAccionJuego(IComandoJuego);
                    cResultado = IComandoJuego.EjecutarComando();
                    break;
                case "5":
                    ReceptorLanzaGranada oReceptorLanzaGranada = new ReceptorLanzaGranada();
                    IComandoJuego = new ComandoConseguirLanzaGranada(_oPersonaje, oReceptorLanzaGranada);
                    oJugador.AsignarAccionJuego(IComandoJuego);
                    cResultado = IComandoJuego.EjecutarComando();
                    break;
                case "6":
                    ReceptorRiflePlasma oReceptorRiflePlasma = new ReceptorRiflePlasma();
                    IComandoJuego = new ComandoConseguirRiflePlasma(_oPersonaje, oReceptorRiflePlasma);
                    oJugador.AsignarAccionJuego(IComandoJuego);
                    cResultado = IComandoJuego.EjecutarComando();
                    break;
            }

            Console.WriteLine($"===> {cResultado}");
        }
    }
}
