namespace Command
{
    public class ReceptorLanzaGranada
    {
        public string ConseguirArma(Personaje _oPersonaje)
        {
            string cResultado = string.Empty;

            if (_oPersonaje.lEsObtenidoLanzaGranada)
            {
                cResultado = $"{_oPersonaje.cNombre} UTILIZANDO LANZA GRANADA con velocidad de {_oPersonaje.iPotencia}";
            }
            else
            {
                cResultado = $"El LANZA GRANADA ya puede ser utilizada por el personaje {_oPersonaje.cNombre}";
            }

            return cResultado;
        }
    }
}
