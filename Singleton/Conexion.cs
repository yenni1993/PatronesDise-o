namespace Singleton
{
    public class Conexion
    {
        private Conexion()
        {
        }

        private static Conexion _conexion;

        public static Conexion ObtenerConexion()
        {
            if(_conexion == null)
            {
                _conexion = new Conexion();
            }
            return _conexion;
        }
    }
}
