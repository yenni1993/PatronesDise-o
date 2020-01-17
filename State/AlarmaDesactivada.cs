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
            cMensaje = "La alarma se activó";
            return cMensaje;
        }

        string IEstadoAlarma.InactivarAlarma()
        {
            return "La alarma ya se encuentra inactivada";
        }

        public void AsignarAlarma(Alarma _alarma)
        {
            this.alarma = _alarma;
        }
    }
}
