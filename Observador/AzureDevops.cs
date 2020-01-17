using System;
using System.Collections.Generic;

namespace Observador
{
    public class AzureDevops//Observado
    {
        private List<IAccionCodigo> lstIObservador = new List<IAccionCodigo>();

        public void AlojarCodigo()//mainBusinessLogic
        {
            NotificarAplicacion();
        }

        public void AgregarCodigo(IAccionCodigo _IObservador)//Subscribe
        {
            lstIObservador.Add(_IObservador);
        }

        private void NotificarAplicacion()//NotifySubscribers
        {
            foreach (IAccionCodigo IObservador in lstIObservador)
            {
                Console.Write("Observador: ");
                IObservador.RealizarAccion();
            }
        }
    }
}
