using System.Collections.Generic;
using Adaptador.Entidades;
using Adaptador.Interfaces;
using Newtonsoft.Json;

namespace Adaptador
{
    public class Adaptador : IBuscarSucursal
    {
        IBuscarSucursalEnArchivo IBuscarSucursalEnArchivo;

        public Adaptador(IBuscarSucursalEnArchivo _IBuscarSucursalEnArchivo)
        {
            IBuscarSucursalEnArchivo = _IBuscarSucursalEnArchivo;
        }

        public List<Sucursal> BuscarListaSucursales()
        {
            string cSucursal = string.Empty;
            List<Sucursal> lstSucursal = new List<Sucursal>();
            cSucursal = IBuscarSucursalEnArchivo.BuscarSucursalEnArchivo();
            lstSucursal = JsonConvert.DeserializeObject<ListaSucursales>(cSucursal).Sucursales;
            return lstSucursal;
        }
    }

    public class ListaSucursales
    {
        public List<Sucursal> Sucursales { get; set; }
    }
}
