namespace ChainResponsability
{
    public class Subdirector : IManejador
    {
        public string handle()
        {
            throw new System.NotImplementedException();
        }

        public string setNext(IManejador _IManejador)
        {
            throw new System.NotImplementedException();
        }

        public bool AutorizarCompra(int _iMontoCapturado)
        {
            bool lEsMontoCorrecto = false;

            if (_iMontoCapturado > 10000 && _iMontoCapturado <= 15000)
            {
                lEsMontoCorrecto = true;
            }

            return lEsMontoCorrecto;
        }
    }
}
