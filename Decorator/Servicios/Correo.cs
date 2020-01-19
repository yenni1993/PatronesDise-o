namespace Decorator.Servicios
{
    public class Correo : DecoradorCuentaPagar
    {
        public Correo(ICuentaPagar _IGuardarCuentaPagar) : base(_IGuardarCuentaPagar)
        {
            cMensaje = $"\n- También se envió correo al usuario:";
        }
    }
}
