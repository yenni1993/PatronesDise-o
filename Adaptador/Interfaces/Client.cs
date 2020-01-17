using Adaptador.Entidades;
using System;
using System.Collections.Generic;

namespace Adaptador.Interfaces
{
    public class Client
    {
        public void Main()
        {
            string cJsonSucursal = string.Empty;
            List<Sucursal> lstSucursal = new List<Sucursal>();
            IBuscarSucursal IBuscarSucursal = new BuscarSucursalServicio();
            lstSucursal = IBuscarSucursal.BuscarListaSucursales();

            Console.WriteLine("Lista Sucursal");
            foreach(Sucursal suc in lstSucursal)
            {
                Console.WriteLine($"Id: {suc.iId} Nombre: {suc.cNombre} Total de Venta: {suc.iTotalVenta}");
            }

            Console.WriteLine("\n");
            IBuscarSucursalEnArchivo IBuscarSucursalEnArchivo = new BuscarSucursalEnArchivo();
            IBuscarSucursal adaptador = new Adaptador(IBuscarSucursalEnArchivo);
            lstSucursal = adaptador.BuscarListaSucursales();

            Console.WriteLine("Lista Sucursal en JSON");
            foreach (Sucursal suc in lstSucursal)
            {
                Console.WriteLine($"Id: {suc.iId} Nombre: {suc.cNombre} Total de Venta: {suc.iTotalVenta}");
            }
        }
    }
}
