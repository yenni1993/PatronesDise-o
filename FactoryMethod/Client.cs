using System;

namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("WindowsDialog");
            ClientCode(new WindowsDialog());

            Console.WriteLine("WebDialog");
            ClientCode(new WebDialog());

            Console.ReadLine();
        }

        public void ClientCode(Dialog dialog)
        {
            Console.WriteLine("Client: " + dialog.CreateButton().render());
            Console.WriteLine("Client: " + dialog.CreateButton().onClick());
        }

    }
}
