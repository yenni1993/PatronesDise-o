namespace AbstractFactory
{
    public interface GUIFactory
    {
        IAbstractButton CreateButton();
        IAbstractCheckBox CreateCheckBox();
        IAbstractRadioButton CreateRadioButton();
    }
}
