using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conexion conexion1 = Conexion.ObtenerConexion();
            Conexion conexion2 = Conexion.ObtenerConexion();

            if(conexion1 == conexion2)
            {
                Console.WriteLine("CORRECTO: Ambas variables contienen la misma instancia");
            }
            else
            {
                Console.WriteLine("FALLÓ: Ambas variables contienen diferentes instancias");
            }

            Console.ReadLine();
        }
    }
}
