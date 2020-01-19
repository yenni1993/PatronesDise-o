namespace Command
{
    public class ComandoGolpear : IComandoJuego
    {
        private Personaje oPersonaje;

        public ComandoGolpear(Personaje _oPersonaje)
        {
            this.oPersonaje = _oPersonaje;
        }

        public string EjecutarComando()
        {
            return $"{this.oPersonaje.cNombre} GOLPEANDO con velocidad de {this.oPersonaje.iPotencia}";
        }
    }
}
