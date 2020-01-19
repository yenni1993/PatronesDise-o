
namespace Command
{
    public class ComandoCaminar : IComandoJuego
    {
        private Personaje oPersonaje;

        public ComandoCaminar(Personaje _oPersonaje)
        {
            this.oPersonaje = _oPersonaje;
        }
        public string EjecutarComando()
        {
            return $"{this.oPersonaje.cNombre} CAMINANDO con velocidad de {this.oPersonaje.iPotencia}";
        }
    }
}
