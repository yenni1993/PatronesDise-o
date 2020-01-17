namespace Strategy
{
    public class GuardarImagenJPG : IGuardarImagen
    {
        public string GuardarImagen(string _cNombreImagen)
        {
            return $"Se ha guardado la imagen { _cNombreImagen }.jpg";
        }
    }
}
