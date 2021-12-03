namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Important : HTMLDecoratorBase
    {
        public Important(IDecorator decorator) : base(decorator)
        {
            Tag = "strong";
        }
    }
}
