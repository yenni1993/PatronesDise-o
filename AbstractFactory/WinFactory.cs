namespace AbstractFactory
{
    public class WinFactory : GUIFactory
    {
        public IAbstractButton CreateButton()
        {
            return new WinButton();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }

        public IAbstractRadioButton CreateRadioButton()
        {
            return new WinRadioButton();
        }
    }
}
