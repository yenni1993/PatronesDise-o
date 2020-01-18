using System;

namespace ChainResponsability
{
    public class Menu
    {
        public void PrepararMenuInformacion()
        {
            Console.WriteLine("SOLICITUDES DE COMPRA DE BLUE OCEAN");
            Console.Write("\n");
            Console.WriteLine("IMPORTANTE:");
            Console.WriteLine("Autoriza coordinador cuando el costo del producto es menor o igual a $5,000.");
            Console.WriteLine("Autoriza gerente cuando el costo del producto es mayor a $5,000 y menor o igual a $10,000.");
            Console.WriteLine("Autoriza subdirector cuando el costo del producto es mayor a $10,000 y menor o igual a $15,000.");
            Console.WriteLine("Autoriza director cuando el costo del producto es mayor a $15,000 y menor o igual a $50,000.");
            Console.WriteLine("Rechaza director cuando el costo del producto es mayor a $50,000.");
            Console.Write("\n");
        }

        public DatosCompra PrepararMenuDatosCompra()
        {
            int iPrecioProducto = 0;
            string cPrecioProducto = string.Empty;
            DatosCompra oDatosCompra = new DatosCompra();

            Console.WriteLine("DATOS DE LA COMPRA:");
            Console.Write("Escribe el nombre del producto: ");
            oDatosCompra.cNombreProducto = Console.ReadLine();
            Console.Write("Escribe el precio del producto: ");
            cPrecioProducto = Console.ReadLine();
            Console.Write("\n");

            int.TryParse(cPrecioProducto, out iPrecioProducto);
            oDatosCompra.iPrecioProducto = iPrecioProducto;
            return oDatosCompra;
        }


        public string PrepararMenuConfirmacion()
        {
            string cRespuesta = string.Empty;

            Console.Write("\n");
            Console.WriteLine("¿Desea continuar con la operación?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            Console.Write("Escribe una opción: ");
            cRespuesta = Console.ReadLine();
            Console.Write("\n");

            return cRespuesta;
        }
    }
}
