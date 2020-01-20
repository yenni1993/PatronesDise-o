namespace Proxy
{
    public class Proxy : ICoche
    {
        private ICoche ICoche;

        public Proxy(ICoche _ICoche)
        {
            this.ICoche = _ICoche;
        }

        public string ArrancarCoche(bool _lTieneAcceso)
        {
            string cResultado = string.Empty;

            if (ChecarAcceso(_lTieneAcceso))
            {
                cResultado = this.ICoche.ArrancarCoche(_lTieneAcceso);
            }
            else
            {
                cResultado = "No se pudo arrancar el coche.";
            }
            return cResultado;
        }

        public bool ChecarAcceso(bool _TieneAcceso)
        {
            if (_TieneAcceso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
