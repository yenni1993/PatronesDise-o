using System.Collections.Generic;
using Adaptador.Entidades;
using Adaptador.Interfaces;

namespace Adaptador
{
    public class BuscarSucursalServicio : IBuscarSucursal
    {
        public List<Sucursal> BuscarListaSucursales()
        {
            List<Sucursal> lstSucursal = new List<Sucursal>();

            for (int i = 1; i <= 10; i++)
            {
                Sucursal sucursal = new Sucursal();
                sucursal.iId = i;
                sucursal.cNombre = $"Sucursal {sucursal.iId}";
                sucursal.iTotalVenta = 9 + i;
                lstSucursal.Add(sucursal);
            }
            return lstSucursal;
        }
    }
}
