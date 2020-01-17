using System;

namespace Bridge
{
    public class Client
    {
        public void RealizarMensajeria(string _cEmpresa)
        {
            ITipoEnvio ITipoEnvio;
            IEmpresaMensajeria IEmpresa;

            switch (_cEmpresa)
            {
                case "1":
                    Console.WriteLine("La empresa DHL realizará lo siguiente:");
                    Console.Write("\n");
                    ITipoEnvio = new TipoEnvioAvion();
                    IEmpresa = new EmpresaDHL(ITipoEnvio);
                    Console.WriteLine(IEmpresa.RecogerPedido());
                    Console.WriteLine(IEmpresa.EnviarPaquete());
                    Console.WriteLine(IEmpresa.EntregarPaquete());
                    Console.Write("\n");
                    ITipoEnvio = new TipoEnvioBarco();
                    IEmpresa = new EmpresaDHL(ITipoEnvio);
                    Console.WriteLine(IEmpresa.RecogerPedido());
                    Console.WriteLine(IEmpresa.EnviarPaquete());
                    Console.WriteLine(IEmpresa.EntregarPaquete());
                    break;
                case "2":
                    Console.WriteLine("La empresa Estafeta realizará lo siguiente:");
                    Console.Write("\n");
                    ITipoEnvio = new TipoEnvioTren();
                    IEmpresa = new EmpresaEstafeta(ITipoEnvio);
                    Console.WriteLine(IEmpresa.RecogerPedido());
                    Console.WriteLine(IEmpresa.EnviarPaquete());
                    Console.WriteLine(IEmpresa.EntregarPaquete());
                    break;
                case "3":
                    Console.WriteLine("La empresa Fedex realizará lo siguiente:");
                    Console.Write("\n");
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
