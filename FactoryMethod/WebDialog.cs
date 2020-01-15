namespace FactoryMethod
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}
