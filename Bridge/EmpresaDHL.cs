namespace Bridge
{
    public class EmpresaDHL : IEmpresaMensajeria
    {
        ITipoEnvio ITipoEnvio;

        public EmpresaDHL(ITipoEnvio _ITipoEnvio)
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
