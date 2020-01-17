namespace Bridge
{
    public class EmpresaFedex : IEmpresaMensajeria
    {
        ITipoEnvio ITipoEnvio;

        public EmpresaFedex(ITipoEnvio _ITipoEnvio)
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
