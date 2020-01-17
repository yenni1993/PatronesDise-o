using System;

namespace State
{
    public class Client
    {
        public string SolicitarCambioEstadoAlarma(string _cEstadoAlarma)
        {
            IEstadoAlarma IEstadoAlarma;
            Alarma alarma;
            string cMensaje = string.Empty;

            switch (_cEstadoAlarma) {
                case "1": //Activar
                    IEstadoAlarma = new AlarmaActivada();
                    alarma = new Alarma(IEstadoAlarma);
                    cMensaje = alarma.ActivarAlarma();
                    break;
                case "2": //Desactivar
                    IEstadoAlarma = new AlarmaDesactivada();
                    alarma = new Alarma(IEstadoAlarma);
                    cMensaje = alarma.InactivarAlarma();
                    break;
            }

            return cMensaje;
        }
    }
}
