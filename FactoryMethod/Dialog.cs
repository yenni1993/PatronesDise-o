namespace FactoryMethod
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public string render()
        {
            return "Es el método render()";
        }
    }
}
