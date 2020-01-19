namespace Command
{
    public class ComandoConseguirRiflePlasma : IComandoJuego
    {
        private Personaje oPersonaje;
        private ReceptorRiflePlasma oReceptor;

        public ComandoConseguirRiflePlasma(Personaje _oPersonaje, ReceptorRiflePlasma _oReceptor)
        {
            this.oPersonaje = _oPersonaje;
            this.oReceptor = _oReceptor;
        }

        public string EjecutarComando()
        {
            string cAccionArma = string.Empty;
            cAccionArma = this.oReceptor.ConseguirArma(this.oPersonaje);
            return cAccionArma;
        }
    }
}
