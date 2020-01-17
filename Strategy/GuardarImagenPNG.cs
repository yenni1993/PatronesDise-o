namespace Strategy
{
    public class GuardarImagenPNG : IGuardarImagen
    {
        public string GuardarImagen(string _cNombreImagen)
        {
            return $"Se ha guardado la imagen { _cNombreImagen }.png";
        }
    }
}
