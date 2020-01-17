using Adaptador.Interfaces;

namespace Adaptador
{
    public class BuscarSucursalEnArchivo : IBuscarSucursalEnArchivo
    {
        string IBuscarSucursalEnArchivo.BuscarSucursalEnArchivo()
        {
            string cJson = string.Empty;
            string cJsonGlobal = "{\"lstSucursal\": [";

            for (int i = 1; i <= 5; i++)
            {
                cJson = "{ \"iId\":" + i + "," +
                "\"cNombre\":\"Sucursal" + i + "\"," +
                "\"iTotalVenta\":" + (5 + i) + " },";
                cJsonGlobal += cJson;
            }

            cJsonGlobal = cJsonGlobal.TrimEnd(',');
            cJsonGlobal += "]}";

            return cJsonGlobal;
        }
    }
}
