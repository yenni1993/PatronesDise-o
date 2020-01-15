namespace FactoryMethod
{
    public class HTMLButton : IButton
    {
        public string onClick()
        {
            return "Es el método onClick() de HTMLButton";
        }

        public string render()
        {
            return "Es el método render() de HTMLButton";
        }
    }
}
