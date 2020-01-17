namespace Bridge
{
    public interface ITipoEnvio
    {
        string CargarPedido();
        string EnviarPaquete();
        string ProcesarEntrega();
    }
}
