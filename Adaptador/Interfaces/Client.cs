using Adaptador.Entidades;
using System;
using System.Collections.Generic;

namespace Adaptador.Interfaces
{
    public class Client
    {
        public void BuscarListaSucursales()
        {
            string cJsonSucursal = string.Empty;
            List<Sucursal> lstSucursal = new List<Sucursal>();
            IBuscarSucursal IBuscarSucursal = new BuscarSucursalServicio();
            IBuscarSucursalEnArchivo IBuscarSucursalEnArchivo = new BuscarSucursalEnArchivo();
            IBuscarSucursal adaptador = new Adaptador(IBuscarSucursalEnArchivo);

            lstSucursal = IBuscarSucursal.BuscarListaSucursales();
            Console.WriteLine("Buscar Lista de Sucursales");

            foreach(Sucursal suc in lstSucursal)
            {
                Console.WriteLine($"Id: {suc.iId} Nombre: {suc.cNombre} Total de Venta: {suc.iTotalVenta}");
            }

            Console.WriteLine("\n");
            lstSucursal = adaptador.BuscarListaSucursales();
            Console.WriteLine("Buscar Lista de Sucursales en Archivo JSON");

            foreach (Sucursal suc in lstSucursal)
            {
                Console.WriteLine($"Id: {suc.iId} Nombre: {suc.cNombre} Total de Venta: {suc.iTotalVenta}");
            }
        }
    }
}
