namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class HTMLBase : IDecorator
    {
        public string Text { get; set; }

        public HTMLBase(string text)
        {
            Text = text;
        }

        public string GetHTML() => Text;
    }
}
