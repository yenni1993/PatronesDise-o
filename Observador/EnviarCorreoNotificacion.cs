using System;

namespace Observador
{
    public class EnviarCorreoNotificacion : IAccionCodigo
    {
        public void RealizarAccion()
        {
            Console.WriteLine("Enviar correo de notificación.");
        }
    }
}
