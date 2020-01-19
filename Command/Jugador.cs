namespace Command
{
    public class Jugador //Invoker.
    {
        private IComandoJuego IEjecutarAccionJuego;

        public void AsignarAccionJuego(IComandoJuego _IEjecutarAccionJuego)
        {
            this.IEjecutarAccionJuego = _IEjecutarAccionJuego;
        }

        public void EjecutarComando()
        {
            this.IEjecutarAccionJuego.EjecutarComando();
        }
    }
}
