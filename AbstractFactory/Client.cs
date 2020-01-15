using System;

namespace AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("WinFactory");
            ClientMethod(new WinFactory());
            Console.WriteLine("");
            Console.WriteLine("MacFactory");
            ClientMethod(new MacFactory());
            Console.ReadLine();
        }

        public void ClientMethod(GUIFactory guiFactory)
        {
            var button = guiFactory.CreateButton();
            var checkbox = guiFactory.CreateCheckBox();
            var radiobutton = guiFactory.CreateRadioButton();

            Console.WriteLine(button.UsefulFunctionButton());
            Console.WriteLine(checkbox.UsefulFunctionButtonCheckBox());
            Console.WriteLine(radiobutton.UsefulFunctionRadioButton());
        }
    }
}
