namespace AbstractFactory
{
    public class MacFactory : GUIFactory
    {
        public IAbstractButton CreateButton()
        {
            return new MacButton();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }

        public IAbstractRadioButton CreateRadioButton()
        {
            return new MacRadioButton();
        }
    }
}
