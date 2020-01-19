namespace Command
{
    public class ComandoConseguirLanzaGranada : IComandoJuego
    {
        private Personaje oPersonaje;
        private ReceptorLanzaGranada oReceptor;

        public ComandoConseguirLanzaGranada(Personaje _oPersonaje, ReceptorLanzaGranada _oReceptor)
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
