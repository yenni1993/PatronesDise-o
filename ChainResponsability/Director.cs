namespace ChainResponsability
{
    public class Director : IManejador
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

            if (_iMontoCapturado > 15000 && _iMontoCapturado <= 50000)
            {
                lEsMontoCorrecto = true;
            }

            return lEsMontoCorrecto;
        }
    }
}
