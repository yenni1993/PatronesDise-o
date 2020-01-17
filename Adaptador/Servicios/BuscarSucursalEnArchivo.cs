using Adaptador.Interfaces;

namespace Adaptador
{
    public class BuscarSucursalEnArchivo : IBuscarSucursalEnArchivo
    {
        string IBuscarSucursalEnArchivo.BuscarSucursalEnArchivo()
        {
            string cJson = string.Empty;
            cJson = "{\"Sucursales\":[" +
                "\"iId\":1," +
                "\"cNombre\":\"Sucursal1\", " +
                "\"iTotal\":10]}";
            return cJson;
        }
    }
}
