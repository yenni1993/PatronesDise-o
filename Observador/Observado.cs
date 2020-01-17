using System.Collections.Generic;

namespace Observador
{
    public class Observado
    {
        private List<IObservador> lstIObservador;

        public string Suscribir(Observador observador)
        {
            string cAlojar = $"Alojar código {observador}";
            Notificar(observador);
            return cAlojar;
        }

        public string Notificar(Observador observador)
        {
            string cNotificar = $"Notificar código {observador}";
            lstAlojarCodigo.Add(cNotificar);
            return cNotificar;
        }

        public string EnviarCorreoNotificacion()
        {
            string cEnviar = "Enviar correo de notificación";
            lstAlojarCodigo.Add(cEnviar);
            return cEnviar;
        }
    }
}
