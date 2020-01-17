using System;

namespace Observador
{
    public class CompilarCodigo : IAccionCodigo
    {
        public void RealizarAccion()
        {
            Console.WriteLine("Compilar código.");
        }
    }

}
