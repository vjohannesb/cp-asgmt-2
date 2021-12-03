namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal abstract class HTMLDecoratorBase : IDecorator
    {
        protected HTMLDecoratorBase(IDecorator decorator)
        {
            Decorator = decorator;
        }

        public string Tag { get; set; }
        public IDecorator Decorator { get; set; }

        public string GetHTML() => $"<{Tag}>" + Decorator.GetHTML() + $"</{Tag}>";
    }
}
