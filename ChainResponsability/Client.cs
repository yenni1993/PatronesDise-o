namespace ChainResponsability
{
    public class Client
    {
        public void Main(int _iMontoCompra, string _cNombreProducto)
        {
            bool lEsMontoCorrecto = false;
            IManejador ICoordinador = new Coordinador();
            IManejador IGerente = new Gerente();
            IManejador ISudirector = new Subdirector();
            IManejador IDirector = new Director();

            lEsMontoCorrecto = ICoordinador.AutorizarCompra(_iMontoCompra);


            ICoordinador.setNext(IGerente);
            IGerente.setNext(ISudirector);
            ISudirector.setNext(IDirector);

        }
    }
}
