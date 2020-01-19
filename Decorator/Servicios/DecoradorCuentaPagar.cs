namespace Decorator.Servicios
{
    public abstract class DecoradorCuentaPagar : ICuentaPagar
    {
        public string cNombreUsuario { get; set; }
        protected string cMensaje = string.Empty;
        ICuentaPagar IGuardarCuentaPagar;

        public DecoradorCuentaPagar(ICuentaPagar _IGuardarCuentaPagar)
        {
            this.IGuardarCuentaPagar = _IGuardarCuentaPagar;
        }

        public string Guardar()
        {
            return $"{this.IGuardarCuentaPagar.Guardar()} {cMensaje} {cNombreUsuario}";
        }
    }
}
