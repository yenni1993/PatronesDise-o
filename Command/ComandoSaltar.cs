namespace Command
{
    public class ComandoSaltar : IComandoJuego
    {
        private Personaje oPersonaje;

        public ComandoSaltar(Personaje _oPersonaje)
        {
            this.oPersonaje = _oPersonaje;
        }

        public string EjecutarComando()
        {
            return $"{this.oPersonaje.cNombre} SALTANDO con velocidad de {this.oPersonaje.iPotencia}";
        }
    }
}
