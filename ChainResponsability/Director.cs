namespace ChainResponsability
{
    public class Director : IManejador
    {
        IManejador IManejador;

        public void AsignarSiguiente(IManejador _IManejador)
        {
            this.IManejador = _IManejador;
        }

        public string AutorizarSolicitudCompra(DatosCompra _oDatosCompra)
        {
            string cMensaje = string.Empty;

            if (_oDatosCompra.iPrecioProducto > 15000 && _oDatosCompra.iPrecioProducto <= 50000)
            {
                cMensaje = $"Compra de {_oDatosCompra.cNombreProducto} AUTORIZADA por el Director.";
            }
            else
            {
                cMensaje = $"Compra de {_oDatosCompra.cNombreProducto} RECHAZADA por el Director.";
            }

            return cMensaje;
        }
    }
}
