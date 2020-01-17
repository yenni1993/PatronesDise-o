namespace State
{
    public class AlarmaDesactivada : IEstadoAlarma
    {
        Alarma alarma;

        public string ActivarAlarma()
        {
            string cMensaje = string.Empty;
            AlarmaActivada alarmaActivada = new AlarmaActivada();
            alarma = new Alarma(alarmaActivada);
            alarmaActivada.AsignarAlarma(alarma);
            alarma.CambiarEstado(alarmaActivada);
            cMensaje = "La alarma se activó correctamente.";
            return cMensaje;
        }

        string IEstadoAlarma.DesactivarAlarma()
        {
            return "La alarma ya se encuentra desactivada.";
        }

        public void AsignarAlarma(Alarma _alarma)
        {
            this.alarma = _alarma;
        }
    }
}
