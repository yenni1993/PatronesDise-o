namespace Decorator.Servicios
{
    public class CuentaPagar : ICuentaPagar
    {
        private CuentaPagarDTO oCuentaPagarDTO;

        public CuentaPagar(CuentaPagarDTO _oCuentaPagarDTO)
        {
            this.oCuentaPagarDTO = _oCuentaPagarDTO;
        }

        public string Guardar()
        {
            return $"\nSe guardó la cuenta por pagar con id: {this.oCuentaPagarDTO.iId}, con importe: {this.oCuentaPagarDTO.dImporte} y con naturaleza: {this.oCuentaPagarDTO.cNaturaleza}.";
        }
    }
}
