namespace Bridge
{
    public class EmpresaEstafeta : IEmpresaMensajeria
    {
        public string EntregarPaquete()
        {
            return "Entregar paquete a la empresa Estafeta";
        }

        public string EnviarPaquete()
        {
            return "Enviar paquete a la empresa Estafeta";
        }

        public string RecogerPedido()
        {
            return "Recoger pedido de la empresa Estafeta";
        }
    }
}
