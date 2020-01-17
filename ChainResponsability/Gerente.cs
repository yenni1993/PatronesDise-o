namespace ChainResponsability
{
    public class Gerente : IManejador
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

            if (_iMontoCapturado > 5000 && _iMontoCapturado <= 10000)
            {
                lEsMontoCorrecto = true;
            }

            return lEsMontoCorrecto;
        }
    }
}
