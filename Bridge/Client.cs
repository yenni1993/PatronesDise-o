using System;

namespace Bridge
{
    public class Client
    {
        public void RealizarMensajeria(string _cEmpresa, string _cTipoEnvio)
        {
            ITipoEnvio ITipoEnvio;
            IEmpresaMensajeria IEmpresa;

            switch (_cEmpresa)
            {
                case "1":
                    ITipoEnvio = new TipoEnvioAvion();
                    IEmpresa = new EmpresaDHL(ITipoEnvio);
                    Console.WriteLine(IEmpresa.RecogerPedido());
                    Console.WriteLine(IEmpresa.EnviarPaquete());
                    Console.WriteLine(IEmpresa.EntregarPaquete());

                    ITipoEnvio = new TipoEnvioBarco();
                    IEmpresa = new EmpresaDHL(ITipoEnvio);
                    Console.WriteLine(IEmpresa.RecogerPedido());
                    Console.WriteLine(IEmpresa.EnviarPaquete());
                    Console.WriteLine(IEmpresa.EntregarPaquete());
                    break;
                case "2":
                    ITipoEnvio = new TipoEnvioTren();
                    IEmpresa = new EmpresaEstafeta(ITipoEnvio);
                    Console.WriteLine(IEmpresa.RecogerPedido());
                    Console.WriteLine(IEmpresa.EnviarPaquete());
                    Console.WriteLine(IEmpresa.EntregarPaquete());
                    break;
                case "3":
                    ITipoEnvio = new TipoEnvioBarco();
                    IEmpresa = new EmpresaFedex(ITipoEnvio);
                    Console.WriteLine(IEmpresa.RecogerPedido());
                    Console.WriteLine(IEmpresa.EnviarPaquete());
                    Console.WriteLine(IEmpresa.EntregarPaquete());
                    break;
            }
        }
    }
}
