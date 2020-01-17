namespace Observador
{
    public class Client
    {
        public void Main()
        {
            Observado observado = new Observado();
            IObservador IObservador = new Observador();
            //observado.Suscribir(IObservador);
        }
    }
}
