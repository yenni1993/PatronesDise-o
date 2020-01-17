namespace Bridge
{
    public class EmpresaFedex : IEmpresaMensajeria
    {
        public string EntregarPaquete()
        {
            return "Entregar paquete a la empresa Fedex";
        }

        public string EnviarPaquete()
        {
            return "Enviar paquete a la empresa Fedex";
        }

        public string RecogerPedido()
        {
            return "Recoger pedido de la empresa Fedex";
        }
    }
}
