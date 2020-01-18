namespace ChainResponsability
{
    public class Subdirector : IManejador
    {
        IManejador IManejador;

        public void AsignarSiguiente(IManejador _IManejador)
        {
            this.IManejador = _IManejador;
        }

        public string AutorizarSolicitudCompra(DatosCompra _oDatosCompra)
        {
            string cMensaje = string.Empty;

            if (_oDatosCompra.iPrecioProducto > 10000 && _oDatosCompra.iPrecioProducto <= 15000)
            {
                cMensaje = $"Compra de {_oDatosCompra.cNombreProducto} AUTORIZADA por el Subdirector";
            }
            else
            {
                cMensaje = this.IManejador.AutorizarSolicitudCompra(_oDatosCompra);
            }

            return cMensaje;
        }
    }
}
