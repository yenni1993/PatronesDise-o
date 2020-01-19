using Decorator.Servicios;
using System;

namespace Decorator
{
    public class Cliente
    {
        public void EjecutarGuardado(CuentaPagarDTO _oCuentaPagar)
        {
            string cResultado = string.Empty;
            ICuentaPagar IGuardarCxP = new CuentaPagar(_oCuentaPagar);
            Console.WriteLine(IGuardarCxP.Guardar());

            //Se debe guardar un historial al guardar una CXP.
            DecoradorCuentaPagar IGuardarHistorial = new HistorialCuentaPagar(IGuardarCxP);
            Console.WriteLine(IGuardarHistorial.Guardar());

            //Se requiere que cuando se guarde una CXP se envié un correo a un usuario.
            DecoradorCuentaPagar IGuardarCxpCorreo = new Correo(IGuardarCxP);
            IGuardarCxpCorreo.cNombreUsuario = _oCuentaPagar.cNombreUsuario;
            Console.WriteLine(IGuardarCxpCorreo.Guardar());

            //Se requiere que cuando se guarde una CXP se guarde un historial, y se envié un correo a un usuario.
            DecoradorCuentaPagar IGuardarCxpHistorialCorreo = new Correo(IGuardarHistorial);
            IGuardarCxpHistorialCorreo.cNombreUsuario = _oCuentaPagar.cNombreUsuario;
            Console.WriteLine(IGuardarCxpHistorialCorreo.Guardar());
        }
    }
}
