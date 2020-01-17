using System;

namespace Observador
{
    public class EjecutarPruebasUnitarias : IAccionCodigo
    {
        public void RealizarAccion()
        {
            Console.WriteLine("Ejecutar pruebas unitarias.");
        }
    }
}
