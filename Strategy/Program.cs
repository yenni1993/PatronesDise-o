using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cNombreImagen = string.Empty;
            string cOpcion = string.Empty;
            string cMensaje = string.Empty;
            IGuardarImagen IGuardarImagen = null;
            GuardadorImagen guardador = new GuardadorImagen();

            Console.WriteLine("Escribir nombre de la imagen:");
            cNombreImagen = Console.ReadLine();
            Console.WriteLine("¿En que extensión del formato desea guardar la imagen?");
            Console.WriteLine("1. BMP");
            Console.WriteLine("2. PNG");
            Console.WriteLine("3. JPG");
            cOpcion = Console.ReadLine(); 
            
            IGuardarImagen = guardador.SeleccionarOpcionGuardar(cOpcion);
            guardador.AgregarImagen(IGuardarImagen);
            cMensaje = guardador.Guardar(cNombreImagen);

            Console.WriteLine(cMensaje);
            Console.ReadLine();
        }
    }
}
