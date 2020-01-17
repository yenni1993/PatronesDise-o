using System.Collections.Generic;

namespace Composite
{
    public class ServicioUnidadAdministrativa : IObtenerSaldoTotal
    {
        List<IObtenerSaldoTotal> lstIObtenerSaldoTotal = new List<IObtenerSaldoTotal>();

        public decimal ObtenerSaldoTotal()
        {
            decimal dSaldo = 15;
            lstIObtenerSaldoTotal.Add(this);
            return dSaldo;
        }
    }
}
