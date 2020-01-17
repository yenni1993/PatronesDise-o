namespace State
{
    public class Client
    {
        IEstadoAlarma IEstadoAlarma;
        Alarma alarma;
        string cMensaje = string.Empty;

        public string SolicitarCambioEstadoAlarma(string _cEstadoInicial, string _cEstadoCambio)
        {
            switch (_cEstadoInicial)
            {
                case "1":
                    cMensaje = CambiarEstadoAlarmaActivada(_cEstadoCambio);
                    break;
                case "2":
                    cMensaje = CambiarEstadoAlarmaDesactivada(_cEstadoCambio);
                    break;
            }
            return cMensaje;
        }

        private string CambiarEstadoAlarmaActivada(string _cEstadoAlarma)
        {
            switch (_cEstadoAlarma)
            {
                case "1":
                    IEstadoAlarma = new AlarmaActivada();
                    alarma = new Alarma(IEstadoAlarma);
                    cMensaje = alarma.ActivarAlarma();
                    break;
                case "2":
                    IEstadoAlarma = new AlarmaActivada();
                    alarma = new Alarma(IEstadoAlarma);
                    cMensaje = alarma.InactivarAlarma();
                    break;
            }
            return cMensaje;
        }

        private string CambiarEstadoAlarmaDesactivada(string _cEstadoAlarma)
        {
            switch (_cEstadoAlarma)
            {
                case "1":
                    IEstadoAlarma = new AlarmaDesactivada();
                    alarma = new Alarma(IEstadoAlarma);
                    cMensaje = alarma.ActivarAlarma();
                    break;
                case "2":
                    IEstadoAlarma = new AlarmaDesactivada();
                    alarma = new Alarma(IEstadoAlarma);
                    cMensaje = alarma.InactivarAlarma();
                    break;
            }
            return cMensaje;
        }
    }
}
