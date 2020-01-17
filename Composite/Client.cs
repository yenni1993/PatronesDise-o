namespace Composite
{
    public class Client
    {
        public void ObtenerSaldoTotal()
        {
            decimal dSaldo = 0.0M;
            IObtenerSaldoTotal UA1 = new ServicioUnidadAdministrativa();
            dSaldo = UA1.ObtenerSaldoTotal();
            ServicioUnidadAdministrativa UA2 = new ServicioUnidadAdministrativa();
            dSaldo = UA2.ObtenerSaldoTotal();

            IObtenerSaldoTotal CP1 = new ServicioClavePresupuestal();
            dSaldo = CP1.ObtenerSaldoTotal();
        }
    }
}
