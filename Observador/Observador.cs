namespace Observador
{
    public class Observador : IObservador
    {
        public string CompilarCodigo()
        {
            return "Compilar código";
        }

        public string EjecutarPruebasUnitarias()
        {
            return "Ejecutar pruebas unitarias";
        }

        public string InstalarVersion()
        {
            return "Instalar versión";
        }
    }
}
