namespace State
{
    public class AlarmaActivada : IEstadoAlarma
    {
        Alarma alarma;

        public string DesactivarAlarma()
        {
            string cMensaje = string.Empty;
            AlarmaDesactivada alarmaDesactivada = new AlarmaDesactivada();
            alarma = new Alarma(alarmaDesactivada);
            alarmaDesactivada.AsignarAlarma(alarma);
            alarma.CambiarEstado(alarmaDesactivada);
            cMensaje = "La alarma se desactivó correctamente.";
            return cMensaje;
        }

        string IEstadoAlarma.ActivarAlarma()
        {
            return "La alarma ya se encuentra activada.";
        }

        public void AsignarAlarma(Alarma alarma)
        {
            this.alarma = alarma;
        }
    }
}
