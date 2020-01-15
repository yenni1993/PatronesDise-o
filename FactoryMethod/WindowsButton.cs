namespace FactoryMethod
{
    public class WindowsButton : IButton
    {
        public string onClick()
        {
            return "Es el método onClick() de WindowsButton";
        }

        public string render()
        {
            return "Es el método render() de WindowsButton";
        }
    }
}
