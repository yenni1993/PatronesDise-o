namespace Composite
{
    public class LeafUA : IObtenerSaldoTotal
    {
        public ClavePresupuestal clavePresupuestal { get; set; }

        public LeafUA(ClavePresupuestal _clavePresupuestal)
        {
            this.clavePresupuestal = _clavePresupuestal;
        }

        public decimal ObtenerSaldoTotal()
        {
            decimal dSaldo = 0.0M;
            dSaldo = clavePresupuestal.dSaldoEnero + clavePresupuestal.dSaldoFebrero + clavePresupuestal.dSaldoMarzo;
            return dSaldo;
        }
    }
}
