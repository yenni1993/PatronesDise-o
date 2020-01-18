using System;

namespace ChainResponsability
{
    public class Client
    {
        public void AutorizarSolicitudCompra(DatosCompra _oDatosCompra)
        {
            string cResultado = string.Empty;
            IManejador ICoordinador = new Coordinador();
            IManejador IGerente = new Gerente();
            IManejador ISudirector = new Subdirector();
            IManejador IDirector = new Director();

            ICoordinador.AsignarSiguiente(IGerente);
            IGerente.AsignarSiguiente(ISudirector);
            ISudirector.AsignarSiguiente(IDirector);

            cResultado = ICoordinador.AutorizarSolicitudCompra(_oDatosCompra);
            Console.WriteLine($"===> {cResultado}");
        }
    }
}
