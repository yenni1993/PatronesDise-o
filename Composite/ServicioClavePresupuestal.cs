namespace Composite
{
    public class ServicioClavePresupuestal : IObtenerSaldoTotal
    {
        ClavePresupuestal clavePresupuestal;

        public decimal ObtenerSaldoTotal()
        {
            clavePresupuestal.cMes = "Enero";
            clavePresupuestal.cUA = "1.1";
            clavePresupuestal.dSaldo = 15;
        }

        public ClavePresupuestal ObtenerClavePresupuestal(string _cUA, string _cMes, decimal _dSaldo)
        {
            clavePresupuestal
        }
    }
}
