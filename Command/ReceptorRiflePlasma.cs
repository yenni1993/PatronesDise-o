namespace Command
{
    public class ReceptorRiflePlasma
    {
        public string ConseguirArma(Personaje _oPersonaje)
        {
            string cResultado = string.Empty;

            if (_oPersonaje.lEsObtenidoLanzaGranada)
            {
                cResultado = $"{_oPersonaje.cNombre} UTILIZANDO RIFLE DE PLASMA con velocidad de {_oPersonaje.iPotencia}";
            }
            else
            {
                cResultado = $"El RIFLE DE PLASMA ya puede ser utilizada por el personaje {_oPersonaje.cNombre}";
            }

            return cResultado;
        }
    }
}
