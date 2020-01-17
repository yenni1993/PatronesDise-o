namespace Bridge
{
    public class EmpresaEstafeta : IEmpresaMensajeria
    {
        ITipoEnvio ITipoEnvio;

        public EmpresaEstafeta(ITipoEnvio _ITipoEnvio)
        {
            this.ITipoEnvio = _ITipoEnvio;
        }

        public string EntregarPaquete()
        {
            return this.ITipoEnvio.ProcesarEntrega();
        }

        public string EnviarPaquete()
        {
            return this.ITipoEnvio.EnviarPaquete();
        }

        public string RecogerPedido()
        {
            return this.ITipoEnvio.CargarPedido();
        }
    }
}
