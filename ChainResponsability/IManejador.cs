namespace ChainResponsability
{
    public interface IManejador
    {
        string AutorizarCompra(int _iMontoCapturado);
        string DenegarCompra(IManejador _IManejador);
    }
}
