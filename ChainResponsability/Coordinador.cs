namespace ChainResponsability
{
    public class Coordinador : IManejador
    {
        IManejador IManejador;

        Coordinador()
        {

        }

        public string AutorizarCompra(int _iMontoCapturado, string _cNombreProducto)
        {
            string cMensaje = string.Empty;

            if(_iMontoCapturado <= 5000)
            {
                cMensaje = $"Compra de {_cNombreProducto} por el Coordinador";
            }
            else
            {
                DenegarCompra(IManejador);
            }

            return cMensaje;
        }

        public string DenegarCompra(IManejador _IManejador)
        {

            string cMensaje = string.Empty;
            return cMensaje;
        }
    }
}
