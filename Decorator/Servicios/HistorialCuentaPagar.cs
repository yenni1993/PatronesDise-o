namespace Decorator.Servicios
{
    public class HistorialCuentaPagar : DecoradorCuentaPagar
    {
        public HistorialCuentaPagar(ICuentaPagar _IGuardarCuentaPagar) : base(_IGuardarCuentaPagar)
        {
            cMensaje = "\n- También se guardó el historial de la cuenta por pagar.";
        }
    }
}
