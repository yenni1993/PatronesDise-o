namespace Bridge
{
    public class TipoEnvioAvion : ITipoEnvio
    {
        public string EnviarPaquete()
        {
            return "Enviar paquete en Avión";
        }

        public string ProcesarEntrega()
        {
            return "Procesar entrega en Avión";
        }

        public string CargarPedido()
        {
            return "Cargar pedido en Avión";
        }
    }
}
