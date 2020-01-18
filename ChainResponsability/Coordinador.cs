namespace ChainResponsability
{
    public class Coordinador : IManejador
    {
        IManejador IManejador;

        public void AsignarSiguiente(IManejador _IManejador)
        {
            this.IManejador = _IManejador;
        }

        public string AutorizarSolicitudCompra(DatosCompra _oDatosCompra)
        {
            string cMensaje = string.Empty;

            try
            {
                if (_oDatosCompra.iPrecioProducto > 0)
                {
                    if (_oDatosCompra.iPrecioProducto <= 5000)
                    {
                        cMensaje = $"Compra de {_oDatosCompra.cNombreProducto} AUTORIZADA por el Coordinador.";
                    }
                    else
                    {
                        cMensaje = this.IManejador.AutorizarSolicitudCompra(_oDatosCompra);
                    }
                }
                else
                {
                    cMensaje = $"El precio del producto {_oDatosCompra.cNombreProducto} debe ser mayor a cero.";
                }
            }
            catch
            {
                cMensaje = "Ocurrió un error. Favor de verificar.";
            }

            return cMensaje;
        }
    }
}
