using System;

namespace Proxy
{
    public class Cliente
    {
        public void ArrancarCoche(ICoche _ICoche, bool _lTieneAcceso)
        {
            string cResultado = string.Empty;
            cResultado = _ICoche.ArrancarCoche(_lTieneAcceso);
            Console.WriteLine(cResultado);
        }
    }
}
