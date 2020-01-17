using System;

namespace Observador
{  
    public class Client
    {
        private AzureDevops observado = new AzureDevops();

        public AzureDevops AgregarCodigo()
        {
            IAccionCodigo IObservador;

            Console.WriteLine("Observado: Azure Devops");

            IObservador = new CompilarCodigo();
            observado.AgregarCodigo(IObservador);

            IObservador = new EjecutarPruebasUnitarias();
            observado.AgregarCodigo(IObservador);

            IObservador = new InstalarVersion();
            observado.AgregarCodigo(IObservador);

            IObservador = new EnviarCorreoNotificacion();
            observado.AgregarCodigo(IObservador);

            return observado;
        }

        public void AlojarCodigo()
        {
            observado.AlojarCodigo();
        }
    }
}
