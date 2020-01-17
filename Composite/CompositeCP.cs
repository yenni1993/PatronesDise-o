using System;
using System.Collections.Generic;

namespace Composite
{
    public class CompositeCP : IObtenerSaldoTotal
    {
        private string cNombre { get; set; }
        private List<IObtenerSaldoTotal> lstIObtenerSaldoTotal;

        public CompositeCP(string _cNombre)
        {
            this.cNombre = _cNombre;
            lstIObtenerSaldoTotal = new List<IObtenerSaldoTotal>();
        }

        public void Agregar(IObtenerSaldoTotal _IObtenerSaldoTotal)
        {
            lstIObtenerSaldoTotal.Add(_IObtenerSaldoTotal);
        }

        public List<IObtenerSaldoTotal> ObtenerUnidadAdministrativa()
        {
            return lstIObtenerSaldoTotal;
        }

        public decimal ObtenerSaldoTotal()
        {
            decimal dSaldoTotal = 0.0M;

            foreach(IObtenerSaldoTotal IObtenerSaldoTotal in lstIObtenerSaldoTotal)
            {
                dSaldoTotal += IObtenerSaldoTotal.ObtenerSaldoTotal();
            }

            Console.WriteLine($"{cNombre} con saldo de: {dSaldoTotal}");
            return dSaldoTotal;
        }
    }
}
