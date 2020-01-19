namespace Command
{
    public class ComandoDispararPistola : IComandoJuego
    {
        private Personaje oPersonaje;
        private ReceptorLanzaGranada oReceptor;

        public ComandoDispararPistola(Personaje _oPersonaje)
        {
            this.oPersonaje = _oPersonaje;
            this.oReceptor = new ReceptorLanzaGranada();
        }

        public string EjecutarComando()
        {
            return $"{this.oPersonaje.cNombre} DISPARAR PISTOLA con velocidad de {this.oPersonaje.iPotencia}";
        }
    }
}
