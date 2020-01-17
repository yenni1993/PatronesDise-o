namespace Strategy
{
    public class GuardadorImagen
    {
        IGuardarImagen IGuardarImagen { get; set; }

        public IGuardarImagen SeleccionarOpcionGuardar(string cOpcion)
        {
            switch (cOpcion)
            {
                case "1":
                    IGuardarImagen = new GuardarImagenBMP();
                    break;
                case "2":
                    IGuardarImagen = new GuardarImagenPNG();
                    break;
                case "3":
                    IGuardarImagen = new GuardarImagenJPG();
                    break;
            }

            return IGuardarImagen;
        }

        public void AgregarImagen(IGuardarImagen _IGuardarImagen)
        {
            IGuardarImagen = _IGuardarImagen;
        }

        public string Guardar(string _cNombreImagen)
        {
            return IGuardarImagen.GuardarImagen(_cNombreImagen);
        }
    }
}
