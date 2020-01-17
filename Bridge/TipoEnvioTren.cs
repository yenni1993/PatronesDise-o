namespace Bridge
{
    public class TipoEnvioTren : ITipoEnvio
    {
        public string EnviarPaquete()
        {
            return "Enviar paquete en Tren";
        }

        public string ProcesarEntrega()
        {
            return "Procesar entrega en Tren";
        }

        public string CargarPedido()
        {
            return "Procesar envío en Tren";
        }
    }
}
