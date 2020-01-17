namespace Strategy
{
    public class GuardarImagenBMP : IGuardarImagen
    {
        public string GuardarImagen(string _cNombreImagen)
        {
            return $"Se ha guardado la imagen { _cNombreImagen }.bmp";
        }
    }
}
