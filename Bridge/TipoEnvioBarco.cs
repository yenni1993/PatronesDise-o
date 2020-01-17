namespace Bridge
{
    public class TipoEnvioBarco : ITipoEnvio
    {
        public string EnviarPaquete()
        {
            return "Enviar paquete en Barco";
        }

        public string ProcesarEntrega()
        {
            return "Procesar entrega en Barco";
        }

        public string CargarPedido()
        {
            return "Procesar envío en Barco";
        }
    }
}
