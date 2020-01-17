namespace State
{
    public class Alarma
    {
        private IEstadoAlarma IEstadoAlarma;

        public Alarma(IEstadoAlarma _IEstadoAlarma)
        {
            IEstadoAlarma = _IEstadoAlarma;
        }

        public void CambiarEstado(IEstadoAlarma _IEstadoAlarma)
        {
            IEstadoAlarma = _IEstadoAlarma;
        }

        public string ActivarAlarma()
        {
            return IEstadoAlarma.ActivarAlarma();
        }

        public string InactivarAlarma()
        {
            return IEstadoAlarma.InactivarAlarma();
        }


    }
}
