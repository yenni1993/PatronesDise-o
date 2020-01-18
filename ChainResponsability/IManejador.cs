namespace ChainResponsability
{
    public interface IManejador
    {
        void AsignarSiguiente(IManejador _IManejador);
        string AutorizarSolicitudCompra(DatosCompra _oDatosCompra);
    }
}
